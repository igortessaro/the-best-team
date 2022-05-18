# The Best Team

## Estrutura de projeto

- Base de dados relacional
- Implementacao de repository
- API
- Configurar hangfire no projeto

## Cadastro de Treinadores

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

Premissas para ter um cadastro de pokemons:
    - Tabela de pokemons
    - Job com hangfire para popular tabela de pokemons usando a api do https://pokeapi.co/

Ex:

#1 Bulbasaur
#2 Squirtle
#3 Charmander

## Cadastro de time

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
