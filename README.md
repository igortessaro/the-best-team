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

## Cadastro de Pokemons [Guilherme]

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

## Cadastro de time - ate 6 pokemons [Leonardo/Bruno]

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
### Criar tabelas

```sql
CREATE TABLE IF NOT EXISTS api.POKEDEX (
    ID INT PRIMARY KEY NOT NULL,
    NICKNAME VARCHAR(150),
    PRIMARY_TYPE VARCHAR(50) NOT NULL,
    SECONDARY_TYPE VARCHAR(50),
    HEIGHT FLOAT,
    WEIGHT INT,
    BASE_EXP INT,
    HP INT,
    ATTACK INT,
    DEFENSE INT,
    SPECIAL_ATK INT,
    SPECIAL_DEF INT,
    SPEED INT,
    ARTWORK VARCHAR(512)
);
CREATE TABLE IF NOT EXISTS api.POKEMON (
    ID SERIAL PRIMARY KEY,
    NICKNAME VARCHAR(150),
    PRIMARY_TYPE VARCHAR(50) NOT NULL,
    SECONDARY_TYPE VARCHAR(50),
    HEIGHT FLOAT,
    WEIGHT INT,
    BASE_EXP INT,
    LEVEL INT NOT NULL,
    ARTWORK VARCHAR(512),
    ID_POKEDEX INT
);
CREATE TABLE IF NOT EXISTS api.TRAINER (
    ID SERIAL PRIMARY KEY,
    NAME VARCHAR(150) NOT NULL,
    PASSWORD VARCHAR(150) NOT NULL,
    EMAIL VARCHAR(150) NOT NULL,
    ID_TEAM INT,
    ID_COLLECTION INT,
    NICKNAME VARCHAR(150) NOT NULL
);
CREATE TABLE IF NOT EXISTS api.COLLECTION (
    ID SERIAL PRIMARY KEY,
    ID_TRAINER INT NOT NULL,
    ID_POKEMON INT NOT NULL,
    IS_FAVORITE BOOLEAN,
    AQUISITION_DATE DATE NOT NULL
);
CREATE TABLE IF NOT EXISTS api.TEAM (
    ID SERIAL PRIMARY KEY,
    NAME VARCHAR(150) NOT NULL,
    ID_TEAM_POKEMON INT
);
CREATE TABLE IF NOT EXISTS api.TEAM_POKEMON (
    ID SERIAL PRIMARY KEY,
    ID_TEAM INT NOT NULL,
    ID_POKEMON INT NOT NULL
);
```

### Inserir dados de Pokédex

```sql
INSERT INTO api.POKEDEX (
    ID,
    NICKNAME,
    PRIMARY_TYPE,
    SECONDARY_TYPE,
    HEIGHT,
    WEIGHT,
    BASE_EXP,
    HP,
    ATTACK,
    DEFENSE,
    SPECIAL_ATK,
    SPECIAL_DEF,
    SPEED,
    ARTWORK
)
VALUES (
    1,
    'bulbasaur',
    'grass',
    'poison',
    7,
    69,
    64,
    45,
    49,
    49,
    65,
    65,
    45,
    'https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/1.png'
),
(
    4,
    'charmander',
    'fire',
    '',
    6,
    85,
    62,
    39,
    52,
    43,
    60,
    50,
    65,
    'https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/4.png'
),
(
    7,
    'squirtle',
    'water',
    '',
    5,
    90,
    63,
    44,
    48,
    65,
    50,
    64,
    43,
    'https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/7.png'
);
```

### Inserir dados de Pokémon

```sql
INSERT INTO api.POKEMON (
    NICKNAME,
    PRIMARY_TYPE,
    SECONDARY_TYPE,
    HEIGHT,
    WEIGHT,
    BASE_EXP,
    LEVEL,
    ARTWORK,
    ID_POKEDEX
)
VALUES (
    'bulbasaur',
    'grass',
    'poison',
    7,
    69,
    64,
    1,
    'https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/1.png',
    1
),
(
    'charmander',
    'fire',
    '',
    6,
    85,
    62,
    1,
    'https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/4.png',
    4
),
(
    'squirtle',
    'water',
    '',
    5,
    90,
    63,
    1,
    'https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/7.png',
    7
);
```

### Inserir dados de Treinador

```sql
INSERT INTO api.TRAINER(NAME, PASSWORD, EMAIL, NICKNAME)
VALUES (
    'Fulano Silva',
    '********',
    'fulano.silva@test.com',
    'Fulano'
),
(
    'Beltrano Santos',
    '********',
    'beltrano.santos@test.com',
    'Beltrano'
),
(
    'Ciclano Silva Santos',
    '********',
    'ciclano.silva@test.com',
    'Ciclano'
);
```

### Inserir dados de Coleção

```sql
INSERT INTO api.collection(
    ID_TRAINER,
    ID_POKEMON,
    IS_FAVORITE,
    AQUISITION_DATE
)
VALUES
(1, 1, FALSE, '2022-07-13 00:00:00'),
(2, 2, FALSE, '2022-07-13 00:00:00'),
(3, 3, FALSE, '2022-07-13 00:00:00'),
(1, 2, FALSE, '2022-07-13 00:00:00');
```

### Inserir dados de Time

```sql
-- TO_BE_IMPLEMENTED
```

### Inserir dados de Time-Pokémon

```sql
-- TO_BE_IMPLEMENTED
```
