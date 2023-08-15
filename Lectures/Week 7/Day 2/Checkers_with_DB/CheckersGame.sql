DROP TABLE IF EXISTS "Players";
DROP TABLE IF EXISTS "Positions";
DROP TABLE IF EXISTS "Ranks";
DROP TABLE IF EXISTS "Colors";
DROP TABLE IF EXISTS "Pieces";

CREATE TABLE "Players" (
    "id" INTEGER PRIMARY KEY,
    "name" ntext NOT NULL
);

CREATE TABLE "Positions" (
    "id" INTEGER PRIMARY KEY,
    "row" INTEGER NOT NULL,
    "column" INTEGER NOT NULL
);

CREATE TABLE "Ranks" (
    "id" INTEGER PRIMARY KEY,
    "rank" ntext NOT NULL
);

CREATE TABLE "Colors" (
    "id" INTEGER PRIMARY KEY,
    "color" INTEGER NOT NULL
);

CREATE TABLE "Pieces" (
    "id" INTEGER PRIMARY KEY,
    "positionId" INTEGER NOT NULL,
    "rankId" INTEGER NOT NULL,
    "colorId" INTEGER NOT NULL,
    "playerId" INTEGER,
    "isEaten" INTEGER DEFAULT(0),
    "isKinged" INTEGER DEFAULT(0),
    CONSTRAINT "FK_Pieces_Players" FOREIGN KEY
    (
        "playerId"
    ) 
    REFERENCES "Players"
    (
        "id"
    ),
    CONSTRAINT "FK_Pieces_Positions" FOREIGN KEY
    (
        "positionId"
    )
    REFERENCES "Positions"
    (
        "id"
    ),
    CONSTRAINT "FK_Pieces_Ranks" FOREIGN KEY
    (
        "rankId"
    )
    REFERENCES "Ranks"
    (
        "id"
    ),
    CONSTRAINT "FK_Pieces_Colors" FOREIGN KEY
    (
        "colorId"
    )
    REFERENCES "Colors"
    (
        "id"
    )
);

-- INSERT INTO "Players"
--                VALUES(1, 'Haidar'),
--                      (2, 'Asuka');

INSERT INTO "Positions"
               VALUES(1, 0, 1),
                     (2, 0, 3),
                     (3, 0, 5),
                     (4, 0, 7),
                     (5, 1, 0),
                     (6, 1, 2),
                     (7, 1, 4),
                     (8, 1, 6),
                     (9, 2, 1),
                     (10, 2, 3),
                     (11, 2, 5),
                     (12, 2, 7),
                     (13, 5, 0),
                     (14, 5, 2),
                     (15, 5, 4),
                     (16, 5, 6),
                     (17, 6, 1),
                     (18, 6, 3),
                     (19, 6, 5),
                     (20, 6, 7),
                     (21, 7, 0),
                     (22, 7, 2),
                     (23, 7, 4),
                     (24, 7, 6);

INSERT INTO "Ranks"
               VALUES(1, 'Basic'),
                     (2, 'King');

INSERT INTO "Colors"
               VALUES(1, 'Black'),
                     (2, 'Red');

INSERT INTO "Pieces"("id", "positionId", "rankId", "colorId", "playerId")
             VALUES(1, 1, 1, 1, 1),
                    (2, 2, 1, 1, 1),
                    (3, 3, 1, 1, 1),
                    (4, 4, 1, 1, 1),
                    (5, 5, 1, 1, 1),
                    (6, 6, 1, 1, 1),
                    (7, 7, 1, 1, 1),
                    (8, 8, 1, 1, 1),
                    (9, 9, 1, 1, 1),
                    (10, 10, 1, 1, 1),
                    (11, 11, 1, 1, 1),
                    (12, 12, 1, 1, 1),
                    (13, 13, 1, 2, 2),
                    (14, 14, 1, 2, 2),
                    (15, 15, 1, 2, 2),
                    (16, 16, 1, 2, 2),
                    (17, 17, 1, 2, 2),
                    (18, 18, 1, 2, 2),
                    (19, 19, 1, 2, 2),
                    (20, 20, 1, 2, 2),
                    (21, 21, 1, 2, 2),
                    (22, 22, 1, 2, 2),
                    (23, 23, 1, 2, 2),
                    (24, 24, 1, 2, 2);


