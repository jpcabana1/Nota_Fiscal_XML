using System;
using System.Collections.Generic;

namespace nf_xml_api.Models
{
    public partial class ProdutoNotum
    {
        public long IdProduto { get; set; }
        public long CProd { get; set; }
        public long CEan { get; set; }
        public string XProd { get; set; } = null!;
        public int Ncm { get; set; }
        public int Cest { get; set; }
        public int Cfop { get; set; }
        public string UCom { get; set; } = null!;
        public decimal QCom { get; set; }
        public decimal VUnCom { get; set; }
        public decimal VProd { get; set; }
        public string CEantrib { get; set; } = null!;
        public string UTrib { get; set; } = null!;
        public decimal QTrib { get; set; }
        public decimal VUnTrib { get; set; }
        public int IndTot { get; set; }
        public long IdNota { get; set; }
        public string XChave { get; set; } = null!;
        public string XHash { get; set; } = null!;

        public virtual ImportacaoNotaXml ImportacaoNotaXml { get; set; } = null!;
    }
}
