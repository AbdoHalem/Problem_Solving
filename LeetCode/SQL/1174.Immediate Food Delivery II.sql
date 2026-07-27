/* Write your T-SQL query statement below */
WITH FirstOrders AS (
    SELECT customer_id, MIN(order_date) AS first_order_date
    FROM Delivery
    GROUP BY customer_id
)
SELECT immediate_percentage = ROUND((SUM(CASE WHEN first_order_date = customer_pref_delivery_date THEN 1 ELSE 0 END) * 100.0) / COUNT(*), 2)
FROM Delivery d
INNER JOIN FirstOrders f ON d.customer_id = f.customer_id
AND d.order_date = f.first_order_date;