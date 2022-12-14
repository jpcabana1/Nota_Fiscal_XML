using System.Xml;
using nf_xml_api.Models;

namespace nf_xml_api.Services
{
    public class ImportacaoServiceImpl : ImportacaoService
    {
        private static readonly string MENSAGEM_NOTA_JA_CADASTRADA = "Nota fiscal já está registrada na base de dados";
        private readonly NotaFiscalContext _context;


        public ImportacaoServiceImpl(NotaFiscalContext context)
        {
            _context = context;

        }

        public void importarNotaXml(XmlDocument xmlDoc, string chave, string hash, DateTime dtProducao)
        {
            if (this.findNotaPorChaveEHash(chave, hash) == null && xmlDoc.DocumentElement != null)
            {
                _context.ImportacaoNotaXmls.Add(new ImportacaoNotaXml()
                {
                    XChave = chave,
                    XHash = hash,
                    XStatusImportacao = "PROCESSADO",
                    DtProducao = dtProducao,
                    XmlNota = xmlDoc.DocumentElement.OuterXml
                });

                _context.SaveChanges();
            }
            else
            {
                throw new Exception(MENSAGEM_NOTA_JA_CADASTRADA);
            }
        }

        public ImportacaoNotaXml findNotaPorChaveEHash(string chave, string hash)
        {
            var queryNota = from importacaoNota in _context.ImportacaoNotaXmls
                            where importacaoNota.XChave == chave && importacaoNota.XHash == hash
                            select importacaoNota;
            return queryNota.FirstOrDefault();
        }

        public void attStatusNota(string chave, string hash)
        {
            var nota = findNotaPorChaveEHash(chave, hash);
            if(nota != null){
                nota.XStatusImportacao = "PROCESSADO";
                _context.Update(nota);
                _context.SaveChangesAsync();
            }
            throw new NotImplementedException();
        }
    }
}