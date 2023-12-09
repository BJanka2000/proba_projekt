CREATE TABLE Termékek
(
Termék_SK nvarchar(64) PRIMARY KEY,
Terméknév nvarchar(128) NOT NULL,
Egységár int NOT NULL CHECK (Egységár > 0)
)

INSERT INTO Termékek
(
Termék_SK, Terméknév, Egységár
)
VALUES
('T01', 'műfenyő', '24000'),
('T02', 'LED karácsonyi fényfüzér', '3300'),
('T03', 'csillag csúcsdísz', '2500'),
('T04', 'fém karácsonyfa állvány', '7000'),
('T05', 'gömb karácsonyfadísz (8db)', '4000')

CREATE TABLE Vevők
(
Vevő_SK nvarchar(128) PRIMARY KEY,
Név nvarchar(128) NOT NULL,
Login nvarchar(128),
Email nvarchar(128) NOT NULL
)

INSERT INTO Vevők
(
Vevő_SK, Név, Login, Email
)
VALUES
('V01', 'Kiss Péter', 'kp01', 'kiss.peter@gmail.com'),
('V02', 'Nagy Gergely', '', 'nagy.gergely@gmail.com'),
('V03', 'Kovács Sára', 'ks03', 'kovacs.sara@gmail.com'),
('V04', 'Balog Zoltán', '', 'balog.zoltan@gmail.com'),
('V05', 'Nagy Zsófia', 'nzs05', 'nagy.zsofia@gmail.com'),
('V06', 'Tóth Júlia', 'tj06', 'toth.julia@gmail.com'),
('V07', 'Lakatos Zsolt', '', 'lakatos.zsolt@gmail.com')

CREATE TABLE Rendelések
(
Rend_ID nvarchar(128) PRIMARY KEY,
Időpont datetime NOT NULL,
Termék_FK nvarchar(64) NOT NULL FOREIGN KEY references Termékek (Termék_SK),
Mennyiség int NOT NULL CHECK (Mennyiség > 0),
Vevő_FK nvarchar(128) NOT NULL FOREIGN KEY references Vevők (Vevő_SK)
)

INSERT INTO Rendelések
(
Rend_ID, Időpont, Termék_FK, Mennyiség, Vevő_FK
)
VALUES
('R01', '2023.12.07 12:45', 'T01', '1', 'V04'),
('R02', '2023.12.07 11:33', 'T04', '1', 'V01'),
('R03', '2023.12.09 16:45', 'T05', '2', 'V07'),
('R04', '2023.12.10 18:39', 'T02', '4', 'V03'),
('R05', '2023.12.11 10:05', 'T01', '1', 'V02'),
('R06', '2023.12.11 19:15', 'T01', '1', 'V06'),
('R07', '2023.12.12 21:45', 'T03', '2', 'V01'),
('R08', '2023.12.14 20:03', 'T04', '2', 'V04'),
('R09', '2023.12.15 12:19', 'T05', '7', 'V07'),
('R10', '2023.12.16 12:23', 'T03', '1', 'V03')


CREATE TABLE Szállító_adatok
(
Szállító_SK nvarchar(64) PRIMARY KEY,
Cégnév nvarchar(128) NOT NULL,
Email nvarchar(128) NOT NULL,
Székhely nvarchar(128) NOT NULL
)

INSERT INTO Szállító_adatok
(
Szállító_SK, Cégnév, Email, Székhely
)
VALUES
('S01', 'Orna-meant Kft.', 'ornameant@gmail.com', '3420 Püspökladány, Rákóczi utca 9'),
('S02', 'Összerak Kft.', 'osszerak@gmail.com', '8740 Pécs, Izabella utca 45'),
('S03', 'Happy holly-day Kft.', 'happy.hollyday@gmail.com', '5450 Győr, Király út 67')


CREATE TABLE Szállítók
(
Szállítás_ID nvarchar(128) PRIMARY KEY,
Szállító_FK nvarchar(64) FOREIGN KEY references Szállító_adatok (Szállító_SK),
Termék_FK nvarchar(64) NOT NULL FOREIGN KEY references Termékek (Termék_SK),
Mennyiség_szállító int NOT NULL CHECK (Mennyiség_szállító > 0),
Megrendelés_időpontja datetime NOT NULL,
Teljesítés_időpontja datetime,
Egységár_szállító int NOT NULL CHECK (Egységár_szállító > 0)
)

INSERT INTO Szállítók
(Szállítás_ID, Szállító_FK, Termék_FK, Mennyiség_szállító, Megrendelés_időpontja, Teljesítés_időpontja, Egységár_szállító)
VALUES
('Z01', 'S01', 'T01', '40', '2023.11.12 9:35', '2023.11.14 10:49', '18000'),
('Z02', 'S01', 'T04', '35', '2023.11.12 9:35', '2023.11.14 10:49', '5500'),
('Z03', 'S03', 'T03', '60', '2023.11.13 10:15', '2023.11.16 11:20', '1000'),
('Z04', 'S01', 'T04', '12', '2023.11.15 10:23', '2023.11.18 12:26', '5500'),
('Z05', 'S02', 'T02', '70', '2023.11.19 15:15', '2023.11.21 14:11', '2000'),
('Z06', 'S03', 'T05', '100', '2023.11.20 13:15', '2023.11.23 11:23', '3000')