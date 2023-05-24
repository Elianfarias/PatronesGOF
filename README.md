Patrones GOF
Creacionales :

* Factory Method : Utiliza el Factory Method cuando quieras ahorrar recursos del sistema mediante la reutilización de objetos existentes en lugar de reconstruirlos cada vez.

    Pros : 
    * Evitas un acoplamiento fuerte entre el creador y los productos concretos.
    * Principio de responsabilidad única. 
    * Puedes mover el código de creación de producto a un lugar del programa, haciendo que el código sea más fácil de mantener.
    * Principio de abierto/cerrado. Puedes incorporar nuevos tipos de productos en el programa sin descomponer el código cliente existente.

    Contra :
    * Puede ser que el código se complique, ya que debes incorporar una multitud de nuevas subclases para implementar el patrón. La situación ideal sería introducir el patrón en una jerarquía existente de clases creadoras.

* Singleton : Singleton es un patrón de diseño creacional que nos permite asegurarnos de que una clase tenga una única instancia, a la vez que proporciona un punto de acceso global a dicha instancia.

Utiliza el patrón Singleton cuando una clase de tu programa tan solo deba tener una instancia disponible para todos los clientes

    Pros : 
    * Puedes tener la certeza de que una clase tiene una única instancia.
    * Obtienes un punto de acceso global a dicha instancia.
    * El objeto Singleton solo se inicializa cuando se requiere por primera vez.

    Contras : 
    * Vulnera el Principio de responsabilidad única. El patrón resuelve dos problemas al mismo tiempo.
    * El patrón Singleton puede enmascarar un mal diseño, por ejemplo, cuando los componentes del programa saben demasiado los unos sobre los otros.
    * El patrón requiere de un tratamiento especial en un entorno con múltiples hilos de ejecución, para que varios hilos no creen un objeto Singleton varias veces.
    * Puede resultar complicado realizar la prueba unitaria del código cliente del Singleton porque muchos frameworks de prueba dependen de la herencia a la hora de crear objetos simulados (mock objects). Debido a que la clase Singleton es privada y en la mayoría de los lenguajes resulta imposible sobrescribir métodos estáticos, tendrás que pensar en una manera original de simular el Singleton. O, simplemente, no escribas las pruebas. O no utilices el patrón Singleton.

* Abstract Factory : es un patrón de diseño creacional que nos permite producir familias de objetos relacionados sin especificar sus clases concretas.