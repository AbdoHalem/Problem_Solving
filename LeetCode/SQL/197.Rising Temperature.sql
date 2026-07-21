/* Write your T-SQL query statement below */
SELECT id FROM (SELECT id, recordDate, temperature, LAG(temperature) OVER(ORDER BY recordDate) AS prevTemp,
LAG(recordDate) OVER(ORDER BY recordDate) AS prevDate FROM Weather) AS sub
WHERE DATEDIFF(DAY, prevDate, recordDate) = 1
AND temperature > prevTemp;