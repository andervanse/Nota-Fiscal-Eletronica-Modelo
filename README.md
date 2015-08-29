# Nota Fiscal Eletrônica - CSharp
Conjunto de classes mapeadas conforme o manual da Nota fiscal eletrônica v4.01 disponível [aqui](http://www.nfe.fazenda.gov.br/portal/listaConteudo.aspx?tipoConteudo=33ol5hhSYZk=)
Serialização a partir de arquivo XML ou Stream
Validação através dos schemas publicados no [site da NF-e](http://www.nfe.fazenda.gov.br/portal/listaConteudo.aspx?tipoConteudo=/fwLvLUSmU8=)

### Exemplo
        NotaFiscalEletronica notaFiscal = null;
        using (FileStream fs = new FileStream("Nfe.xml", FileMode.Open))
        {
            notaFiscal = nfeSerializer.DeserializeFromStream<NotaFiscalEletronica>(fs);
            Debug.WriteLine(String.Format("Num Nfe.: {0}", notaFiscal.InfNfe.Ide.NumNf));
            Debug.WriteLine(String.Format("Remetente.: {0}", notaFiscal.InfNfe.Emitente.Nome));
            Debug.WriteLine(String.Format("Destinatário.: {0}", notaFiscal.InfNfe.Destinatario.Nome));
            Debug.WriteLine(String.Format("Qtde. Itens.: {0}", notaFiscal.InfNfe.Itens.Count));            
        }
        

  Visualização de Danfe -> http://andersondavanse.com.br/Projects
  
  Validação -> http://andersondavanse.com.br/Projects/Nfe/ValidaXmlNfe
