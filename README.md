# Desing-Patterns-DI-Dependecy-Inyections
Concepto Basico programacion orientada a objetos, Inyeccion de dependencias

## Concepto Inyeccion de dependencias
Con un ejemplo basico, vamos a ver que es la inyeccion de dependencias. Un patrón que se utiliza en la programacion orientada a Objetos, que se basa en que
cuando en un objeto depende de otro no debe depender de la implementacion de ese objeto si no de una abstraccion del mismo. 
Con este ejemplo se pretende enteder dicho patron para ello se ha creado una aplicacion de consola desde 0 con una clase Main vacia que se ira evolucionando 
hasta llegar a implementar un patron de inyeccion de dependencias. 
Para entender este patron es recomentable revisar los commits con los comentarios y la evolucion del proyecto.

## Eliminacion de instrucciones New

La primera consecuencia a tener en cuenta en tu código es que las instancias inyectadas no se generarán desde tu código fuente, se hara por reflexión o mediante
algun framework.
Al usar DI siempre tratarás con un interfaz y para usar una instancia de una clase, hay que invocar al repositorio de dependencias que se encargara de gestionar 
que objeto se desea instanciar y generarlo. (En este ejemplo se usara una Factoria )

## Ventajas de usar la Inyeccion de depencias
* Minimmizar las dependencias entre cada clase/modulo 
* Minimizar el acoplamiento 
* Hacer el codigo mas testeable ya que permite el uso de mocks.
* Hacer la aplicacion mas sencilla de extender

## Desventajas de usar la Inyeccion de depencias
* Perdida de la orientacion de la arquitectura en tiempo de diseño:
Una gran ventaja de ciertos IDEs en la actualidad es de poder acceder rápidamente al código fuente de las clases y en modificar el código mientras estás depurando. 
Al usar inyección de dependencias se pierden estas características.Por una parte, al trabajar con interfaces y no con la clase directamente, no puedes saber en tiempo
de diseño que estás ejecutando así que se pierde la visión de todo el código fuente para encontrar el error.

* La configuracion es mas costosa
La configuración también es una tarea a añadir en el caso de utilizar inyección de dependencias. Al hacer la inyección se traslada la responsabilidad de la instanciación
de un código imperativo a un código declarativo.Esta declaración puede ser de muchas formas como xml, anotaciones, ficheros de texto, almacenándola en la base de datos,
etc. Dependerá del framework o de nuestro propio algoritmo de inyección el que se use una forma u otra.
