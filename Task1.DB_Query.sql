1.
SELECT TOP 1 *
FROM EMPLOYEE
ORDER BY SALARY DESC;
................................................................
2.
WITH EmployeeHierarchy AS (
    SELECT ID, CHIEF_ID, 1 AS Level
    FROM EMPLOYEE
    WHERE CHIEF_ID IS NULL
    UNION ALL
    SELECT e.ID, e.CHIEF_ID, eh.Level + 1
    FROM EMPLOYEE e
    JOIN EmployeeHierarchy eh ON e.CHIEF_ID = eh.ID
)
SELECT MAX(Level) AS MaxDepth
FROM EmployeeHierarchy;
...............................................................
3.
SELECT TOP 1 d.Name AS Department, SUM(e.Salary) AS TotalSalary
FROM DEPARTMENT d
JOIN EMPLOYEE e ON d.ID = e.DEPARTMENT_ID
GROUP BY d.Name
ORDER BY TotalSalary DESC;
...............................................................
4.
SELECT *
FROM EMPLOYEE
WHERE NAME LIKE N'Р%н';
