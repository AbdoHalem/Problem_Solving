/* Write your T-SQL query statement below */
SELECT FORMAT(trans_date, 'yyyy-MM') AS month, country, 
trans_count = COUNT(*),
approved_count = SUM(CASE WHEN state = 'approved' THEN 1 ELSE 0 END),
trans_total_amount = SUM(amount),
approved_total_amount = SUM(CASE WHEN state = 'approved' THEN amount ELSE 0 END)
FROM Transactions
GROUP BY FORMAT(trans_date, 'yyyy-MM'), country;