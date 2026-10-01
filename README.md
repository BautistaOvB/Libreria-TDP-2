<<<<<<< HEAD
# Gestion-Libreria
=======
# Libreria-TDP-2
=======
# Gestion-Libreria

<<<<<<< Body
# Especificacion de Requerimientos de Software
Proyecto: Sistema de Gestión de Librería
Sistema de Gestión de Ventas e Inventario para Librería
Alumnos: 
•	Ovalle Bravo Bautista
•	Marcos Valentin Romero Cristanchi
1. Introducción
1.1 Propósito
El propósito de este documento es especificar de manera detallada los requisitos funcionales y no funcionales del Sistema de Gestión de Ventas e Inventario. Este documento servirá como guía para el equipo de desarrollo, prueba y validación con los interesados (stakeholders).
1.2 Alcance
El sistema es una aplicación de escritorio diseñada para automatizar la operatoria diaria de la librería. Comprende:
•	Gestión centralizada del catálogo de libros (autores, editoriales, categorías, ISBN).
•	Administración de cuentas de usuario y niveles de acceso según roles.
•	Control de inventario (ingresos, egresos, ajustes manuales y alertas de stock mínimo).
•	Registro de ventas, cálculo de totales/impuestos y emisión de comprobantes digitales e impresos.
•	Generación de reportes operativos e históricos para la toma de decisiones.
Fuera del alcance (Fase 1): Integración con pasarelas de pago online, tienda e-commerce y facturación electrónica directa con entes fiscales (se contempla su factibilidad para futuras versiones).
1.3 Definiciones, Acrónimos y Siglas
•	ERS / SRS: Especificación de Requerimientos de Software (Software Requirements Specification).
•	GUI: Interfaz Gráfica de Usuario (Graphical User Interface).
•	Admin: Administrador con privilegios totales del sistema.
•	ISBN: Número Estándar Internacional del Libro (International Standard Book Number).
•	SKU / Código Interno: Identificador único del producto dentro del inventario de la librería.
•	CRUD: Crear, Leer, Actualizar y Eliminar (Create, Read, Update, Delete).
1.4 Referencias
•	Estándar IEEE 830-1998 para la Especificación de Requerimientos de Software.
•	Documentación oficial de Microsoft .NET, C# y WinForms / WPF.
•	Manuales técnicos y mejores prácticas de diseño de BD en Microsoft SQL Server.
1.5 Visión General del Documento
Este documento está dividido en cuatro secciones principales: la Sección 1 introduce el proyecto y sus objetivos; la Sección 2 describe la perspectiva del producto, roles y restricciones tecnológicas; la Sección 3 detalla los requisitos específicos (funcionales, no funcionales y casos de uso); y la Sección 4 incluye apéndices y diagramas complementarios.
2. Descripción General
2.1 Perspectiva del Producto
El sistema es un producto autónomo de escritorio (standalone/client-server) desarrollado con la plataforma .NET (C#) sobre Windows Forms (WinForms) o WPF. Interactúa de forma directa con una base de datos relacional local o de red de área local (LAN) alojada en Microsoft SQL Server.
2.2 Funciones del Producto
•	Módulo de Autenticación y Seguridad: Control de acceso mediante credenciales encriptadas y roles de usuario.
•	Módulo de Catálogo e Inventario: Alta, modificación, consulta y baja lógica de libros, así como actualización e historial de movimientos de stock.
•	Módulo de Punto de Venta (POS): Búsqueda ágil de libros (por ISBN, título, autor o lectura de código de barras), armado de carrito de compras, aplicación de promociones/descuentos y registro final de la transacción.
•	Módulo de Reportes: Visualización e impresión de estadísticas clave sobre facturación diaria/mensual, productos más vendidos y stock crítico.
2.3 Características de los Usuarios
•	Administrador: Usuario con perfil avanzado. Encargado de la configuración general, gestión de usuarios, auditoría.
•	Repositor / Encargado de Depósito: Usuario operativo. Responsable del ingreso de mercancía, modificación de catálogo de libros, proveedores y control físico de stock.
•	Vendedor / Cajero: Usuario operativo de atención al cliente. Orientado a la agilidad operativa en caja, cobro y emisión de facturas/comprobantes.
2.4 Restricciones
•	Plataforma de Ejecución: Sistemas operativos Microsoft Windows 10 / 11.
•	Entorno de Desarrollo: Visual Studio con lenguaje C# (.NET Framework 4.8 o .NET 8 Desktop Runtime).
•	Base de Datos: Microsoft SQL Server (Express o Standard Edition).
•	Arquitectura: Diseño en capas (Presentación, Lógica de Negocio y Acceso a Datos / Repositorios).
•	Hardware: Compatible con impresoras térmicas de tickets y lectores de códigos de barras USB/Bluetooth de simulación de teclado.
2.5 Suposiciones y Dependencias
•	Se asume que las terminales de trabajo cuentan con la infraestructura de red LAN correctamente configurada para conectarse al servidor de SQL Server.
•	El cliente dispondrá del hardware adecuado (lector de código de barras e impresora).
3. Requisitos Específicos
3.1 Requisitos Funcionales (RF)
Gestión de Seguridad y Usuarios
•	RF1.1 - Autenticación de Usuarios: El sistema debe requerir nombre de usuario y contraseña para acceder.
•	RF1.2 - Gestión de Perfiles: El Administrador podrá crear, modificar, desactivar (baja lógica) y resetear contraseñas de usuarios.
•	RF1.3 - Control de Permisos por Rol: El sistema debe restringir las funcionalidades según el rol asignado (Admin, Repositor, Vendedor).
Gestión de Catálogo e Inventario
•	RF2.1 - Registro de Libros: El sistema debe permitir al Repositor registrar libros incluyendo: ISBN, Título, Autor, Editorial, Categoría/Género, Precio de Costo, Precio de Venta, Stock Actual y Stock Mínimo.
•	RF2.2 - Control de Entradas y Salidas: El Repositor podrá registrar ingresos por compras a proveedores y egresos por pérdidas, mermas o devoluciones, indicando motivo y fecha.
•	RF2.3 - Alerta de Stock Mínimo: El sistema debe notificar o resaltar visualmente cuando un producto alcance o supere por debajo el límite de stock mínimo configurado.
Gestión de Ventas
•	RF3.1 - Interfaz de Punto de Venta: El Vendedor podrá buscar libros por código de barras, ISBN, título o autor e ir agregándolos al detalle de la venta.
•	RF3.2 - Cálculo Automático de Totales: El sistema debe calcular el subtotal, aplicar descuentos globales o por ítem si corresponden, e indicar el total a pagar en tiempo real.
•	RF3.3 - Registro de Formas de Pago: El Vendedor podrá seleccionar el medio de pago (Efectivo, Tarjeta de Débito, Tarjeta de Crédito, Transferencia) y registrar pagos mixtos.
•	RF3.4 - Emisión de Comprobante: Al confirmar la venta, el sistema debe descontar automáticamente las unidades del inventario y permitir la impresión o generación en PDF del comprobante de venta.	
•	RF3.5 - Anulación de Ventas: El Administrador podrá anular una venta registrada, reintegrando de forma automática el stock al inventario.
Reportes e Informes
•	RF4.1 - Reporte de Ventas por Período: Generar informes de facturación filtrados por rango de fechas (diario, semanal, mensual) y por vendedor.
•	RF4.2 - Reporte de Ranking de Ventas: Visualización de los libros más vendidos (bestsellers) en un determinado rango de tiempo.
•	RF4.3 - Reporte de Inventario y Valorización: Reporte con el valor total del stock almacenado (a precio de costo y precio de venta).
3.2 Requisitos No Funcionales (RNF)
Rendimiento
•	RNF1.1: El tiempo de respuesta de las consultas en pantalla (búsqueda de libros, agregar al carrito) no debe superar los 1.5 segundos.
•	RNF1.2: La generación e impresión de un comprobante de venta debe procesarse en un tiempo máximo de 2 segundos.
Seguridad
•	RNF2.1: Las contraseñas de los usuarios deben guardarse en la base de datos aplicando algoritmos de hash seguros (p. ej., BCrypt o SHA-256 con Salt).
•	RNF2.2: Todas las operaciones críticas (altas, bajas, modificación de precios y anulaciones) deben quedar registradas en una tabla de auditoría con fecha, hora y usuario.
Usabilidad
•	RNF3.1: La interfaz gráfica debe diseñarse respetando un patrón visual claro, intuitivo y estandarizado, permitiendo operar la pantalla de ventas principalmente mediante el teclado (atajos de teclado para acelerar el cobro).
Concurrencia y Disponibilidad
•	RNF4.1: El sistema y la base de datos deben soportar un mínimo de 5 usuarios concurrentes conectados simultáneamente en la red local sin pérdida de integridad de datos.
3.3 Casos de Uso Clave
Caso de Uso 1: Registrar Venta
•	Actor Principal: Vendedor.
•	Precondición: El Vendedor ha iniciado sesión en el sistema y se encuentra en la pantalla de ventas.
•	Flujo Principal:
1.	El Vendedor escanea el código de barras o busca el libro por título/ISBN.
2.	El sistema valida el stock disponible y muestra el producto, precio y datos en la lista de la compra.
3.	El Vendedor repite los pasos 1 y 2 para todos los productos requeridos.
4.	El sistema actualiza en tiempo real el monto total.
5.	El Vendedor selecciona la forma de pago ingresada por el cliente y presiona "Finalizar Venta".
6.	El sistema descuenta las unidades del inventario, guarda la transacción en la base de datos y genera el comprobante de compra.
•	Flujo Alternativo (Stock insuficiente): En el paso 2, si la cantidad solicitada supera el stock actual, el sistema emite una advertencia impidiendo agregar más unidades de las disponibles.
Caso de Uso 2: Ajuste de Stock por Ingreso de Mercancía
•	Actor Principal: Repositor.
•	Precondición: El Repositor está autenticado en el módulo de inventario.
•	Flujo Principal:
1.	El Repositor busca el libro a actualizar mediante ISBN o SKU.
2.	Selecciona la opción "Ingreso de Stock".
3.	Introduce la cantidad de unidades recibidas y la nota de pedido/proveedor.
4.	Confirma la operación.
5.	El sistema suma la cantidad al stock actual y registra el movimiento en el historial de inventario.
4. Apéndices
4.1 Glosario de Términos
•	Baja Lógica: Marcado de un registro en la base de datos como "inactivo" o "eliminado" sin borrarlo físicamente, preservando la integridad referencial de los datos históricos.
•	Mapeo Objeto-Relacional (ORM): Herramienta técnica (como Entity Framework o Dapper) utilizada en C# para mapear las tablas de SQL Server a clases y objetos en el código.
4.2 Referencias Técnicas y Entorno Recomendado
•	IDE: Microsoft Visual Studio Community / Professional (versión 2022 en adelante).
•	Framework: .NET 8.0 Windows Desktop App o .NET Framework 4.8.
•	Motor BD: Microsoft SQL Server Express 2019 / 2022.
•	Herramientas de Reportes: Microsoft Reporting Services (RDLC), Crystal Reports o librerías de generación PDF (e.g., QuestPDF, iTextSharp).
4.3 Diagrama Entidad-Relación (DER)
El modelo de datos del sistema se compone de 9 tablas organizadas en tres dominios funcionales: Seguridad, Catálogo/Inventario y Ventas/Compras.

4.3.1 Modelo Conceptual
El modelo se organiza en tres dominios funcionales:
Dominio	Entidades principales
Seguridad y Usuarios	Rol, Usuario, Auditoría
Catálogo e Inventario	Libro, Autor, Editorial, Categoría, MovimientoStock, AlertaStock
Ventas y Reportes	Venta, DetalleVenta, Pago, Comprobante, AnulacionVenta

4.3.2 Diagrama ER
 

4.3.3 Diccionario de datos
Tabla	Campo	Tipo	Restricción
roles	id_rol	INT	PK, IDENTITY
	nombre_rol	VARCHAR(50)	NOT NULL, UNIQUE
usuarios	id_usuario	INT	PK, IDENTITY
	nombre	VARCHAR(100)	NOT NULL
	apellido	VARCHAR(100)	NOT NULL
	mail	VARCHAR(150)	NOT NULL, UNIQUE
	password_hash	VARBINARY(256)	NOT NULL
	username	VARCHAR(50)	NOT NULL, UNIQUE
	id_rol	INT	FK → roles(id_rol)

📚 Dominio: Catálogo e Inventario
Tabla	Campo	Tipo	Restricción
generos	cod_genero	INT	PK, IDENTITY
	descripcion	VARCHAR(80)	NOT NULL
libros	id_libro	INT	PK, IDENTITY
	ISBN	VARCHAR(20)	NOT NULL, UNIQUE
	nombre	VARCHAR(250)	NOT NULL
	stock	INT	DEFAULT 0, CHECK ≥ 0
	precio	DECIMAL(10,2)	NOT NULL, CHECK ≥ 0
	cod_genero	INT	FK → generos(cod_genero)
proveedores	id_proveedor	INT	PK, IDENTITY
	cuit	VARCHAR(15)	NOT NULL, UNIQUE
	descripcion	VARCHAR(150)	NULL
	direccion	VARCHAR(200)	NULL
	telefono	VARCHAR(30)	NULL

💰 Dominio: Compras
Tabla	Campo	Tipo	Restricción
compras	id_compra	INT	PK, IDENTITY
	fecha_compra	DATETIME	DEFAULT GETDATE()
	total_compra	DECIMAL(12,2)	NOT NULL
	id_proveedor	INT	FK → proveedores(id_proveedor)
compra_detalles	id_detalle_compra	INT	PK, IDENTITY
	id_compra	INT	FK → compras(id_compra)
	id_libro	INT	FK → libros(id_libro)
	cantidad	INT	NOT NULL, CHECK > 0
	precio_unitario	DECIMAL(10,2)	NOT NULL
	subtotal	DECIMAL(12,2)	NOT NULL

🛒 Dominio: Ventas
Tabla	Campo	Tipo	Restricción
ventas	id_venta	INT	PK, IDENTITY
	fecha_vta	DATETIME	DEFAULT GETDATE()
	total_vta	DECIMAL(12,2)	NOT NULL
	metodo_id	INT	FK → metodos_pago(id_metodo)
	id_usuario	INT	FK → usuarios(id_usuario)
venta_detalles	id_detalle_venta	INT	PK, IDENTITY
	id_venta	INT	FK → ventas(id_venta)
	id_libro	INT	FK → libros(id_libro)
	cantidad	INT	NOT NULL, CHECK > 0
	precio_unitario	DECIMAL(10,2)	NOT NULL
	subtotal	DECIMAL(12,2)	NOT NULL
metodos_pago	id_metodo	INT	PK, IDENTITY
	nombre	VARCHAR(50)	NOT NULL, UNIQUE

3.4.4 Relaciones y Carnalidad
Relación	Cardinalidad	Descripción
ROL → USUARIO	1:N	Un rol agrupa muchos usuarios.
USUARIO → AUDITORIA	1:N	Un usuario genera múltiples registros de auditoría.
USUARIO → VENTA	1:N	Un vendedor registra muchas ventas.
USUARIO → MOVIMIENTO_STOCK	1:N	Un repositor realiza muchos movimientos.
USUARIO → ANULACION_VENTA	1:N	Un admin autoriza muchas anulaciones.
AUTOR → LIBRO	1:N	Un autor puede tener varios libros.
EDITORIAL → LIBRO	1:N	Una editorial publica varios libros.
CATEGORIA → LIBRO	1:N	Una categoría agrupa varios libros.
LIBRO → MOVIMIENTO_STOCK	1:N	Un libro tiene historial de movimientos.
LIBRO → DETALLE_VENTA	1:N	Un libro aparece en muchos detalles de venta.
LIBRO → ALERTA_STOCK	1:N	Un libro puede generar varias alertas.
PROVEEDOR → COMPRA	1:N	Un proveedor suministra muchas compras.
COMPRA → DETALLE_COMPRA	1:N	Una compra tiene varios ítems.
VENTA → DETALLE_VENTA	1:N	Una venta tiene varios ítems.
VENTA → PAGO	1:N	Una venta puede tener pagos mixtos.
VENTA → COMPROBANTE	1:1	Cada venta emite un comprobante.
VENTA → ANULACION_VENTA	1:N	Una venta puede tener una o más anulaciones (histórico).

3.4.5 Reglas de Negocio en el DER
1.	RF2.3 / RNF2.2 → La tabla ALERTA_STOCK y MOVIMIENTO_STOCK registran automáticamente cada variación de stock con trazabilidad completa (usuario, fecha, motivo).
2.	RF3.4 → Al confirmar una venta se inserta en VENTA, DETALLE_VENTA, PAGO y COMPROBANTE, y se descuenta stock actualizando LIBRO.stock_actual + insertando en MOVIMIENTO_STOCK.
3.	RF3.5 → La anulación inserta en ANULACION_VENTA, cambia VENTA.estado = 'ANULADA' y reintegra stock vía MOVIMIENTO_STOCK tipo ANULACION.
4.	RF1.2 → La baja lógica se implementa con el campo activo = 0 en USUARIO, LIBRO, AUTOR, EDITORIAL, CATEGORIA, PROVEEDOR.
5.	RNF2.1 → USUARIO.password_hash + salt cumplen con BCrypt/SHA-256+Salt.
6.	RNF2.2 → AUDITORIA registra todas las operaciones críticas (altas, bajas, modificación de precios y anulaciones).
7.	RF3.3 → PAGO permite múltiples registros por venta para soportar pagos mixtos.

