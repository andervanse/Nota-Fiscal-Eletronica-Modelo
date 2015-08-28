using System.Collections.Generic;
using System.Xml.Serialization;

namespace Fiscal.Nfe.Models
{
    [XmlRoot(ElementName = "nfeProc", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class NfeProc
    {
        [XmlAttribute(AttributeName = "versao")]
        public string Versao { get; set; }

        [XmlElement(ElementName = "NFe")]
        public NotaFiscalEletronica Nfe { get; set; }

        [XmlElement(ElementName = "protNFe")]
        public ProtNfe ProtNfe { get; set; }
    }

    [XmlRoot(ElementName = "NFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class NotaFiscalEletronica
    {
        [XmlElement(ElementName ="infNFe")]
        public InfNFe InfNfe { get; set; }
    }

    //A01
    public class InfNFe
    {
        [XmlAttribute(AttributeName = "versao")]
        public string Versao { get; set; }

        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }

        [XmlElement(ElementName = "ide")]
        public Ide Ide { get; set; }

        [XmlElement(ElementName = "emit")]
        public Emitente Emitente { get; set; }

        [XmlElement(ElementName = "dest")]
        public Destinatario Destinatario { get; set; }

        [XmlElement(ElementName = "retirada")]
        public LocalRetirada LocalRetirada { get; set; }

        [XmlElement(ElementName = "entrega")]
        public LocalEntrega LocalEntrega { get; set; }

        [XmlElement(ElementName = "det")]
        public List<ItemNf> Itens { get; set; }

        [XmlElement(ElementName = "total")]
        public Totais Totais { get; set; }

        [XmlElement(ElementName = "transp")]
        public Transportador Transportador { get; set; }

        [XmlElement(ElementName = "cobranca")]
        public Cobranca Cobranca { get; set; }

        [XmlElement(ElementName = "exporta")]
        public Exportacao Exportacao { get; set; }

        [XmlElement(ElementName = "infAdic")]
        public InfAdic InfAdic { get; set; }
    }

    public class InfAdic
    {
        [XmlElement(ElementName = "infAdFisco")]
        public string InfAdFisco { get; set; }

        [XmlElement(ElementName = "infCpl")]
        public string InfCpl { get; set; }
    }

    //B01
    public class Ide
    {
        [XmlElement(ElementName = "cUF")]
        public string Uf { get; set; }

        [XmlElement(ElementName = "cNF")]
        public string CodNf { get; set; }

        [XmlElement(ElementName = "natOp")]
        public string NatOp { get; set; }

        [XmlElement(ElementName = "indPag")]
        public string IndPag { get; set; }

        [XmlElement(ElementName = "mod")]
        public string Mod { get; set; }

        [XmlElement(ElementName = "serie")]
        public string Serie { get; set; }

        [XmlElement(ElementName = "nNF")]
        public string NumNf { get; set; }

        [XmlElement(ElementName = "dEmi")]
        public string DtEmi { get; set; }

        [XmlElement(ElementName = "dSaiEnt")]
        public string DtSaiEnt { get; set; }

        [XmlElement(ElementName = "hSaiEnt")]
        public string HrSaiEnt { get; set; }

        [XmlElement(ElementName = "tpNF")]
        public string TpNf { get; set; }

        [XmlElement(ElementName = "cMunFG")]
        public string CodMunFg { get; set; }

        [XmlElement(ElementName = "NFref")]
        public NFref NfRef { get; set; }

        [XmlElement(ElementName = "tpImp")]
        public string TpImp { get; set; }

        [XmlElement(ElementName = "tpEmis")]
        public string tpEmis { get; set; }

        [XmlElement(ElementName = "cDV")]
        public string cDv { get; set; }

        [XmlElement(ElementName = "tpAmb")]
        public string tpAmb { get; set; }

        [XmlElement(ElementName = "finNFe")]
        public string FinNfe { get; set; }

        [XmlElement(ElementName = "procEmi")]
        public string ProcEmi { get; set; }

        [XmlElement(ElementName = "verProc")]
        public string VerProc { get; set; }
    }

    //B12a
    public class NFref
    {
        [XmlElement(ElementName = "refNFe")]
        public string[] RefNfe { get; set; }
    }

    //C01
    public class Emitente
    {
        [XmlElement(ElementName = "CNPJ")]
        public string Cnpj { get; set; }

        [XmlElement(ElementName = "CPF")]
        public string Cpf { get; set; }

        [XmlElement(ElementName = "xNome")]
        public string Nome { get; set; }

        [XmlElement(ElementName = "xFant")]
        public string Fantasia { get; set; }

        [XmlElement(ElementName = "enderEmit")]
        public EnderecoEmit EnderecoEmit { get; set; }
    }

    //C05
    public class EnderecoEmit
    {
        [XmlElement(ElementName = "xLgr")]
        public string Logradouro { get; set; }

        [XmlElement(ElementName = "nro")]
        public string Numero { get; set; }

        [XmlElement(ElementName = "xCpl")]
        public string Complemento { get; set; }

        [XmlElement(ElementName = "xBairro")]
        public string Bairro { get; set; }

        [XmlElement(ElementName = "cMun")]
        public string CodMunicipio { get; set; }

        [XmlElement(ElementName = "xMun")]
        public string Municipio { get; set; }

        [XmlElement(ElementName = "UF")]
        public string Uf { get; set; }

        [XmlElement(ElementName = "CEP")]
        public string Cep { get; set; }

        [XmlElement(ElementName = "cPais")]
        public string CodPais { get; set; }

        [XmlElement(ElementName = "xPais")]
        public string Pais { get; set; }

        [XmlElement(ElementName = "fone")]
        public string Fone { get; set; }

        [XmlElement(ElementName = "IE")]
        public string InscrEst { get; set; }

        [XmlElement(ElementName = "IEST")]
        public string InscrEstSt { get; set; }

        [XmlElement(ElementName = "IM")]
        public string InscrMun { get; set; }

        [XmlElement(ElementName = "CNAE")]
        public string Cnae { get; set; }

        [XmlElement(ElementName = "CRT")]
        public string Crt { get; set; }        
    }

    //E01
    public class Destinatario
    {
        [XmlElement(ElementName = "CNPJ")]
        public string Cnpj { get; set; }

        [XmlElement(ElementName = "CPF")]
        public string Cpf { get; set; }

        [XmlElement(ElementName = "xNome")]
        public string Nome { get; set; }

        [XmlElement(ElementName = "enderDest")]
        public EnderecoDest EnderecoDest { get; set; }
    }

    //E05
    public class EnderecoDest
    {
        [XmlElement(ElementName = "xLgr")]
        public string Logradouro { get; set; }

        [XmlElement(ElementName = "nro")]
        public string Numero { get; set; }

        [XmlElement(ElementName = "xCpl")]
        public string Complemento { get; set; }

        [XmlElement(ElementName = "xBairro")]
        public string Bairro { get; set; }

        [XmlElement(ElementName = "cMun")]
        public string CodMunicipio { get; set; }

        [XmlElement(ElementName = "xMun")]
        public string Municipio { get; set; }

        [XmlElement(ElementName = "UF")]
        public string Uf { get; set; }

        [XmlElement(ElementName = "CEP")]
        public string Cep { get; set; }

        [XmlElement(ElementName = "cPais")]
        public string CodPais { get; set; }

        [XmlElement(ElementName = "xPais")]
        public string Pais { get; set; }

        [XmlElement(ElementName = "fone")]
        public string Fone { get; set; }

        [XmlElement(ElementName = "IE")]
        public string InscrEst { get; set; }

        [XmlElement(ElementName = "ISUF")]
        public string InscrSuframa { get; set; }

        [XmlElement(ElementName = "email")]
        public string Email { get; set; }
    }

    //F01
    public class LocalRetirada
    {
        [XmlElement(ElementName = "CNPJ")]
        public string Cnpj { get; set; }

        [XmlElement(ElementName = "CPF")]
        public string Cpf { get; set; }

        [XmlElement(ElementName = "xLgr")]
        public string Logradouro { get; set; }

        [XmlElement(ElementName = "nro")]
        public string Numero { get; set; }

        [XmlElement(ElementName = "xCpl")]
        public string Complemento { get; set; }

        [XmlElement(ElementName = "xBairro")]
        public string Bairro { get; set; }

        [XmlElement(ElementName = "cMun")]
        public string CodMun { get; set; }

        [XmlElement(ElementName = "xMun")]
        public string Municipio { get; set; }

        [XmlElement(ElementName = "UF")]
        public string Uf { get; set; }        
    }

    //G01
    public class LocalEntrega
    {
        [XmlElement(ElementName = "CNPJ")]
        public string Cnpj { get; set; }

        [XmlElement(ElementName = "CPF")]
        public string Cpf { get; set; }

        [XmlElement(ElementName = "xLgr")]
        public string Logradouro { get; set; }

        [XmlElement(ElementName = "nro")]
        public string Numero { get; set; }

        [XmlElement(ElementName = "xCpl")]
        public string Complemento { get; set; }

        [XmlElement(ElementName = "xBairro")]
        public string Bairro { get; set; }

        [XmlElement(ElementName = "cMun")]
        public string CodMun { get; set; }

        [XmlElement(ElementName = "xMun")]
        public string Municipio { get; set; }

        [XmlElement(ElementName = "UF")]
        public string Uf { get; set; }          
    }

    //H01
    public class ItemNf
    {
        [XmlElement(ElementName = "nItem")]
        public int NItem { get; set; }

        [XmlElement(ElementName = "prod")]
        public Produto Produto { get; set; }

        [XmlElement(ElementName = "imposto")]
        public Imposto Imposto { get; set; }

        [XmlElement(ElementName = "infAdProd")]
        public string InfAdProd { get; set; }
    }

    //I01
    public class Produto
    {
        [XmlElement(ElementName = "cProd")]
        public string CodProduto { get; set; }

        [XmlElement(ElementName = "cEAN")]
        public string Cean { get; set; }

        [XmlElement(ElementName = "xProd")]
        public string Descricao { get; set; }

        [XmlElement(ElementName = "NCM")]
        public string Ncm { get; set; }

        public string GetCst(Icms icms) 
        {
            string cst = "";

            if (icms.Icms00 != null)
                cst = icms.Icms00.Cst;
            else if (icms.Icms10 != null)
                cst = icms.Icms10.Cst;
            else if (icms.Icms10 != null)
                cst = icms.Icms10.Cst;
            else if (icms.Icms20 != null)
                cst = icms.Icms20.Cst;
            else if (icms.Icms30 != null)
                cst = icms.Icms30.Cst;
            else if (icms.Icms40 != null)
                cst = icms.Icms40.Cst;
            else if (icms.Icms51 != null)
                cst = icms.Icms51.Cst;
            else if (icms.Icms60 != null)
                cst = icms.Icms60.Cst;
            else if (icms.Icms70 != null)
                cst = icms.Icms70.Cst;
            else if (icms.Icms90 != null)
                cst = icms.Icms90.Cst;
            else if (icms.IcmsPart != null)
                cst = icms.IcmsPart.Cst;
            else if (icms.IcmsSn101 != null)
                cst = icms.IcmsSn101.CSOSn;
            else if (icms.IcmsSn102 != null)
                cst = icms.IcmsSn102.CSOSn;
            else if (icms.IcmsSn201 != null)
                cst = icms.IcmsSn201.CSOSn;
            else if (icms.IcmsSn202 != null)
                cst = icms.IcmsSn202.CSOSn;
            else if (icms.IcmsSn500 != null)
                cst = icms.IcmsSn500.CSOSn;
            else if (icms.IcmsSn900 != null)
                cst = icms.IcmsSn900.CSOSn;

            return cst;
        }

        public decimal GetBcIcms(Icms icms)
        {
            decimal value = 0;

            if (icms.Icms00 != null)
                value = icms.Icms00.VlBc;
            else if (icms.Icms10 != null)
                value = icms.Icms10.VlBc;
            else if (icms.Icms10 != null)
                value = icms.Icms10.VlBc;
            else if (icms.Icms20 != null)
                value = icms.Icms20.VlBc;
            else if (icms.Icms30 != null)
                value = 0;
            else if (icms.Icms40 != null)
                value = 0;
            else if (icms.Icms51 != null)
                value = icms.Icms51.VlBcIcms;
            else if (icms.Icms60 != null)
                value = 0;
            else if (icms.Icms70 != null)
                value = icms.Icms70.VlBcIcms;
            else if (icms.Icms90 != null)
                value = icms.Icms90.VlBcIcms;
            else if (icms.IcmsPart != null)
                value = icms.IcmsPart.VlBcIcms;
            else if (icms.IcmsSn101 != null)
                value = 0;
            else if (icms.IcmsSn102 != null)
                value = 0;
            else if (icms.IcmsSn201 != null)
                value = 0;
            else if (icms.IcmsSn202 != null)
                value = 0;
            else if (icms.IcmsSn500 != null)
                value = 0;
            else if (icms.IcmsSn900 != null)
                value = icms.IcmsSn900.VlBcIcms;

            return value;
        }

        public decimal GetVlIcms(Icms icms)
        {
            decimal value = 0;

            if (icms.Icms00 != null)
                value = icms.Icms00.VlIcms;
            else if (icms.Icms10 != null)
                value = icms.Icms10.VlIcms;
            else if (icms.Icms10 != null)
                value = icms.Icms10.VlIcms;
            else if (icms.Icms20 != null)
                value = icms.Icms20.VlIcms;
            else if (icms.Icms30 != null)
                value = 0;
            else if (icms.Icms40 != null)
                value = icms.Icms40.VlIcms;
            else if (icms.Icms51 != null)
                value = icms.Icms51.VlIcms;
            else if (icms.Icms60 != null)
                value = 0;
            else if (icms.Icms70 != null)
                value = icms.Icms70.VlIcms;
            else if (icms.Icms90 != null)
                value = icms.Icms90.VlIcms;
            else if (icms.IcmsPart != null)
                value = icms.IcmsPart.VlIcms;
            else if (icms.IcmsSn101 != null)
                value = 0;
            else if (icms.IcmsSn102 != null)
                value = 0;
            else if (icms.IcmsSn201 != null)
                value = 0;
            else if (icms.IcmsSn202 != null)
                value = 0;
            else if (icms.IcmsSn500 != null)
                value = 0;
            else if (icms.IcmsSn900 != null)
                value = icms.IcmsSn900.VlIcms;

            return value;
        }

        public decimal GetAliqIcms(Icms icms)
        {
            decimal value = 0;

            if (icms.Icms00 != null)
                value = icms.Icms00.AliqImposto;
            else if (icms.Icms10 != null)
                value = icms.Icms10.AliqImposto;
            else if (icms.Icms10 != null)
                value = icms.Icms10.AliqImposto;
            else if (icms.Icms20 != null)
                value = icms.Icms20.AliqImposto;
            else if (icms.Icms30 != null)
                value = 0;
            else if (icms.Icms40 != null)
                value = 0;
            else if (icms.Icms51 != null)
                value = icms.Icms51.AliqotaIcms;
            else if (icms.Icms60 != null)
                value = 0;
            else if (icms.Icms70 != null)
                value = icms.Icms70.AliquotaIcms;
            else if (icms.Icms90 != null)
                value = icms.Icms90.AliquotaIcms;
            else if (icms.IcmsPart != null)
                value = icms.IcmsPart.AliquotaIcms;
            else if (icms.IcmsSn101 != null)
                value = 0;
            else if (icms.IcmsSn102 != null)
                value = 0;
            else if (icms.IcmsSn201 != null)
                value = 0;
            else if (icms.IcmsSn202 != null)
                value = 0;
            else if (icms.IcmsSn500 != null)
                value = 0;
            else if (icms.IcmsSn900 != null)
                value = icms.IcmsSn900.AliquotaIcms;

            return value;
        }

        public decimal GetVlIpi(Ipi ipi)
        {
            decimal value = 0;

            if (ipi != null && ipi.IpiTrib != null)
                value = ipi.IpiTrib.VlImposto;

            return value;
        }

        public decimal GetAliqIpi(Ipi ipi)
        {
            decimal value = 0;

            if (ipi != null && ipi.IpiTrib != null)
                value = ipi.IpiTrib.Aliquota;

            return value;
        }

        [XmlElement(ElementName = "EXTIPI")]
        public string ExTipi { get; set; }

        [XmlElement(ElementName = "CFOP")]
        public string Cfop { get; set; }

        [XmlElement(ElementName = "uCom")]
        public string UnidCom { get; set; }

        [XmlElement(ElementName = "qCom")]
        public decimal QtdeCom { get; set; }

        [XmlElement(ElementName = "vUnCom")]
        public decimal VlUnitCom { get; set; }

        [XmlElement(ElementName = "vProd")]
        public decimal VlTotalProd { get; set; }

        [XmlElement(ElementName = "cEANTrib")]
        public string CeanTrib { get; set; }

        [XmlElement(ElementName = "uTrib")]
        public string UnidTrib { get; set; }

        [XmlElement(ElementName = "qTrib")]
        public decimal? QtdeTrib { get; set; }

        [XmlElement(ElementName = "vUnTrib")]
        public decimal? VlUnitTrib { get; set; }

        [XmlElement(ElementName = "vFrete")]
        public decimal VlFrete { get; set; }

        [XmlElement(ElementName = "vSeg")]
        public decimal VlSeguro { get; set; }

        [XmlElement(ElementName = "vDesc")]
        public decimal VlDesconto { get; set; }

        [XmlElement(ElementName = "vOutro")]
        public decimal? VlOutro { get; set; }

        [XmlElement(ElementName = "indTot")]
        public string IndTot { get; set; }

        [XmlElement(ElementName = "DI")]
        public DeclaracaoImportacao DeclaracaoImportacao { get; set; }
    }

    //I18
    public class DeclaracaoImportacao
    {
        [XmlElement(ElementName = "nDI")]
        public string Numero { get; set; }

        [XmlElement(ElementName = "dDI")]
        public string Data { get; set; }

        [XmlElement(ElementName = "xLocDesemb")]
        public string LocalDesembarque { get; set; }

        [XmlElement(ElementName = "UFDesemb")]
        public string UfDesembarque { get; set; }

        [XmlElement(ElementName = "dDesemb")]
        public string DataDesembarque { get; set; }

        [XmlElement(ElementName = "cExportador")]
        public string CodExportador { get; set; }

        [XmlElement(ElementName = "adi")]
        public Adicoes[] Adicoes { get; set; }
    }

    //I25
    public class Adicoes
    {
        [XmlElement(ElementName = "nAdicao")]
        public string Numero { get; set; }

        [XmlElement(ElementName = "nSeqAdic")]
        public string NumSeq { get; set; }

        [XmlElement(ElementName = "cFabricante")]
        public string CodFab { get; set; }

        [XmlElement(ElementName = "vDescDI")]
        public decimal VlDescItem { get; set; }

        [XmlElement(ElementName = "xPed")]
        public string NumPedido { get; set; }

        [XmlElement(ElementName = "nItemPed")]
        public int NumItemPedido { get; set; }
    }

    //M01
    public class Imposto
    {
        [XmlElement(ElementName = "ICMS")]
        public Icms Icms { get; set; }

        [XmlElement(ElementName = "IPI")]
        public Ipi Ipi { get; set; }

        [XmlElement(ElementName = "II")]
        public ImpostoImportacao ImpostoImp { get; set; }

        [XmlElement(ElementName = "ISSQN")]
        public Issqn Issqn { get; set; }

        [XmlElement(ElementName = "PIS")]
        public Pis Pis { get; set; }

        [XmlElement(ElementName = "PISST")]
        public PisSt PisSt { get; set; }

        [XmlElement(ElementName = "COFINS")]
        public Cofins Cofins { get; set; }

        [XmlElement(ElementName = "COFINSST")]
        public CofinsSt CofinsSt { get; set; }
    }

    //N01
    public class Icms
    {

        [XmlElement(ElementName = "ICMS00")]
        public Icms00 Icms00 { get; set; }

        [XmlElement(ElementName = "ICMS10")]
        public Icms10 Icms10 { get; set; }

        [XmlElement(ElementName = "ICMS20")]
        public Icms20 Icms20 { get; set; }

        [XmlElement(ElementName = "ICMS30")]
        public Icms30 Icms30 { get; set; }

        [XmlElement(ElementName = "ICMS40")]
        public Icms40 Icms40 { get; set; }

        [XmlElement(ElementName = "ICMS51")]
        public Icms51 Icms51 { get; set; }

        [XmlElement(ElementName = "ICMS60")]
        public Icms60 Icms60 { get; set; }

        [XmlElement(ElementName = "ICMS70")]
        public Icms70 Icms70 { get; set; }

        [XmlElement(ElementName = "ICMS90")]
        public Icms90 Icms90 { get; set; }

        [XmlElement(ElementName = "ICMSPart")]
        public IcmsPart IcmsPart { get; set; }

        [XmlElement(ElementName = "ICMSST")]
        public IcmsSt IcmsSt { get; set; }

        [XmlElement(ElementName = "ICMSSN101")]
        public IcmsSn101 IcmsSn101 { get; set; }

        [XmlElement(ElementName = "ICMSSN102")]
        public IcmsSn102 IcmsSn102 { get; set; }

        [XmlElement(ElementName = "ICMSSN201")]
        public IcmsSn201 IcmsSn201 { get; set; }

        [XmlElement(ElementName = "ICMSSN202")]
        public IcmsSn202 IcmsSn202 { get; set; }

        [XmlElement(ElementName = "ICMSSN500")]
        public IcmsSn500 IcmsSn500 { get; set; }

        [XmlElement(ElementName = "ICMSSN900")]
        public IcmsSn900 IcmsSn900 { get; set; }
    }

    #region ICMS Normal e ST

    //N02
    public class Icms00
    {
        [XmlElement(ElementName = "orig")]
        public int OrigemMerc { get; set; }

        [XmlElement(ElementName = "CST")]
        public string Cst { get; set; }

        [XmlElement(ElementName = "modBC")]
        public int ModBc { get; set; }

        [XmlElement(ElementName = "vBC")]
        public decimal VlBc { get; set; }

        [XmlElement(ElementName = "pICMS")]
        public decimal AliqImposto { get; set; }

        [XmlElement(ElementName = "vICMS")]
        public decimal VlIcms { get; set; }
    }

    //N03
    public class Icms10
    {
        [XmlElement(ElementName = "orig")]
        public int OrigemMerc { get; set; }

        [XmlElement(ElementName = "CST")]
        public string Cst { get; set; }

        [XmlElement(ElementName = "modBC")]
        public int ModBc { get; set; }

        [XmlElement(ElementName = "vBC")]
        public decimal VlBc { get; set; }

        [XmlElement(ElementName = "pICMS")]
        public decimal AliqImposto { get; set; }

        [XmlElement(ElementName = "vICMS")]
        public decimal VlIcms { get; set; }

        [XmlElement(ElementName = "modBCST")]
        public int ModBcSt { get; set; }

        [XmlElement(ElementName = "pMVAST")]
        public decimal PercMvaSt { get; set; }

        [XmlElement(ElementName = "pRedBCST")]
        public decimal PercRedBcSt { get; set; }

        [XmlElement(ElementName = "vBCST")]
        public decimal VlBcSt { get; set; }

        [XmlElement(ElementName = "pICMSST")]
        public decimal AliqIcmsSt { get; set; }

        [XmlElement(ElementName = "vICMSST")]
        public decimal VlIcmsSt { get; set; }
    }

    public class Icms20
    {
        [XmlElement(ElementName = "orig")]
        public int OrigemMerc { get; set; }

        [XmlElement(ElementName = "CST")]
        public string Cst { get; set; }

        [XmlElement(ElementName = "modBC")]
        public int ModBc { get; set; }

        [XmlElement(ElementName = "pRedBC")]
        public decimal PercRedBc { get; set; }

        [XmlElement(ElementName = "vBC")]
        public decimal VlBc { get; set; }

        [XmlElement(ElementName = "pICMS")]
        public decimal AliqImposto { get; set; }

        [XmlElement(ElementName = "vICMS")]
        public decimal VlIcms { get; set; }
    }

    public class Icms30
    {
        [XmlElement(ElementName = "orig")]
        public int OrigemMerc { get; set; }

        [XmlElement(ElementName = "CST")]
        public string Cst { get; set; }

        [XmlElement(ElementName = "modBCST")]
        public int ModBcSt { get; set; }

        [XmlElement(ElementName = "pMVAST")]
        public decimal PercMvaSt { get; set; }

        [XmlElement(ElementName = "pRedBCST")]
        public decimal PercRedBcSt { get; set; }

        [XmlElement(ElementName = "vBCST")]
        public decimal VlBcSt { get; set; }

        [XmlElement(ElementName = "pICMSST")]
        public decimal AliqIcmsSt { get; set; }

        [XmlElement(ElementName = "vICMSST")]
        public decimal VlIcmsSt { get; set; }
    }

    public class Icms40
    {
        [XmlElement(ElementName = "orig")]
        public int OrigemMerc { get; set; }

        [XmlElement(ElementName = "CST")]
        public string Cst { get; set; }

        [XmlElement(ElementName = "vICMS")]
        public decimal VlIcms { get; set; }

        [XmlElement(ElementName = "motDesICMS")]
        public int MotDesIcms { get; set; }
    }

    public class Icms51
    {
        [XmlElement(ElementName = "orig")]
        public int OrigemMerc { get; set; }

        [XmlElement(ElementName = "CST")]
        public string Cst { get; set; }

        [XmlElement(ElementName = "modBC")]
        public int ModBc { get; set; }

        [XmlElement(ElementName = "pRedBC")]
        public decimal PercRedBc { get; set; }

        [XmlElement(ElementName = "vBC")]
        public decimal VlBcIcms { get; set; }

        [XmlElement(ElementName = "pICMS")]
        public decimal AliqotaIcms { get; set; }

        [XmlElement(ElementName = "vICMS")]
        public decimal VlIcms { get; set; }
    }

    //N08
    public class Icms60
    {
        [XmlElement(ElementName = "orig")]
        public int OrigemMerc { get; set; }

        [XmlElement(ElementName = "CST")]
        public string Cst { get; set; }

        [XmlElement(ElementName = "vBCSTRet")]
        public decimal VlBcIcmsStRet { get; set; }

        [XmlElement(ElementName = "vICMSSTRet")]
        public decimal VlIcmsStRet { get; set; }
    }

    //N09
    public class Icms70
    {
        [XmlElement(ElementName = "orig")]
        public int OrigemMerc { get; set; }

        [XmlElement(ElementName = "CST")]
        public string Cst { get; set; }

        [XmlElement(ElementName = "modBC")]
        public int ModBc { get; set; }

        [XmlElement(ElementName = "pRedBC")]
        public decimal PercRedBc { get; set; }

        [XmlElement(ElementName = "vBC")]
        public decimal VlBcIcms { get; set; }

        [XmlElement(ElementName = "pICMS")]
        public decimal AliquotaIcms { get; set; }

        [XmlElement(ElementName = "vICMS")]
        public decimal VlIcms { get; set; }

        [XmlElement(ElementName = "modBCST")]
        public int ModBcSt { get; set; }

        [XmlElement(ElementName = "pMVAST")]
        public decimal PercMvaSt { get; set; }

        [XmlElement(ElementName = "pRedBCST")]
        public decimal PercRedBcSt { get; set; }

        [XmlElement(ElementName = "vBCST")]
        public decimal VlBcIcmsSt { get; set; }

        [XmlElement(ElementName = "pICMSST")]
        public decimal AliqIcmsSt { get; set; }

        [XmlElement(ElementName = "vICMSST")]
        public decimal VlIcmsSt { get; set; }
    }

    //N10
    public class Icms90
    {
        [XmlElement(ElementName = "orig")]
        public int OrigemMerc { get; set; }

        [XmlElement(ElementName = "CST")]
        public string Cst { get; set; }

        [XmlElement(ElementName = "modBC")]
        public int ModBc { get; set; }

        [XmlElement(ElementName = "vBC")]
        public decimal VlBcIcms { get; set; }

        [XmlElement(ElementName = "pRedBC")]
        public decimal PercRedBc { get; set; }

        [XmlElement(ElementName = "pICMS")]
        public decimal AliquotaIcms { get; set; }

        [XmlElement(ElementName = "vICMS")]
        public decimal VlIcms { get; set; }

        [XmlElement(ElementName = "modBCST")]
        public int ModBcSt { get; set; }

        [XmlElement(ElementName = "pMVAST")]
        public decimal PercMvaSt { get; set; }

        [XmlElement(ElementName = "pRedBCST")]
        public decimal PercRedBcSt { get; set; }

        [XmlElement(ElementName = "vBCST")]
        public decimal VlBcIcmsSt { get; set; }

        [XmlElement(ElementName = "pICMSST")]
        public decimal AliquotaIcmsSt { get; set; }

        [XmlElement(ElementName = "vICMSST")]
        public decimal VlIcmsSt { get; set; }
    }

    //N10a
    public class IcmsPart
    {

        [XmlElement(ElementName = "orig")]
        public int OrigemMerc { get; set; }

        [XmlElement(ElementName = "CST")]
        public string Cst { get; set; }

        [XmlElement(ElementName = "modBC")]
        public int ModBc { get; set; }

        [XmlElement(ElementName = "vBC")]
        public decimal VlBcIcms { get; set; }

        [XmlElement(ElementName = "pRedBC")]
        public decimal PercRedBc { get; set; }

        [XmlElement(ElementName = "pICMS")]
        public decimal AliquotaIcms { get; set; }

        [XmlElement(ElementName = "vICMS")]
        public decimal VlIcms { get; set; }

        [XmlElement(ElementName = "modBCST")]
        public int ModBcSt { get; set; }

        [XmlElement(ElementName = "pMVAST")]
        public decimal PercMvaSt { get; set; }

        [XmlElement(ElementName = "pRedBCST")]
        public decimal PercRedBcSt { get; set; }

        [XmlElement(ElementName = "vBCST")]
        public decimal VlBcIcmsSt { get; set; }

        [XmlElement(ElementName = "pICMSST")]
        public decimal AliquotaIcmsSt { get; set; }

        [XmlElement(ElementName = "vICMSST")]
        public decimal VlIcmsSt { get; set; }

        [XmlElement(ElementName = "pBCOp")]
        public decimal PercBcOp { get; set; }

        [XmlElement(ElementName = "UFST")]
        public string UfSt { get; set; }
    }

    //N10b
    public class IcmsSt
    {
        [XmlElement(ElementName = "orig")]
        public int OrigemMerc { get; set; }

        [XmlElement(ElementName = "CST")]
        public string Cst { get; set; }

        [XmlElement(ElementName = "vBCSTRet")]
        public decimal VlBcIcmsSt { get; set; }

        [XmlElement(ElementName = "vICMSSTRet")]
        public decimal VlIcmsStRet { get; set; }

        [XmlElement(ElementName = "vBCSTDest")]
        public decimal VlBcIcmsStDest { get; set; }

        [XmlElement(ElementName = "vICMSSTDest")]
        public decimal VlIcmsStDest { get; set; }
    }

    //N10c
    public class IcmsSn101
    {
        [XmlElement(ElementName = "Orig")]
        public int OrigemMerc { get; set; }

        [XmlElement(ElementName = "CSOSN")]
        public string CSOSn { get; set; }

        [XmlElement(ElementName = "pCredSN")]
        public decimal PercCredSn { get; set; }

        [XmlElement(ElementName = "vCredICMSSN")]
        public decimal VlCredIcmsSn { get; set; }
    }

    //N10d
    public class IcmsSn102
    {
        [XmlElement(ElementName = "Orig")]
        public int OrigemMerc { get; set; }

        [XmlElement(ElementName = "CSOSN")]
        public string CSOSn { get; set; }
    }

    //N10e
    public class IcmsSn201
    {
        [XmlElement(ElementName = "Orig")]
        public int OrigemMerc { get; set; }

        [XmlElement(ElementName = "CSOSN")]
        public string CSOSn { get; set; }

        [XmlElement(ElementName = "modBCST")]
        public int ModBcSt { get; set; }

        [XmlElement(ElementName = "pMVAST")]
        public decimal PercMvaSt { get; set; }

        [XmlElement(ElementName = "pRedBCST")]
        public decimal PercRedBcSt { get; set; }

        [XmlElement(ElementName = "vBCST")]
        public decimal VlBcIcmsSt { get; set; }

        [XmlElement(ElementName = "pICMSST")]
        public decimal AliquotaIcmsSt { get; set; }

        [XmlElement(ElementName = "vICMSST")]
        public decimal VlIcmsSt { get; set; }

        [XmlElement(ElementName = "pCredSN")]
        public decimal PercCredSn { get; set; }

        [XmlElement(ElementName = "vCredICMSSN")]
        public decimal VlCredIcmsSn { get; set; }
    }

    //N10f
    public class IcmsSn202
    {
        [XmlElement(ElementName = "Orig")]
        public int OrigemMerc { get; set; }

        [XmlElement(ElementName = "CSOSN")]
        public string CSOSn { get; set; }

        [XmlElement(ElementName = "modBCST")]
        public int ModBcSt { get; set; }

        [XmlElement(ElementName = "pMVAST")]
        public decimal PercMvaSt { get; set; }

        [XmlElement(ElementName = "pRedBCST")]
        public decimal PercRedBcSt { get; set; }

        [XmlElement(ElementName = "vBCST")]
        public decimal VlBcIcmsSt { get; set; }

        [XmlElement(ElementName = "pICMSST")]
        public decimal AliquotaIcmsSt { get; set; }

        [XmlElement(ElementName = "vICMSST")]
        public decimal VlIcmsSt { get; set; }
    }
    
    //N10g
    public class IcmsSn500
    {
        [XmlElement(ElementName = "Orig")]
        public int OrigemMerc { get; set; }

        [XmlElement(ElementName = "CSOSN")]
        public string CSOSn { get; set; }

        [XmlElement(ElementName = "vBCSTRet")]
        public decimal VlBcIcmsStRet { get; set; }

        [XmlElement(ElementName = "vICMSSTRet")]
        public decimal VlIcmsStRet { get; set; }
    }

    //N10h
    public class IcmsSn900
    {
        [XmlElement(ElementName = "Orig")]
        public int OrigemMerc { get; set; }

        [XmlElement(ElementName = "CSOSN")]
        public string CSOSn { get; set; }

        [XmlElement(ElementName = "modBC")]
        public int ModBc { get; set; }

        [XmlElement(ElementName = "vBC")]
        public decimal VlBcIcms { get; set; }

        [XmlElement(ElementName = "pRedBC")]
        public decimal PercRedBc { get; set; }

        [XmlElement(ElementName = "pICMS")]
        public decimal AliquotaIcms { get; set; }

        [XmlElement(ElementName = "vICMS")]
        public decimal VlIcms { get; set; }

        [XmlElement(ElementName = "modBCST")]
        public int ModBcSt  { get; set; }

        [XmlElement(ElementName = "pMVAST")]
        public decimal PercMvaSt { get; set; }

        [XmlElement(ElementName = "pRedBCST")]
        public decimal PercRedBcSt { get; set; }

        [XmlElement(ElementName = "vBCST")]
        public decimal VlBcIcmsSt { get; set; }

        [XmlElement(ElementName = "pICMSST")]
        public decimal AliquotaIcmsSt { get; set; }

        [XmlElement(ElementName = "vICMSST")]
        public decimal VlIcmsSt { get; set; }

        [XmlElement(ElementName = "vBCSTRet")]
        public decimal VlBcIcmsStRet { get; set; }

        [XmlElement(ElementName = "vICMSSTRet")]
        public decimal VlIcmsStRet { get; set; }

        [XmlElement(ElementName = "pCredSN")]
        public decimal PercCredSn { get; set; }

        [XmlElement(ElementName = "vCredICMSSN")]
        public decimal VlCredIcmsSn { get; set; }
    }

    #endregion 

    //O01
    public class Ipi
    {
        [XmlElement(ElementName = "clEnq")]
        public string ClasseEnq { get; set; }

        [XmlElement(ElementName = "CNPJProd")]
        public string CnpjProdutor { get; set; }

        [XmlElement(ElementName = "cSelo")]
        public string CodSelo { get; set; }

        [XmlElement(ElementName = "qSelo")]
        public decimal QtdeSelo { get; set; }

        [XmlElement(ElementName = "cEnq")]
        public string CodEnq { get; set; }

        [XmlElement(ElementName = "IPITrib")]
        public IpiTrib IpiTrib { get; set; }

        [XmlElement(ElementName = "IPINT")]
        public IpiNt IpiNt { get; set; }
    }

    //O07
    public class IpiTrib
    {
        [XmlElement(ElementName = "CST")]
        public string Cst { get; set; }

        [XmlElement(ElementName = "vBC")]
        public decimal VlBc { get; set; }

        [XmlElement(ElementName = "qUnid")]
        public decimal QtdeUnit { get; set; }

        [XmlElement(ElementName = "vUnid")]
        public decimal VlUnid { get; set; }

        [XmlElement(ElementName = "pIPI")]
        public decimal Aliquota { get; set; }

        [XmlElement(ElementName = "vIPI")]
        public decimal VlImposto { get; set; }
    }

    //O08
    public class IpiNt
    {
        [XmlElement(ElementName = "CST")]
        public string Cst { get; set; }
    }

    //P01
    public class ImpostoImportacao
    {
        [XmlElement(ElementName = "vBC")]
        public decimal VlBc { get; set; }

        [XmlElement(ElementName = "vDespAdu")]
        public decimal VlDespAdu { get; set; }

        [XmlElement(ElementName = "vII")]
        public decimal VlImposto { get; set; }

        [XmlElement(ElementName = "vIOF")]
        public decimal VlIof { get; set; }
    }

    //Q01
    public class Pis
    {
        [XmlElement(ElementName = "PISAliq")]
        public PisAliq PisAliq { get; set; }

        [XmlElement(ElementName = "PISQtde")]
        public PisQtde PisQtde { get; set; }

        [XmlElement(ElementName = "PISNT")]
        public PisNt PisNt { get; set; }

        [XmlElement(ElementName = "PISOutr")]
        public PisOutrasOper PisOutrasOperacoes { get; set; }

        [XmlElement(ElementName = "PISST")]
        public PisSt PisSt { get; set; }
    }

    //Q02
    public class PisAliq
    {
        [XmlElement(ElementName = "CST")]
        public string Cst { get; set; }

        [XmlElement(ElementName = "vBC")]
        public decimal VlBc { get; set; }

        [XmlElement(ElementName = "pPIS")]
        public decimal Aliquota { get; set; }

        [XmlElement(ElementName = "vPIS")]
        public decimal Valor { get; set; }
    }

    //Q03
    public class PisQtde
    {
        [XmlElement(ElementName = "CST")]
        public string Cst { get; set; }

        [XmlElement(ElementName = "qBCProd")]
        public decimal QtdeBcProd { get; set; }

        [XmlElement(ElementName = "vAliqProd")]
        public decimal VlAliqProd { get; set; }

        [XmlElement(ElementName = "vPIS")]
        public decimal Valor { get; set; }
    }

    //Q04
    public class PisNt
    {
        [XmlElement(ElementName = "CST")]
        public string Cst { get; set; }
    }

    //Q05
    public class PisOutrasOper
    {
        [XmlElement(ElementName = "CST")]
        public string Cst { get; set; }

        [XmlElement(ElementName = "vBC")]
        public decimal VlBc { get; set; }

        [XmlElement(ElementName = "pPIS")]
        public decimal Aliquota { get; set; }

        [XmlElement(ElementName = "qBCProd")]
        public decimal QtdeBcProd { get; set; }

        [XmlElement(ElementName = "vAliqProd")]
        public decimal VlAliqProd { get; set; }

        [XmlElement(ElementName = "vPIS")]
        public decimal VlImposto { get; set; }
    }

    //R01
    public class PisSt
    {
        [XmlElement(ElementName = "vBC")]
        public decimal VlBc { get; set; }

        [XmlElement(ElementName = "pPIS")]
        public decimal Aliquota { get; set; }

        [XmlElement(ElementName = "qBCProd")]
        public decimal QtdeBcProd { get; set; }

        [XmlElement(ElementName = "vAliqProd")]
        public decimal VlAliqProd { get; set; }

        [XmlElement(ElementName = "vPIS")]
        public decimal VlImposto { get; set; }
    }

    //S01
    public class Cofins
    {
        [XmlElement(ElementName = "COFINSAliq")]
        public CofinsAliq CofinsAliq { get; set; }

        [XmlElement(ElementName = "COFINSQtde")]
        public CofinsQtde CofinsQtde { get; set; }

        [XmlElement(ElementName = "COFINSNT")]
        public CofinsNt CofinsNt { get; set; }

        [XmlElement(ElementName = "COFINSOutr")]
        public CofinsOutrasOper CofinsOutrasOperacoes { get; set; }

        [XmlElement(ElementName = "COFINSST")]
        public CofinsSt CofinsSt { get; set; }
    }

    //S02
    public class CofinsAliq
    {
        [XmlElement(ElementName = "CST")]
        public string Cst { get; set; }

        [XmlElement(ElementName = "vBC")]
        public decimal VlBc { get; set; }

        [XmlElement(ElementName = "pCOFINS")]
        public decimal Aliquota { get; set; }

        [XmlElement(ElementName = "vCOFINS")]
        public decimal Valor { get; set; }
    }

    //S03
    public class CofinsQtde
    {
        [XmlElement(ElementName = "CST")]
        public string Cst { get; set; }

        [XmlElement(ElementName = "qBCProd")]
        public decimal QtdeBcProd { get; set; }

        [XmlElement(ElementName = "vAliqProd")]
        public decimal VlAliqProd { get; set; }

        [XmlElement(ElementName = "vCOFINS")]
        public decimal Valor { get; set; }
    }

    //S04
    public class CofinsNt
    {
        [XmlElement(ElementName = "CST")]
        public string Cst { get; set; }
    }

    //S05
    public class CofinsOutrasOper
    {
        [XmlElement(ElementName = "CST")]
        public string Cst { get; set; }

        [XmlElement(ElementName = "vBC")]
        public decimal VlBc { get; set; }

        [XmlElement(ElementName = "pCOFINS")]
        public decimal Aliquota { get; set; }

        [XmlElement(ElementName = "qBCProd")]
        public decimal QtdeBcProd { get; set; }

        [XmlElement(ElementName = "vAliqProd")]
        public decimal VlAliqProd { get; set; }

        [XmlElement(ElementName = "vCOFINS")]
        public decimal Valor { get; set; }
    }

    //T01
    public class CofinsSt
    {
        [XmlElement(ElementName = "vBC")]
        public decimal VlBc { get; set; }

        [XmlElement(ElementName = "pCOFINS")]
        public decimal Aliquota { get; set; }

        [XmlElement(ElementName = "qBCProd")]
        public decimal QtdeBcProd { get; set; }

        [XmlElement(ElementName = "vAliqProd")]
        public decimal VlAliqProd { get; set; }

        [XmlElement(ElementName = "vCOFINS")]
        public decimal Valor { get; set; }
    }

    //ISSQN
    public class Issqn
    {
        [XmlElement(ElementName = "vBC")]
        public decimal VlBc { get; set; }

        [XmlElement(ElementName = "vAliq")]
        public decimal Aliquota { get; set; }

        [XmlElement(ElementName = "vISSQN")]
        public decimal Valor { get; set; }

        [XmlElement(ElementName = "cMunFG")]
        public string  CodMunFg { get; set; }

        [XmlElement(ElementName = "cListServ")]
        public string ListServ { get; set; }

        [XmlElement(ElementName = "cSitTrib")]
        public string CodSitTrib { get; set; }
    }

    //W01
    public class Totais
    {
        [XmlElement(ElementName = "ICMSTot")]
        public IcmsTot IcmsTot { get; set; }

        [XmlElement(ElementName = "ISSQNtot")]
        public IssqnTot IssqnTot { get; set; }
    }

    //W02
    public class IcmsTot
    {

        [XmlElement(ElementName = "vBC")]
        public decimal VlBc { get; set; }

        [XmlElement(ElementName = "vICMS")]
        public decimal VlIcms { get; set; }

        [XmlElement(ElementName = "vBCST")]
        public decimal VlBcSt { get; set; }

        [XmlElement(ElementName = "vST")]
        public decimal VlIcmsSt { get; set; }

        [XmlElement(ElementName = "vProd")]
        public decimal VlProd { get; set; }

        [XmlElement(ElementName = "vFrete")]
        public decimal VlFrete { get; set; }

        [XmlElement(ElementName = "vSeg")]
        public decimal VlSeg { get; set; }

        [XmlElement(ElementName = "vDesc")]
        public decimal VlDesc { get; set; }

        [XmlElement(ElementName = "vII")]
        public decimal VlII { get; set; }

        [XmlElement(ElementName = "vIPI")]
        public decimal VlIpi { get; set; }

        [XmlElement(ElementName = "vPIS")]
        public decimal VlPis { get; set; }

        [XmlElement(ElementName = "vCOFINS")]
        public decimal VlCofins { get; set; }

        [XmlElement(ElementName = "vOutro")]
        public decimal VlOutros { get; set; }

        [XmlElement(ElementName = "vNF")]
        public decimal VlNf { get; set; }
    }

    //W17
    public class IssqnTot
    {
        [XmlElement(ElementName = "vServ")]
        public decimal VlServ { get; set; }

        [XmlElement(ElementName = "vBC")]
        public decimal VlBc { get; set; }

        [XmlElement(ElementName = "vISS")]
        public decimal VlIss { get; set; }

        [XmlElement(ElementName = "vPIS")]
        public decimal VlPis { get; set; }

        [XmlElement(ElementName = "vCOFINS")]
        public decimal VlCofins { get; set; }
    }

    //W23
    public class RetTrib
    {
        [XmlElement(ElementName = "vRetPIS")]
        public decimal VlRetPis { get; set; }

        [XmlElement(ElementName = "vRetCOFINS")]
        public decimal VlRecCofins { get; set; }

        [XmlElement(ElementName = "vRetCSLL")]
        public decimal VlRetCsll { get; set; }

        [XmlElement(ElementName = "vBCIRRF")]
        public decimal VlBcIrrf { get; set; }

        [XmlElement(ElementName = "vIRRF")]
        public decimal VlIrrf { get; set; }

        [XmlElement(ElementName = "vBCRetPrev")]
        public decimal VlBcRetPrev { get; set; }

        [XmlElement(ElementName = "vRetPrev")]
        public decimal VlRetPrev { get; set; }
    }

    //X01
    public class Transportador
    {        
        [XmlElement(ElementName = "modFrete")]
        public string ModFrete { get; set; }

        [XmlElement(ElementName = "CNPJ")]
        public string Cnpj { get; set; }

        [XmlElement(ElementName = "CPF")]
        public string Cpf { get; set; }

        [XmlElement(ElementName = "xNome")]
        public string Nome { get; set; }

        [XmlElement(ElementName = "IE")]
        public string InscrEst { get; set; }

        [XmlElement(ElementName = "xEnder")]
        public string Endereco { get; set; }

        [XmlElement(ElementName = "xMun")]
        public string Municipio { get; set; }

        [XmlElement(ElementName = "UF")]
        public string Uf { get; set; }

        [XmlElement(ElementName = "veicTransp")]
        public VeiculoTransp VeiculoTransp { get; set; }

        [XmlElement(ElementName = "vol")]
        public Volume[] Volumes { get; set; }
    }

    //X11
    public class RetTransporte
    {
        [XmlElement(ElementName = "vServ")]
        public decimal VlServ { get; set; }

        [XmlElement(ElementName = "vBCRet")]
        public decimal VlBcRet { get; set; }

        [XmlElement(ElementName = "pICMSRet")]
        public decimal PercIcmsRet { get; set; }

        [XmlElement(ElementName = "vICMSRet")]
        public decimal VlIcmsRet { get; set; }

        [XmlElement(ElementName = "CFOP")]
        public string Cfop { get; set; }

        [XmlElement(ElementName = "cMunFG")]
        public string CodMun { get; set; }
    }

    //X18
    public class VeiculoTransp
    {
        [XmlElement(ElementName = "placa")]
        public string Placa { get; set; }

        [XmlElement(ElementName = "UF")]
        public string Uf { get; set; }

        [XmlElement(ElementName = "RNTC")]
        public string Rntc { get; set; }
    }

    //X22
    public class Reboque
    {
        [XmlElement(ElementName = "placa")]
        public string Placa { get; set; }

        [XmlElement(ElementName = "UF")]
        public string Uf { get; set; }

        [XmlElement(ElementName = "RNTC")]
        public string Rntc { get; set; }

        [XmlElement(ElementName = "vagao")]
        public string Vagao { get; set; }

        [XmlElement(ElementName = "balsa")]
        public string Balsa { get; set; }
    }

    //X26
    public class Volume
    {
        [XmlElement(ElementName = "qVol")]
        public decimal QtdeVol { get; set; }

        [XmlElement(ElementName = "esp")]
        public string Especie { get; set; }

        [XmlElement(ElementName = "marca")]
        public string Marca { get; set; }

        [XmlElement(ElementName = "nVol")]
        public string Numeracao { get; set; }

        [XmlElement(ElementName = "pesoL")]
        public decimal PesoLiq { get; set; }

        [XmlElement(ElementName = "pesoB")]
        public decimal PesoBruto { get; set; }

        [XmlElement(ElementName = "nLacre")]
        public string[] Lacres { get; set; }
    }

    //Y01
    public class Cobranca
    {
        [XmlElement(ElementName = "fat")]
        public Fatura[] Faturas { get; set; }

        [XmlElement(ElementName = "dup")]
        public Duplicata[] Duplicatas { get; set; }
    }

    //Y02
    public class Fatura
    {
        [XmlElement(ElementName = "nFat")]
        public string Numero { get; set; }

        [XmlElement(ElementName = "vOrig")]
        public decimal VlOriginal { get; set; }

        [XmlElement(ElementName = "vDesc")]
        public decimal VlDesconto { get; set; }

        [XmlElement(ElementName = "vLiq")]
        public decimal VlLiquido { get; set; }
    }

    //Y07
    public class Duplicata
    {

        [XmlElement(ElementName = "nDup")]
        public string Numero { get; set; }

        [XmlElement(ElementName = "dVenc")]
        public string DataVencimento { get; set; }

        [XmlElement(ElementName = "vDup")]
        public decimal Valor { get; set; }        
    }

    //ZA01
    public class Exportacao
    {
        [XmlElement(ElementName = "UFEmbarq")]
        public string UfEmbarque { get; set; }

        [XmlElement(ElementName = "xLocEmbarq")]
        public string LocalEmbarque { get; set; }        
    }

    //ZB01
    public class Compra
    {
        [XmlElement(ElementName = "xNEmp")]
        public string NotaEmpenho { get; set; }

        [XmlElement(ElementName = "xPed")]
        public string Pedido { get; set; }

        [XmlElement(ElementName = "xCont")]
        public string Contrato { get; set; }
    }

    //PR01
    public class ProtNfe
    {
        [XmlAttribute(AttributeName = "versao")]
        public string Versao { get; set; }

        [XmlElement(ElementName = "infProt")]
        public InfProt InfProt { get; set; }
    }

    //PR03
    public class InfProt
    {
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }

        [XmlElement(ElementName = "tpAmb")]
        public string tpAmb { get; set; }

        [XmlElement(ElementName = "verAplic")]
        public string VerAplic { get; set; }

        [XmlElement(ElementName = "chNFe")]
        public string ChaveNFe { get; set; }

        [XmlElement(ElementName = "dhRecbto")]
        public string DtHrRecbto { get; set; }

        [XmlElement(ElementName = "nProt")]
        public string NumProt { get; set; }

        [XmlElement(ElementName = "digVal")]
        public string DigVal { get; set; }

        [XmlElement(ElementName = "cStat")]
        public string CodStatus { get; set; }

        [XmlElement(ElementName = "xMotivo")]
        public string Motivo { get; set; }
    }

}
