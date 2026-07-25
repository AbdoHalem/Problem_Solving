/* Write your T-SQL query statement below */
SELECT contest_id, percentage = ROUND((COUNT(r.user_id) * 100.0) / (SELECT COUNT(user_id) FROM Users), 2)
FROM Register r 
GROUP BY r.contest_id
ORDER BY percentage desc, r.contest_id asc;