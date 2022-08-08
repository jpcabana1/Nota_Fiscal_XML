using System;
using System.Collections.Generic;

namespace nf_xml_api.Models
{
    public partial class TotalNotum
    {
        public long IdTotal { get; set; }
        public decimal VBc { get; set; }
        public decimal VIcms { get; set; }
        public decimal VIcmsdeson { get; set; }
        public decimal VFcp { get; set; }
        public decimal VBcst { get; set; }
        public decimal VSt { get; set; }
        public decimal VFcpst { get; set; }
        public decimal VFcpstret { get; set; }
        public decimal VProd { get; set; }
        public decimal VFrete { get; set; }
        public decimal VSeg { get; set; }
        public decimal VDesc { get; set; }
        public decimal VIi { get; set; }
        public decimal VIpi { get; set; }
        public decimal VIpidevol { get; set; }
        public decimal VPis { get; set; }
        public decimal VCofins { get; set; }
        public decimal VOutro { get; set; }
        public decimal VNf { get; set; }
        public decimal VTotTrib { get; set; }
        public long IdNota { get; set; }
        public string XChave { get; set; } = null!;
        public string XHash { get; set; } = null!;

        public virtual ImportacaoNotaXml ImportacaoNotaXml { get; set; } = null!;
    }
}
