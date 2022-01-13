--Part 1
CREATE TABLE Jobs (
Id INT PRIMARY KEY AUTO_INCREMENT,
Name VARCHAR(40),
EmployerId INT 
FOREIGN KEY (EmployerId) REFERENCES Employer(Id));

--Part 2
SELECT Employers.Name
FROM Employers
WHERE Employers.Location = "St. Louis City";

--Part 3
SELECT Skills.Name, Skills.Description
FROM Skills
INNER JOIN JobSkills ON Skills.Id = JobSkills.SkillId
ORDER BY Skills.Name ASC;
