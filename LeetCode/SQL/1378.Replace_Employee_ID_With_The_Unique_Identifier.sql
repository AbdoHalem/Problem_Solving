/* Write your T-SQL query statement below */
SELECT unique_id, name FROM Employees e LEFT OUTER JOIN EmployeeUNI eUNI
ON e.id = eUNI.id;