-- CREATE DB
CREATE DATABASE api
    WITH
    OWNER = pokemon
    ENCODING = 'UTF8'
    CONNECTION LIMIT = -1;

-- Table: public.collection

-- DROP TABLE IF EXISTS public.collection;

CREATE TABLE IF NOT EXISTS public.collection
(
    "ID" integer NOT NULL,
    "TRAINER_ID" integer,
    "POKEMON_ID" integer,
    "AQUISITION_DATE" timestamp without time zone,
    "IS_FAVORITE" boolean NOT NULL DEFAULT false,
    CONSTRAINT collection_pkey PRIMARY KEY ("ID")
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.collection
    OWNER to pokemon;

-- POPULATE TABLE
INSERT INTO public.collection(
	"ID", "TRAINER_ID", "POKEMON_ID", "AQUISITION_DATE", "IS_FAVORITE")
	VALUES
    (1, 1, 1, '2021-06-12 00:00:00', FALSE),
    (2, 1, 25, '2021-06-12 00:00:00', TRUE),
    (3, 1, 150, '2021-06-12 00:00:00', TRUE),
    (4, 10, 1, '2021-06-12 00:00:00', TRUE);

-- SEARCH TABLE
SELECT * FROM public.collection
ORDER BY "ID" ASC 