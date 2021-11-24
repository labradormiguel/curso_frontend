Hemos creado un listado de facturas en Index, desde ahí se puede acceder
al formulario (que se ha movido a una nueva vista) y al detalle de cada
factura a través de links.

- Añadidos placeholders al formulario
- Añadido legend y fieldset
- Añadidos radiochecks para el tipo de IVA
- Añadido checkbox para saber si está pagada o no

Añadida carpeta Repositorios en Models

- Añadido FacturaRepositorio.cs

Models/Factura.cs

- Añadido string TipoIVA
- Añadido bool Pagada
- Añadidos dos constructores, uno con parámetros y otro sin

Controllers/FacturaController.cs

- Añadido tipoIVA al constructor
- Añadido pagada al constructor
- Añadido ListaFacturas() (using net.Models.Repositorios;)
