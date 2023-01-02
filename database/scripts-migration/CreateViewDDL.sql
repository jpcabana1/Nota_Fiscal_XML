USE NFE_IMPORTACAO;
GO
CREATE VIEW NOTA_FISCAL.VIEW_RELATORIO_NOTA
AS 
    SELECT 
        INX.idNota AS "Id"
        ,INX.xChave AS "Chave de Acesso"
        ,PN.xProd AS "Descrição"
        ,PN.uCom AS "Unidade"
        ,PN.qCom AS "Quantidade"
        ,PN.vProd AS "Valor"
        ,FORMAT(CAST(INX.dtProducao AS DATE), 'dd/MM/yyyy') AS  "Data de Emissão"
    FROM NOTA_FISCAL.importacao_nota_xml AS INX INNER JOIN NOTA_FISCAL.produto_nota AS PN
        ON INX.xChave = PN.xChave
        AND INX.xHash = PN.xHash
        AND INX.idNota = PN.idNota
GO
