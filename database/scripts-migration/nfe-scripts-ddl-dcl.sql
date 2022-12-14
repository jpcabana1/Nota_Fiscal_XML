
CREATE DATABASE NFE_IMPORTACAO;

USE NFE_IMPORTACAO;

CREATE LOGIN nota_app WITH PASSWORD = '!n0ta_app';
CREATE USER nota_app FOR LOGIN nota_app;


CREATE SCHEMA NOTA_FISCAL AUTHORIZATION nota_app;

CREATE TABLE NOTA_FISCAL.importacao_nota_xml(
    idNota BIGINT NOT NULL IDENTITY(1,1),
    xChave VARCHAR(45) NOT NULL,
    xHash VARCHAR(35) NOT NULL,
    dtImportacao DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    xStatusImportacao VARCHAR(25) NOT NULL,
    xmlNota XML NOT NULL
    PRIMARY KEY (idNota, xChave, xHash),
    UNIQUE (xChave, xHash)
);

CREATE TABLE NOTA_FISCAL.produto_nota(
    idProduto BIGINT NOT NULL IDENTITY(1,1),
    cProd BIGINT NOT NULL,
    cEAN BIGINT NOT NULL,
    xProd VARCHAR(120) NOT NULL,
    NCM INT NOT NULL,
    CEST INT NOT NULL,
    CFOP INT NOT NULL,
    uCom VARCHAR(6) NOT NULL,
    qCom DECIMAL(5,2) NOT NULL,
    vUnCom DECIMAL(5,2) NOT NULL,
    vProd DECIMAL(5,2) NOT NULL,
    cEANTrib VARCHAR(100) NOT NULL,
    uTrib VARCHAR(6) NOT NULL,
    qTrib DECIMAL(5,2) NOT NULL,
    vUnTrib DECIMAL(5,2) NOT NULL,
    indTot INT NOT NULL,
    idNota BIGINT NOT NULL,
    xChave VARCHAR(45) NOT NULL,
    xHash VARCHAR(35) NOT NULL,
    PRIMARY KEY (idProduto),
    FOREIGN KEY(idNota, xChave, xHash) REFERENCES NOTA_FISCAL.importacao_nota_xml(idNota, xChave, xHash)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

CREATE TABLE NOTA_FISCAL.total_nota(
    idTotal BIGINT NOT NULL IDENTITY(1,1),
    vBC DECIMAL(10,2) NOT NULL,
    vICMS DECIMAL(10,2) NOT NULL,
    vICMSDeson DECIMAL(10,2) NOT NULL,
    vFCP DECIMAL(10,2) NOT NULL,
    vBCST DECIMAL(10,2) NOT NULL,
    vST DECIMAL(10,2) NOT NULL,
    vFCPST DECIMAL(10,2) NOT NULL,
    vFCPSTRet DECIMAL(10,2) NOT NULL,
    vProd DECIMAL(10,2) NOT NULL,
    vFrete DECIMAL(10,2) NOT NULL,
    vSeg DECIMAL(10,2) NOT NULL,
    vDesc DECIMAL(10,2) NOT NULL,
    vII DECIMAL(10,2) NOT NULL,
    vIPI DECIMAL(10,2) NOT NULL,
    vIPIDevol DECIMAL(10,2) NOT NULL,
    vPIS DECIMAL(10,2) NOT NULL,
    vCOFINS DECIMAL(10,2) NOT NULL,
    vOutro DECIMAL(10,2) NOT NULL,
    vNF DECIMAL(10,2) NOT NULL,
    vTotTrib DECIMAL(10,2) NOT NULL,
    idNota BIGINT NOT NULL,
    xChave VARCHAR(45) NOT NULL,
    xHash VARCHAR(35) NOT NULL,
    PRIMARY KEY (idTotal),
    FOREIGN KEY(idNota, xChave, xHash) REFERENCES NOTA_FISCAL.importacao_nota_xml(idNota, xChave, xHash)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

GRANT SELECT, INSERT, UPDATE, DELETE ON SCHEMA::NOTA_FISCAL TO nota_app;

ALTER TABLE NOTA_FISCAL.importacao_nota_xml
ADD dtProducao DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP;

ALTER TABLE NOTA_FISCAL.importacao_nota_xml
alter COLUMN dtProducao DATETIME;

CREATE VIEW NOTA_FISCAL.VIEW_RELATORIO_NOTA
AS 
    SELECT 
        INX.idNota AS "Id"
        ,INX.xChave AS "Chave de Acesso"
        ,PN.xProd AS "Descri????o"
        ,PN.uCom AS "Unidade"
        ,PN.qCom AS "Quantidade"
        ,PN.vProd AS "Valor"
        ,FORMAT(CAST(INX.dtProducao AS DATE), 'dd/MM/yyyy') AS  "Data de Emiss??o"
    FROM NOTA_FISCAL.importacao_nota_xml AS INX INNER JOIN NOTA_FISCAL.produto_nota AS PN
        ON INX.xChave = PN.xChave
        AND INX.xHash = PN.xHash
        AND INX.idNota = PN.idNota
GO
