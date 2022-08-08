using System;
using System.Collections.Generic;

namespace nf_xml_api.Models
{
    public partial class ImportacaoNotaXml
    {
        public ImportacaoNotaXml()
        {
            ProdutoNota = new HashSet<ProdutoNotum>();
            TotalNota = new HashSet<TotalNotum>();
        }

        public long IdNota { get; set; }
        public string XChave { get; set; } = null!;
        public string XHash { get; set; } = null!;
        public DateTime DtImportacao { get; set; }
        public string XStatusImportacao { get; set; } = null!;
        public string XmlNota { get; set; } = null!;

        public virtual ICollection<ProdutoNotum> ProdutoNota { get; set; }
        public virtual ICollection<TotalNotum> TotalNota { get; set; }
    }
}
