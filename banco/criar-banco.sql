CREATE TABLE clientes (
    id             SERIAL PRIMARY KEY,
    nome           VARCHAR(100) NOT NULL,
    cpf            VARCHAR(11)  NOT NULL UNIQUE,
    datanascimento TIMESTAMP WITH TIME ZONE NOT NULL,
    email          VARCHAR(100)
);

CREATE TABLE dividas (
    id            SERIAL PRIMARY KEY,
    clienteid     INTEGER NOT NULL REFERENCES clientes(id),
    valor         NUMERIC(10, 2) NOT NULL,
    paga          BOOLEAN NOT NULL DEFAULT FALSE,
    datacriacao   TIMESTAMP WITH TIME ZONE NOT NULL,
    datapagamento TIMESTAMP WITH TIME ZONE
);
