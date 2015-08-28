
using System;
using System.Linq;
using Fiscal.Nfe.Models;

namespace Fiscal.Nfe.Domain
{
    public static class NfeSchemaFileResolver<TNfe> where TNfe:class
    {
        private static string nfeTag;

        private static readonly string[] _ArquivoVersao = new[] {
            @"Content\PL_005f\procNFe_v1.10.xsd",
            @"Content\PL_005f\nfe_v1.10.xsd",
            @"Content\PL_006s\procNFe_v2.00.xsd",
            @"Content\PL_006s\nfe_v2.00.xsd",
            @"Content\PL_008f\procNFe_v3.10.xsd",
            @"Content\PL_008f\nfe_v3.10.xsd",
            @"Content\PL_007b\procNFe_v3.00.xsd",
            @"Content\PL_007b\nfe_v3.00.xsd" };

        public static string GetByNfeVersion(string version)
        {
            if (typeof(TNfe) == typeof(NfeProc))
                nfeTag = "procNFe_v";
            else if (typeof(TNfe) == typeof(NotaFiscalEletronica))
                nfeTag = "nfe_v";
            else
                throw new InvalidOperationException("Tipo não reconhecido");           

            return _ArquivoVersao
                .Where(str => str.Contains(nfeTag + version))
                .Select(str => str)
                .FirstOrDefault();
        }
    }
}
