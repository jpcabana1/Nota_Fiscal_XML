using nf_xml_api.Models;

public interface TotalNotaService
{
    void SalvarTotalNota(ImportacaoNotaXml nota, TNfeProc dto, string chave, string hash);
}