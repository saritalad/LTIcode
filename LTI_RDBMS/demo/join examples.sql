SELECT suppliers.supplier_id, suppliers.supplier_name, orders.order_date
FROM suppliers 
INNER JOIN orders
ON suppliers.supplier_id = orders.supplier_id;
-----------------------------
order_id, supplier_id, and order_date
---------------------
(supplier_id and supplier_name)