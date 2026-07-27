/* Write your T-SQL query statement below */
SELECT 
    ROUND(SUM(CASE WHEN DATEDIFF(DAY, prev_date, event_date) = 1 THEN 1 ELSE 0 END) * 1.0
    / COUNT(DISTINCT player_id), 2) AS fraction
FROM (
    SELECT player_id, MIN(event_date) OVER (PARTITION BY player_id ORDER BY event_date) as prev_date, event_date
    FROM Activity
) AS temp;