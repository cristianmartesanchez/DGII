# DGII

Para este ejercicio debes crear una aplicación web y un API. Este API puede devolver los resultados en
formato XML o en JSON. Eres libre de escoger el formato con el que te sientas más cómodo (sólo es
necesario que se implemente uno de los formatos).
El API debe tener un método desde el cuál se pueda obtener el listado de todos los contribuyentes.
Otro método con el que se pueda obtener el listado de todos los comprobantes fiscales.

En el último ejemplo cada entrada en la colección representa una transacción (se identifica mediante
los campos rncCedula/NCF), el monto de dicha factura (monto) y el 18% del ITBIS (itbis18).
Por último, una aplicación web que muestre el listado de los contribuyentes y al seleccionar uno de
ellos muestre un listado con todos los comprobantes fiscales y la suma total del ITBIS de todas las
transacciones de ese RNC/Cédula.
Por ejemplo, utilizando los datos anteriores, la suma total del ITBIS para el RNC/Cédula 98754321012
debería ser $216.00.
