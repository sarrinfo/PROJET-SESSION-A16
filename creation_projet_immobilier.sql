// projetImmobilier

CREATE table ADRESSE
(
codePostal NVARCHAR(10),
numero INT,
rue NVARCHAR(20) not null,
localite NVARCHAR(20),
ville NVARCHAR(20),
primary key (codePostal, numero)
);

create table IMMEUBLE
(
ImmeubleID NVARCHAR(10),
codePostal NVARCHAR(10),
numero INT,
Type_Immeuble NVARCHAR(20),
primary key (ImmeubleID),
foreign key (codePostal, numero) REFERENCES ADRESSE
);

create table BIENIMMOBILIER
(
BIENID INT,
ImmeubleID NVARCHAR(10),
Type_BIENIMMOBILIER NVARCHAR(20),
Prix_loyer float,
primary key (BIENID, ImmeubleID),
foreign key (ImmeubleID) REFERENCES IMMEUBLE
);

create table Locataire
(
LocataireID INT,
Nom NVARCHAR(20),
Prenom NVARCHAR(40),
Telephone NVARCHAR(15),
Courriel  NVARCHAR(60),
primary key (LocataireID)
);

create table BAIL
(
ImmeubleID NVARCHAR(10),
LocataireID INT,
Date_Debut date,
Date_Fin date,
BIENID INT,
primary key (ImmeubleID, LocataireID, Date_Debut),
foreign key (BIENID, ImmeubleID) REFERENCES BIENIMMOBILIER(BIENID, ImmeubleID),
foreign key (LocataireID) REFERENCES Locataire
);


create table IMAGE
(
ImmeubleID NVARCHAR(10),
BIENID INT,
ImageID INT,
primary key (ImmeubleID, BIENID, ImageID),
foreign key (BIENID, ImmeubleID) REFERENCES BIENIMMOBILIER(BIENID, ImmeubleID),
foreign key (ImmeubleID) REFERENCES IMMEUBLE
);

create table Client
(
clientID NVARCHAR(10),
nom NVARCHAR(20) NOT null,
prenom NVARCHAR(60),
telephone NVARCHAR(15),
courriel NVARCHAR(60),
primary key (clientID)
);


create table Annonce 
(
numero INT, 
titre NVARCHAR(60),
nombrePieces INT,
nombreSDB INT, 
surface INT, 
anneeConstruction date,
inclusion NVARCHAR(200),
exclusion NVARCHAR(200),
particularite NVARCHAR(200),
autresDescription NVARCHAR(200),
BIENID INT,
ImmeubleID NVARCHAR(10),
primary key (numero),
foreign key (BIENID, ImmeubleID) REFERENCES BIENIMMOBILIER(BIENID, ImmeubleID) 
);


create table Employe
(
EmployeID NVARCHAR(5),
nom NVARCHAR(20),
prenom NVARCHAR(30),
Departement NVARCHAR(20),
Fonction NVARCHAR(20),
NAS NVARCHAR(9),
primary key (EmployeID)
);


create table utilisateur
(
id INT IDENTITY (1,1),
nomUtilisateur NVARCHAR(20),
courriel NVARCHAR(20),
motDePasse NVARCHAR(20),
photo INT,
EmployeID NVARCHAR(5),
LocataireID INT,
clientID NVARCHAR(10),
primary key (id,courriel),
foreign key (clientID) REFERENCES CLIENT,
foreign key (EmployeID) REFERENCES Employe, 
foreign key (LocataireID) REFERENCES Locataire
);


create table Visite
(
DateVisite date,
clientID NVARCHAR(10),
BIENID INT,
ImmeubleID NVARCHAR(10),
EmployeID NVARCHAR(5),
nom NVARCHAR(20),
primary key (DateVisite),
foreign key (BIENID, ImmeubleID) REFERENCES BIENIMMOBILIER(BIENID, ImmeubleID),
foreign key (clientID) REFERENCES Client,
foreign key (EmployeID) REFERENCES Employe(EmployeID)
);



































