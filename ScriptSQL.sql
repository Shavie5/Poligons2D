CREATE DATABASE Poligons2D 
GO

USE Poligons2D
GO


CREATE TABLE Poligon(
    Nom VARCHAR(50) PRIMARY KEY,
    Color VARCHAR(20),
    TeInterior BIT,
    TipusPoligon NVARCHAR(20) NOT NULL,
    CONSTRAINT CHK_Type CHECK (TipusPoligon IN ('Quadrat','Rectangle', 'TriangleIsosceles','TriangleRectangle', 'Cercle', 'Rombe', 'Elipse', 'Pentagon', 'Hexagon', 'Octogon'))
);


CREATE TABLE Quadrat(
	Nom VARCHAR(50) PRIMARY KEY,    
	Mida INT,
    CONSTRAINT fk_quadrat_poligon FOREIGN KEY (Nom) REFERENCES Poligon(Nom)
);

CREATE TABLE Rectangle(
	Nom VARCHAR(50) PRIMARY KEY,
	Base INT,
    Alçada INT,
	CONSTRAINT fk_rectangle_poligon FOREIGN KEY (Nom) REFERENCES Poligon(Nom)
);

CREATE TABLE TriangleIsosceles(
    Nom VARCHAR(50) PRIMARY KEY,
    Base INT,
    Alçada INT,
    CONSTRAINT fk_triangleI_poligon FOREIGN KEY (Nom) REFERENCES Poligon(Nom)
);

CREATE TABLE TriangleRectangle(
    Nom VARCHAR(50) PRIMARY KEY,
    Base INT,
    Alçada INT,
	Direccio BIT,
    CONSTRAINT fk_triangleR_poligon FOREIGN KEY (Nom) REFERENCES Poligon(Nom)
);

CREATE TABLE Cercle(
    Nom VARCHAR(50) PRIMARY KEY,
    Radi INT,
    CONSTRAINT fk_cercle_poligon FOREIGN KEY (Nom) REFERENCES Poligon(Nom)
);

CREATE TABLE Rombe(
    Nom VARCHAR(50) PRIMARY KEY,
    DiagonalA INT,
    DiagonalB INT,
    CONSTRAINT fk_rombe_poligon FOREIGN KEY (Nom) REFERENCES Poligon(Nom)
);


CREATE TABLE Elipse(
    Nom VARCHAR(50) PRIMARY KEY,
    RadiA INT,
    RadiB INT,
    CONSTRAINT fk_elipse_poligon FOREIGN KEY (Nom) REFERENCES Poligon(Nom)
);

CREATE TABLE Pentagon(
    Nom VARCHAR(50) PRIMARY KEY,
    Costat INT,
    CONSTRAINT fk_pentagon_poligon FOREIGN KEY (Nom) REFERENCES Poligon(Nom)
);

CREATE TABLE Hexagon(
    Nom VARCHAR(50) PRIMARY KEY,
    Costat INT,
    CONSTRAINT fk_hexagon_poligon FOREIGN KEY (Nom) REFERENCES Poligon(Nom)
);


CREATE TABLE Octogon(
    Nom VARCHAR(50) PRIMARY KEY,
    Costat INT,
    CONSTRAINT fk_octogon_poligon FOREIGN KEY (Nom) REFERENCES Poligon(Nom)
);




-- Insertar polígonos en la tabla principal
INSERT INTO Poligon (Nom, Color, TeInterior, TipusPoligon) VALUES 
('QuadratVermell', 'Red', 1, 'Quadrat'),
('RectangleBlau', 'Blue', 0, 'Rectangle'),
('CercleVerd', 'Green', 1, 'Cercle'),
('ElipseGroc', 'Yellow', 0, 'Elipse'),
('TriangleRectangleNegre', 'Black', 1, 'TriangleRectangle'),
('TriangleIsoscelesRosa', 'Pink', 0, 'TriangleIsosceles'),
('RombeTronja', 'Orange', 1, 'Rombe'),
('PentagonLila', 'Purple', 0, 'Pentagon'),
('HexagonMarro', 'Brown', 1, 'Hexagon'),
('OctagonGris', 'Gray', 0, 'Octogon');

INSERT INTO Quadrat (Nom, Mida) VALUES ('QuadratVermell', 150);
INSERT INTO Rectangle (Nom, Base, Alçada) VALUES ('RectangleBlau', 200, 120);
INSERT INTO Cercle (Nom, Radi) VALUES ('CercleVerd', 180);
INSERT INTO Elipse (Nom, RadiA, RadiB) VALUES ('ElipseGroc', 250, 130);
INSERT INTO TriangleRectangle (Nom, Base, Alçada, Direccio) VALUES ('TriangleRectangleNegre', 180, 220, 1);
INSERT INTO TriangleIsosceles (Nom, Base, Alçada) VALUES ('TriangleIsoscelesRosa', 190, 190);
INSERT INTO Rombe (Nom, DiagonalA, DiagonalB) VALUES ('RombeTronja', 220, 160);
INSERT INTO Pentagon (Nom, Costat) VALUES ('PentagonLila', 150);
INSERT INTO Hexagon (Nom, Costat) VALUES ('HexagonMarro', 180);
INSERT INTO Octogon (Nom, Costat) VALUES ('OctagonGris', 170);

SELECT * FROM Poligon;