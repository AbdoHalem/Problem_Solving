/* Write your T-SQL query statement below */
SELECT e.name, b.bonus FROM Employee e Left JOIN Bonus b
ON e.empId = b.empId
WHERE b.bonus < 1000 OR b.bonus IS NULL;