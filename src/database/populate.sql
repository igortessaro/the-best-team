-- POPULATE POKEDEX
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
-- POPULATE POKEMON
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
-- POPULATE TRAINER
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
-- POPULATE COLLECTION
INSERT INTO api.collection(
        ID_TRAINER,
        ID_POKEMON,
        IS_FAVORITE,
        AQUISITION_DATE
    )
VALUES (1, 1, FALSE, '2022-07-13 00:00:00'),
    (2, 2, FALSE, '2022-07-13 00:00:00'),
    (3, 3, FALSE, '2022-07-13 00:00:00'),
    (1, 2, FALSE, '2022-07-13 00:00:00');