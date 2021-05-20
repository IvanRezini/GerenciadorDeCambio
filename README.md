# GerenciadorDeCambio
 Usei banco de dados Sqlite
 
 O caminho do banco é: "\GerenciadorDeCambio\bin\Debug\Banco"
 
 Nome do banco de dados "banco"
 
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

Para iniciar o sistema tem que ser cadastrada Moedas e clientes 

Depois pode ser cadastrado operaçoes.

Os relatorios são gerados por cliente e data, ou apenas por data

Para cadastrar um cliente é nessesario um numero de cpf valido pois ele tem validaçao

O banco de dados quarda os valores em varchar, por aver alguns arendondamentos se quardados em decimal.

