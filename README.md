# GerenciadorDeCambio
 Usei banco de dados Sqlite
 O caminho do banco é: "\GerenciadorDeCambio\bin\Debug\Banco"
 Damp do banco de dados:
 
 "CREATE TABLE tbCliente (
    id   INTEGER PRIMARY KEY AUTOINCREMENT
                 UNIQUE,
    nome VARCHAR NOT NULL,
    data DATE    NOT NULL,
    cpf  VARCHAR
);

CREATE TABLE tbMoeda (
    id   INTEGER PRIMARY KEY AUTOINCREMENT
                 UNIQUE
                 NOT NULL,
    nome VARCHAR,
    taxa VARCHAR CONSTRAINT [0] NOT NULL
);

CREATE TABLE tbOberacao (
    idCliente       INTEGER,
    moedaOrigem     INTEGER,
    moedaDestino    INTEGER,
    dataOperacao    DATE,
    valorOriginal   VARCHAR,
    valorConvertido VARCHAR,
    taxaCobrada     VARCHAR,
    id              INTEGER PRIMARY KEY AUTOINCREMENT
                            UNIQUE
                            NOT NULL
);
"
SELECT tbOberacao.id, tbOberacao.dataOperacao,tbOberacao.valorOriginal,tbOberacao.valorConvertido, tbCliente.nome, tbOberacao.taxaCobrada, rt.nome as origem, sr.nome as destino
                                      FROM tbOberacao INNER JOIN tbCliente
                                      ON tbOberacao.idCliente = tbCliente.id
                                      INNER JOIN tbMoeda as rt
                                      ON tbOberacao.moedaOrigem = rt.id 
                                      INNER JOIN tbMoeda as sr
                                      ON tbOberacao.moedaDestino = sr.id 
                                      ORDER BY data DESC