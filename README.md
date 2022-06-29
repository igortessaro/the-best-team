# The Best Team

## Estrutura de projeto [Igor]

- Docker
- Base de dados relacional
- Implementacao de repository
- API
- Configurar hangfire no projeto

## Cadastro de Treinadores [Joao/Miguel]

Pessoas que treinam pokemons.

Premissas para ter um cadastro de treinadores:
    - Tabela de treinadores
        - Definir campos
        - Criar script sql para criacao de tabela
    - Endpoint para CRUD de treinadores

Ex:

#1 Joao
#2 Guilherme
#3 Igor
#4 Gustavo
#5 Gabriel

## Cadastro de Pokemons [Guilherme/Bruno]

Monstrinhos ficticios do jogo pokemon

Premissas para ter um cadastro de pokemons:
    - Tabela de pokemons
        - Definir campos
        - Criar script sql para criacao de tabela
    - Job com hangfire para popular tabela de pokemons usando a api do [Poke-API](https://pokeapi.co/)

Ex:

#1 Bulbasaur
#2 Squirtle
#3 Charmander

## Cadastro de colecao [Gustavo/Gabriel]

A colecao de pokemons eh o cadastro de todos os pokemons que um determionado treinador possui.

Premissas para ter um cadastro de colecao de pokemons:
    - Tabela de colecao de pokemons
        - Definir campos
        - Criar script sql para criacao de tabela
    - Endpoint para CRUD de colecao de pokemons

## Cadastro de time - ate 6 pokemons [Leonardo]

Um conjunto de ate 6 pokemons de um determinado treinador.

Premissas para ter um cadastro de times:
    - Tabela de times
        - Definir campos
        - Criar script sql para criacao de tabela
    - Endpoint para CRUD de times

    - Treinador
    - Pokemon
    - Level

Ex:

Treinador #1
Pokemons
    #1, #2, #3

Treinador #2
Pokemons
    #1, #2

Treinador #1
Pokemons
    #2, #2, #3

## Scripts para criar base de dados

### Criar schema

```sql
CREATE SCHEMA IF NOT EXISTS api;
```
### Criar tabela

```sql
CREATE TABLE IF NOT EXISTS api.trainer (
   id serial PRIMARY KEY,
   name VARCHAR(150) NOT NULL,
   password VARCHAR(150) NOT NULL,
   email VARCHAR(150) NOT NULL,
   nickname VARCHAR(150) NOT NULL
);
```

### Inserir dados de treinador

```sql
INSERT INTO api.trainer(name, password, email, nickname)
VALUES 
    ('Fulano Silva', '********', 'fulano.silva@test.com', 'Fulano'),
    ('Beltrano Santos', '********', 'beltrano.santos@test.com', 'Beltrano'),
    ('Ciclano Silva Santos', '********', 'ciclano.silva@test.com', 'Ciclano');
```
