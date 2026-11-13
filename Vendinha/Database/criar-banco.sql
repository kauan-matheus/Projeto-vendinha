CREATE TABLE clientes (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    cpf VARCHAR(14) NOT NULL UNIQUE,
    datanascimento TIMESTAMPTZ NOT NULL,
    email VARCHAR(100)
);

CREATE TABLE dividas (
    id SERIAL PRIMARY KEY,
    clienteid INTEGER NOT NULL REFERENCES clientes(id),
    valor NUMERIC(10, 2) NOT NULL,
    paga BOOLEAN NOT NULL DEFAULT FALSE, /*por padrao e false*/
    datacriacao TIMESTAMPTZ NOT NULL, /*timestamp with time zone*/
    datapagamento TIMESTAMPTZ
);
