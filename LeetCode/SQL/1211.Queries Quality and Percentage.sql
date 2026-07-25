/* Write your T-SQL query statement below */
SELECT query_name, quality = ROUND(AVG((rating * 1.0) / position), 2),
poor_query_percentage = ROUND(100.0 * SUM(CASE WHEN rating < 3 THEN 1 ELSE 0 END) / NULLIF(COUNT(*), 0), 2)
FROM Queries
GROUP BY query_name;