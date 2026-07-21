-- /* Write your T-SQL query statement below */
SELECT p.product_id, ROUND(ISNULL(SUM(p.price * u.units) * 1.0 / SUM(u.units), 0), 2) AS average_price 
FROM Prices p LEFT JOIN UnitsSold u 
ON p.product_id = u.product_id
AND u.purchase_date BETWEEN p.start_date AND p.end_date
GROUP BY p.product_id;

-- Another Solution
-- SELECT p.product_id, ROUND(ISNULL(SUM(p.price * u.units) * 1.0 / SUM(u.units), 0), 2) AS average_price 
-- FROM Prices p LEFT JOIN UnitsSold u 
-- ON p.product_id = u.product_id
-- AND DATEDIFF(DAY, p.start_date, u.purchase_date) >= 0
-- AND DATEDIFF(DAY, u.purchase_date, p.end_date) >= 0
-- GROUP BY p.product_id;