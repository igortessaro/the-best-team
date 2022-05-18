# The Best Team

## Estrutura de projeto

- Base de dados relacional
- Implementacao de repository
- API
- Configurar hangfire no projeto

## Cadastro de Treinadores

Pessoas que treinam pokemons.

Premissas para ter um cadastro de treinadores:
    - Tabela de treinadores
    - Endpoint para CRUD de treinadores

Ex:

#1 Joao
#2 Guilherme
#3 Igor
#4 Gustavo
#5 Gabriel

## Cadastro de Pokemons

Monstrinhos ficticios do jogo pokemon

Premissas para ter um cadastro de pokemons:
    - Tabela de pokemons
    - Job com hangfire para popular tabela de pokemons usando a api do [Poke-API](https://pokeapi.co/)

Ex:

#1 Bulbasaur
#2 Squirtle
#3 Charmander

## Cadastro de colecao

A colecao de pokemons eh o cadastro de todos os pokemons que um determionado treinador possui.

Premissas para ter um cadastro de colecao de pokemons:
    - Tabela de colecao de pokemons
    - Endpoint para CRUD de colecao de pokemons

## Cadastro de time - ate 6 pokemons

Um conjunto de ate 6 pokemons de um determinado treinador.

Premissas para ter um cadastro de times:
    - Tabela de times
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
