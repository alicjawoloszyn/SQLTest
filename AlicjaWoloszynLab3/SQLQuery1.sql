USE master;

CREATE DATABASE MateuszBortkiewiczLab32;

USE MateuszBortkiewiczLab32;

--Tworzymy potrzebne tabele, student�w, kurs�w i wpis�w w indeksie
CREATE TABLE Students (
	 ID int IDENTITY(1,1) PRIMARY KEY,
	 FirstName nvarchar(255),
	 LastName nvarchar(255),
	 Address nvarchar(255),
	 StudentIdent numeric(6,0)
);

CREATE TABLE Courses (
	ID int IDENTITY(1,1) PRIMARY KEY,
	Name nvarchar(63),
	Teacher nvarchar(255)
);

CREATE TABLE IndexPosition (
	ID int IDENTITY(1,1) PRIMARY KEY,
	StudentID int,
	CourseID int,
	Grade numeric(2,1) CHECK (Grade in (2.0, 3.0, 3.5, 4.0,4.5,5.0,5.5))
);

--Wprowadzamy przyk�adowe dane do tabel
INSERT INTO Students(FirstName, LastName, Address, StudentIdent)
	VALUES ('Jan','Kowalski','ul.Polna 1, Wroclaw 50-100', 123332),
			('Marek','Nowak','Nowakowskiego 322, Wroclaw 51-222', 226705),
			('Sta�','Burczymucha','Padewskiego 1/3, Wroc�aw 51-200',20000);

INSERT INTO Courses(Name, Teacher) 
	VALUES ('Bazy Danych 1','dr Mariusz Pazdan'),
		('Archiktektura Komputer�w 1','mgr Jaros�aw Zi�ba'),
		('Teoria obwod�w 1','dr in�. Marian Pa�dzioch');

--Dodajemy klucze g��wne na tabeli IndexPosition
ALTER TABLE IndexPosition 
	ADD FOREIGN KEY (StudentID) REFERENCES Students(ID);

ALTER TABLE IndexPosition
	ADD FOREIGN KEY (CourseID) REFERENCES Courses(ID);

--Wyci�gamy sobie dane
SELECT * FROM Students;

SELECT * FROM Courses;

--Dodajemy oceny
INSERT INTO IndexPosition(StudentID, CourseID, Grade)
	VALUES (1,1,3.5),
		(1,2,3.0),
		(1,3,2.0),
		(2,1,4.0),
		(2,2,4.5),
		(2,3,5),
		(3,1,5),
		(3,2,5.5),
		(3,3,2);	
		
SELECT * FROM IndexPosition;

--Tworzymy widok do przegl�dania ocen
CREATE VIEW GradesView
AS
SELECT c.Name, s.StudentIdent, i.Grade
  FROM IndexPosition i
    JOIN Courses c on i.CourseID = c.ID
    JOIN Students s on i.StudentID = s.ID;

	
--Usuwamy nasz� baz� danych
USE master;

DROP DATABASE MateuszBortkiewiczLab32;