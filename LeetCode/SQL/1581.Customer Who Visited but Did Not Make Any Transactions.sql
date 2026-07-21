/* Write your T-SQL query statement below */
SELECT customer_id, COUNT(customer_id) as count_no_trans
FROM Visits v LEFT JOIN Transactions t
ON t.visit_id = v.visit_id
WHERE t.transaction_id IS NULL
GROUP BY customer_id;