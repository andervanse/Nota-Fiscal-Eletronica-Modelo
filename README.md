# Nota Fiscal Eletrônica - CSharp
Modelo classes com a estrutura da Nota fiscal eletrônica
Serialização a partir de arquivo XML ou Stream
Validação através dos schemas publicados no [site da NF-e](http://www.nfe.fazenda.gov.br/portal/listaConteudo.aspx?tipoConteudo=/fwLvLUSmU8=)

### Como usar
        NotaFiscalEletronica notaFiscal = null;
        using (FileStream fs = new FileStream("Nfe.xml", FileMode.Open))
        {
            notaFiscal = nfeSerializer.DeserializeFromStream<NotaFiscalEletronica>(fs);
            Debug.WriteLine(String.Format("Num Nfe.: {0}", notaFiscal.InfNfe.Ide.NumNf));
            Debug.WriteLine(String.Format("Remetente.: {0}", notaFiscal.InfNfe.Emitente.Nome));
            Debug.WriteLine(String.Format("Destinatário.: {0}", notaFiscal.InfNfe.Destinatario.Nome));
            Debug.WriteLine(String.Format("Qtde. Itens.: {0}", notaFiscal.InfNfe.Itens.Count));            
        }
        
### Exemplo prático
  http://andersondavanse.com.br/Projects
  
  http://andersondavanse.com.br/Projects/Nfe/ValidaXmlNfe
