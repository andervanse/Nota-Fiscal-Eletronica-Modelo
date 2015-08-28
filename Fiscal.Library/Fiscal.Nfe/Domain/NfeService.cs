using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Fiscal.Nfe.Models;

namespace Fiscal.Nfe.Domain
{
    public class NfeValidation
    {
        public string NumNf { get; set; }
        public string Message { get; set; }
    }

    public class NfeService
    {

        public List<NfeProc> GetNfeProcList(List<Stream> pStreamList)
        {
            List<NfeProc> nfeProcList = new List<NfeProc>();

            if (pStreamList != null && pStreamList.Any())
            {
                NfeXmlSerializer xmlSerializer = new NfeXmlSerializer();

                pStreamList.Select(stream => stream)
                    .ToList()
                    .ForEach(inputStream =>
                        {
                            NfeProc nfeProc = null;
                            try
                            {
                                nfeProc = xmlSerializer.DeserializeFromStream<NfeProc>(inputStream);
                            }
                            catch (InvalidOperationException)
                            {
                                if (nfeProc == null)
                                {
                                    try
                                    {
                                        NotaFiscalEletronica nota = xmlSerializer.DeserializeFromStream<NotaFiscalEletronica>(inputStream);

                                        nfeProc = new NfeProc
                                        {
                                            ProtNfe = new ProtNfe
                                            {
                                                InfProt = new InfProt
                                                {
                                                    ChaveNFe = nota.InfNfe.Id.Replace("NFe", ""),
                                                    tpAmb = nota.InfNfe.Ide.tpAmb,
                                                    VerAplic = nota.InfNfe.Ide.VerProc,
                                                    Motivo = "Protocolo não encontrado"
                                                }
                                            },

                                            Nfe = nota
                                        };
                                    }
                                    catch (InvalidOperationException)
                                    {
                                        nfeProc = new NfeProc { ProtNfe = new ProtNfe { InfProt = new InfProt { Motivo = "Falha ao processar arquivo" } } };
                                    }
                                }
                            }
                            nfeProcList.Add(nfeProc);
                        });
            }

            return nfeProcList;
        }

        public List<NfeValidation> GetNfeValidationMessages(string path, List<Stream> pStreamList)
        {
            List<NfeValidation> NfeValidationList = new List<NfeValidation>();
            
            if (pStreamList != null && pStreamList.Any())
            {
                NfeXmlSerializer xmlSerializer = new NfeXmlSerializer();
                string xsdFileName = null;
                List<string> validationList = null;

                pStreamList.Select(stream => stream)
                    .ToList()
                    .ForEach(inputStream =>
                    {
                        NfeProc nfeProc = null;
                        try
                        {                            
                            nfeProc = xmlSerializer.DeserializeFromStream<NfeProc>(inputStream);
                            xsdFileName = NfeSchemaFileResolver<NfeProc>.GetByNfeVersion(nfeProc.Versao);
                            var xsdFileNamePath = Path.Combine(path, xsdFileName);
                            validationList = xmlSerializer.Validate(inputStream, xsdFileNamePath);
                            validationList.ForEach(msg => NfeValidationList.Add(new NfeValidation { NumNf = nfeProc.Nfe.InfNfe.Ide.NumNf, Message = msg }));

                            if (!validationList.Any())
                            {
                                NfeValidationList.Add(new NfeValidation { NumNf = nfeProc.Nfe.InfNfe.Ide.NumNf, Message = "Nenhuma inconsistência encontrada" });
                            }
                        }
                        catch (InvalidOperationException)
                        {
                            if (nfeProc == null)
                            {
                                try
                                {
                                    NotaFiscalEletronica nota = xmlSerializer.DeserializeFromStream<NotaFiscalEletronica>(inputStream);
                                    xsdFileName = NfeSchemaFileResolver<NotaFiscalEletronica>.GetByNfeVersion(nota.InfNfe.Versao);
                                    var xsdFileNamePath = Path.Combine(path, xsdFileName);
                                    validationList = xmlSerializer.Validate(inputStream, xsdFileNamePath);
                                    validationList.ForEach(msg => NfeValidationList.Add(new NfeValidation { NumNf = nota.InfNfe.Ide.NumNf, Message = msg }));

                                    if (!validationList.Any())
                                    {
                                        NfeValidationList.Add(new NfeValidation { NumNf = nota.InfNfe.Ide.NumNf, Message = "Nenhuma inconsistência encontrada" });
                                    }
                                }
                                catch (Exception e)
                                {
                                    NfeValidationList.Add(new NfeValidation { NumNf = "", Message = e.Message });
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            NfeValidationList.Add(new NfeValidation { NumNf = "", Message = e.Message });
                        }
                    });
            }

            return NfeValidationList;
        }

        public NfeProc GetFakeNfeProc()
        {
            var nfeProc = new NfeProc()
            {
                ProtNfe = new ProtNfe
                {
                    InfProt = new InfProt
                    {
                        ChaveNFe = "1111111111111111111111111111111",
                        Id = "11111111111111111111111",
                        CodStatus = "1111",
                        NumProt = "111111"
                    },
                    Versao = "1.0.0"
                },
                Nfe = new NotaFiscalEletronica
                {
                    InfNfe = new InfNFe
                    {
                        Id = "NFe12344321341234123412342134123412",

                        Ide = new Ide
                        {
                            DtEmi = DateTime.Now.ToString("dd/MM/yyyy"),
                            DtSaiEnt = DateTime.Now.ToString("dd/MM/yyyy"),
                            Mod = "55",
                            NatOp = "Venda de Mercadoria",
                            Serie = "1",
                            Uf = "SP",
                            TpNf = "1",
                            NumNf = "1234567",
                            IndPag = "1",
                            CodNf = "22222"
                        },

                        Emitente = new Emitente
                        {
                            Cnpj = "1111111111",
                            Nome = "EMPRESA TESTE",
                            EnderecoEmit = new EnderecoEmit
                            {
                                Bairro = "Jardim Teste",
                                Cep = "39284-021",
                                InscrEst = "1234566788",
                                Logradouro = "Rua teste",
                                Numero = "809",
                                Uf = "RJ"
                            },
                            Fantasia = "EMPRESA TESTE"
                        },
                        Destinatario = new Destinatario
                        {
                            Cnpj = "43422365342",
                            Nome = "ANDERSON DAVANSE",
                            EnderecoDest = new EnderecoDest
                            {
                                Bairro = "Bairro Teste",
                                Cep = "023943-322",
                                InscrEst = "23423422",
                                Numero = "21 3234-2344",
                                Uf = "BH",
                                Logradouro = "Rua dest"
                            }
                        },
                        Totais = new Totais
                        {
                            IcmsTot = new IcmsTot
                            {
                                VlBc = 100.10M,
                                VlBcSt = 100.10M,
                                VlCofins = 12.2M,
                                VlDesc = 0M,
                                VlFrete = 10M,
                                VlIcms = 24.43M,
                                VlProd = 10.3M

                            }
                        }

                    }
                }
            };

            return nfeProc;
        }
    }
}
