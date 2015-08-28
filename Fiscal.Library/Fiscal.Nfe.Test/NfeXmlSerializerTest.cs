using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fiscal.Nfe.Models;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using Fiscal.Nfe.Domain;

namespace Fiscal.Nfe.Test
{
    [TestClass]
    public class NfeXmlSerializerTest
    {
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void Testa_Exception_FileNotFound()
        {
            var nfeSerializer = new NfeXmlSerializer();

            NfeProc nfe = nfeSerializer.DeserializeFromFile<NfeProc>("Nfe_0000.xml");

            Assert.IsTrue(nfe != null);
        }

        [TestMethod]
        public void Verifica_Deserializacao_From_File()
        {
            var nfeSerializer = new NfeXmlSerializer();
            NfeProc nfe = nfeSerializer.DeserializeFromFile<NfeProc>("NfeProc.xml");

            Assert.IsTrue(nfe != null);
            Assert.IsTrue(nfe.Nfe != null);
            Debug.WriteLine(String.Format("Num Nfe.: {0}", nfe.Nfe.InfNfe.Ide.NumNf));

            Debug.WriteLine(String.Format("Remetente.: {0}", nfe.Nfe.InfNfe.Emitente.Nome));
            Debug.WriteLine(String.Format("Destinatário.: {0}", nfe.Nfe.InfNfe.Destinatario.Nome));
            Debug.WriteLine(String.Format("Qtde. Itens.: {0}", nfe.Nfe.InfNfe.Itens.Count));

            Assert.IsTrue(nfe.Nfe.InfNfe.Itens.Count > 0);            

            foreach (var item in nfe.Nfe.InfNfe.Itens)
            {
                Debug.WriteLine(String.Format("Produto .: {0}", item.Produto.Descricao));
                Debug.WriteLine(String.Format("Inf. Adicional .: {0}", item.InfAdProd));
            }

            NotaFiscalEletronica notaFiscal = nfeSerializer.DeserializeFromFile<NotaFiscalEletronica>("Nfe.xml");

            Assert.IsTrue(notaFiscal != null);
        }


        [TestMethod]
        public void Verifica_Deserializacao_From_Stream()
        {
            var nfeSerializer = new NfeXmlSerializer();

            NfeProc nfe = null;

            using(FileStream fs = new FileStream("NfeProc.xml", FileMode.Open))
            {
                nfe = nfeSerializer.DeserializeFromStream<NfeProc>(fs);
            }

            Assert.IsTrue(nfe != null);
            Assert.IsTrue(nfe.Nfe != null);
            Debug.WriteLine(String.Format("Num Nfe.: {0}", nfe.Nfe.InfNfe.Ide.NumNf));
            Debug.WriteLine(String.Format("Remetente.: {0}", nfe.Nfe.InfNfe.Emitente.Nome));
            Debug.WriteLine(String.Format("Destinatário.: {0}", nfe.Nfe.InfNfe.Destinatario.Nome));
            Debug.WriteLine(String.Format("Qtde. Itens.: {0}", nfe.Nfe.InfNfe.Itens.Count));

            Assert.IsTrue(nfe.Nfe.InfNfe.Itens.Count > 0);            

            foreach (var item in nfe.Nfe.InfNfe.Itens)
            {
                Debug.WriteLine(String.Format("Produto .: {0}", item.Produto.Descricao));
                Debug.WriteLine(String.Format("Inf. Adicional .: {0}", item.InfAdProd));
            }

            NotaFiscalEletronica notaFiscal = null;

            using (FileStream fs = new FileStream("Nfe.xml", FileMode.Open))
            {
                notaFiscal = nfeSerializer.DeserializeFromStream<NotaFiscalEletronica>(fs);
            }

            Assert.IsTrue(notaFiscal != null);
        }

        [TestMethod]
        public void Verifica_Validacao_XSD_Tipo_NfeProc()
        {
            var nfeSerializer_NfeProc = new NfeXmlSerializer();
            var nfeproc = nfeSerializer_NfeProc.DeserializeFromFile<NfeProc>("NfeProc.xml");

            var schemaFile = NfeSchemaFileResolver<NfeProc>.GetByNfeVersion(nfeproc.Versao);

            using (FileStream fs = new FileStream("NfeProc.xml", FileMode.Open))
            {
                List<string> messages = nfeSerializer_NfeProc.Validate(fs, schemaFile);

                foreach (var str in messages)
                    Debug.WriteLine(str);

                Assert.IsTrue(messages.Count == 0);
            }          
        }

        [TestMethod]
        public void Verifica_Validacao_XSD_Tipo_NotaFiscalEletronica()
        {
            var nfeSerializer = new NfeXmlSerializer();
            var nfe = nfeSerializer.DeserializeFromFile<NotaFiscalEletronica>("Nfe.xml");
            var schemaFile = NfeSchemaFileResolver<NotaFiscalEletronica>.GetByNfeVersion(nfe.InfNfe.Versao);

            using (FileStream fs = new FileStream("Nfe.xml", FileMode.Open))
            {
                List<string> messages = nfeSerializer.Validate(fs, schemaFile);

                foreach (var str in messages)
                    Debug.WriteLine(str);

                Assert.IsTrue(messages.Count == 0);
            }            
        }

    }
}
