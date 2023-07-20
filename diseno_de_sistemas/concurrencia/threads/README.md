# Threads
En este ejemplo, creamos dos subprocesos que llaman al método PrintNumbers(). El método PrintNumbers() simplemente imprime los números del 1 al 10. El método Main() crea los dos subprocesos y luego los inicia. El método Main() también espera a que finalicen los subprocesos antes de salir del programa.

Este ejemplo muestra cómo manejar la simultaneidad en C#. Al crear dos hilos, podemos ejecutar el método PrintNumbers() dos veces al mismo tiempo. Esto nos permite imprimir los números del 1 al 10 el doble de rápido.