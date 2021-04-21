
CREATE TRIGGER Instock_After_Order
on Order_Detail
after INSERT
as
begin
update Products
set InStock = InStock + (select Quantity  from inserted where inserted.SKU = Products.SKU)
from Products join inserted on Products.SKU = inserted.SKU
end


