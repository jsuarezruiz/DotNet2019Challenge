# DotNet2019 Challenge

El próximo 19 de Junio tendrá lugar en Madrid la segunda edición de la **DotNet 2019** organizada por Plain Concepts, el evento técnico con tecnologías Microsoft más importante de España.

![DotNet2019](images/dotnet2019.png)

## El reto

En este repositorio puedes encontrar un sencillo pero interesante ejemplo con **Xamarin.Forms**.

![Movies](images/movies.png)

El ejemplo hace uso de:
* XAML
* MVVM
* Data Binding
* Converters
* Estilos
* Etc

Sin embargo, cuenta con más de una docena de mejoras sencillas pero que sumadas una a una tienen un impacto en el **rendimiento** de la aplicación.

El reto es sencillo. Encuentra al menos 3 de las posibles mejoras de rendimiento y modifica el ejemplo abriendo una nueva Pull Request en este repositorio.

**NOTA:** _Se han añadido algunos problemas adrede. A pesar de usar MVVM y algunas buenas prácticas, NO tomes este ejemplo como referencia._

## El premio

Una **entrada** para la DotNet 2019!.

## Las reglas

Tan sencillo como:
* Haz un fork del repositorio.
* Ejecuta, prueba y piensa.
* Añade 3 cambios que impacten en el rendimiento.
* Envía una PR con los cambios.

Tienes hasta el **19 de Mayo** para participar. El ganador será el primero que envíe una PR válida (cuente con 3 mejoras de rendimiento).

Sencillo, ¿verdad?.

#### Espero tu participación!

## Ganador y la solución al reto

Tras varias PRs, tenemos ya ganador: **[Miguel Ángel Martín Hernández](https://github.com/MookieFumi)**

Enhorabuena!

Con el reto concluido, es momento de indicar todas las posibles mejoras:
* La **versión de Xamarin.Forms** es antigua. Hemos recibido varias mejoras en rendimiento (Fast Renderers, etc), por lo que es recomendable actualizar.
* En el arranque de la App tenemos varias **dependencias** que NO usamos (SkiaSharp, FFImageLoading, etc.). Es recomendable no contar con dependencias innecesarias.
* No se usa **XAMLC** (Compilación de XAML). La mejora es considerable y solo necesita una única línea.
* **Bindings**. Tenemos Bindings con errores y/o innecesarios. Como regla general, evitar Bindings innecesarios y errores.
* **Layouts**. Hay Layouts innecesarios y otros que podríamos cambiar para conseguir el mismo resultado con un mejor rendimiento.
* **Controles**. Crear un HorizontalList personalizado teniendo BindableLayouts es innecesario. Teniendo un número no determinado de elementos en cada listado, usar **CollectionView** es una mejora.
* **Imágenes**. Fuente habitual de mejoras en rendimiento. Usar FFImageLoading y GlideX es una mejora considerable.
* **Recursos**. Hay estilos que no se usan en App.xaml.cs y en algunos casos podemos reutilizar y optimizar más. 
* **HttpClient**. Creamos una instancia cada vez que hacemos una petición. Reutilizar la misma instancia es mucho más eficiente.
* **Otros**. Hay muchas otros mini-cambios que afectan al rendimiento. Por ejemplo: Uso de Stream en lugar de obtener cadenas al tratar los datos de las peticiones Http, etc.

De todos estos puntos (y otros), veremos detalles, datos y gráficas en la charla de la **DotNet 2019**, espero veros allí!.