
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Fiscal.Nfe.Domain
{
    public class NfeXmlSerializer
    {
        public T DeserializeFromFile<T>(string fileFullName)
            where T : class
        {
            T t;

            FileStream fs = null;
            XmlReader reader = null;

            try
            {
                fs = new FileStream(fileFullName, FileMode.Open);
                reader = XmlReader.Create(fs);

                var serializer = new XmlSerializer(typeof(T));
                t = (T)serializer.Deserialize(reader);
            }
            finally
            {

                if (fs != null)
                    fs.Dispose();
            }

            return t;
        }

        public T DeserializeFromStream<T>(Stream stream)
            where T:class
        {
            T nfeType;

            stream.Position = 0;

            using (XmlReader reader = XmlReader.Create(stream))
            {
                var serializer = new XmlSerializer(typeof(T));
                nfeType = (T)serializer.Deserialize(reader);
            }

            return nfeType;
        }

        public List<string> Validate(string fileFullName, string schemaXsd)            
        {
            var localSchemaXsd = GetSchemaXsdFileName(schemaXsd);

            if ((!string.IsNullOrEmpty(schemaXsd)) && (File.Exists(schemaXsd)))
                localSchemaXsd = schemaXsd;

            List<string> xsdMessages = new List<string>();

            XmlReaderSettings nfeSettings = new XmlReaderSettings();
            nfeSettings.Schemas.Add("http://www.portalfiscal.inf.br/nfe", localSchemaXsd);
            nfeSettings.ValidationType = ValidationType.Schema;
            nfeSettings.ValidationEventHandler += (sender, e) =>
                {
                    if (e.Severity == XmlSeverityType.Warning)
                    {
                        xsdMessages.Add("Aviso: " + e.Message);
                    }
                    else if (e.Severity == XmlSeverityType.Error)
                    {
                        xsdMessages.Add("Erro: " + e.Message);
                    }
                };

            using (XmlReader reader = XmlReader.Create(fileFullName, nfeSettings))
            {
                while (reader.Read()) { }
            }

            return xsdMessages;
        }

        public List<string> Validate(Stream stream, string schemaXsd)
        {

            List<string> xsdMessages = new List<string>();

            if ((!string.IsNullOrEmpty(schemaXsd)) && (File.Exists(schemaXsd)))
            {
                XmlReaderSettings nfeSettings = new XmlReaderSettings();
                nfeSettings.Schemas.Add("http://www.portalfiscal.inf.br/nfe", schemaXsd);
                nfeSettings.ValidationType = ValidationType.Schema;
                nfeSettings.ValidationEventHandler += (sender, e) =>
                {
                    if (e.Severity == XmlSeverityType.Warning)
                    {
                        xsdMessages.Add("Aviso: " + e.Message);
                    }
                    else if (e.Severity == XmlSeverityType.Error)
                    {
                        xsdMessages.Add("Erro: " + e.Message);
                    }
                };

                stream.Position = 0;
                using (XmlReader reader = XmlReader.Create(stream, nfeSettings))
                {
                    while (reader.Read()) { }
                }
            }

            return xsdMessages;
        }

        private string GetSchemaXsdFileName(string schemaXsd)
        {
            var localSchemaXsd = schemaXsd;
            return localSchemaXsd;
        }
    }
}
