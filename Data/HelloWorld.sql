-- Afficher tous les employés
SELECT E.*, T.Numero, TT.Libelle AS TypeTelephone
FROM Employe E
INNER JOIN Telephone T ON T.EmployeId = E.Id
INNER JOIN TypeTelephone TT ON TT.Id = T.TypeTelephoneId
;

-- Afficher les employés NAJJAR
SELECT * FROM Employe E WHERE E.Nom = 'NAJJAR'; 

--INSERT INTO TypeTelephone (Libelle) VALUES ('Fixe');
--INSERT INTO TypeTelephone (Libelle) VALUES ('Mobile');
SELECT * FROM TypeTelephone;

--INSERT INTO Telephone (TypeTelephoneId, EmployeId, Numero) VALUES (2, 1, '0621595800');
SELECT * FROM Telephone;
