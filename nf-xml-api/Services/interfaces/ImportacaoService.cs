using System.Xml;
using nf_xml_api.Models;

public interface ImportacaoService
{
    void importarNotaXml(XmlDocument xmlDoc, string chave, string hash);
    ImportacaoNotaXml findNotaPorChaveEHash(string chave, string hash);
}