# Distribucion de componentes

En este ejemplo, tenemos una clase de componente que representa un componente genérico que se puede usar en diferentes máquinas. También tenemos una clase Machine que representa una máquina física que puede albergar componentes.

En el método Main(), creamos un objeto Component y luego lo distribuimos a dos objetos Machine diferentes. Luego usamos el objeto Componente en ambas máquinas.

La clase Component tiene un método Use() que imprime un mensaje en la consola. La clase Machine tiene un método UseComponent() que llama al método Use() en el objeto Component que aloja.

Este es un ejemplo simple de cómo distribuir componentes en C#. En una aplicación más compleja, es posible que tenga varios tipos de componentes y que deba distribuirlos a diferentes máquinas en función de sus requisitos específicos.