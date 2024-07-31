[![Open in Visual Studio Code](https://classroom.github.com/assets/open-in-vscode-f059dc9a6f8d3a56e377f745f24479a46679e63a5d9fe6f495e02850cd0d8118.svg)](https://classroom.github.com/online_ide?assignment_repo_id=7222416&assignment_repo_type=AssignmentRepo)
# Data Flow Testing
## Actividades
1. Lee el documento "Data Flow Testing"
2. Define algún algoritmo de búsqueda de algún arreglo que usaras para el resto de actividades
3. Dibuja el DFG (Data Flow Graph) de dicho algoritmo
4. Asumiendo que el arreglo no esta vació, encuentra un path que no sea factible  

    Inicializando: [5,6,9,11,3], 1)
    Path_1: 1-2-3(F)-8
    El numero 1 no esta en el array y por lo tanto el resultdo es none por lo que se considera no factible. 

5. Identifica una anomalía de "Data Flow" en el programa "binSearch.py"  

    No encontré ninguna

6. Del grafo generado en el punto 3, encuentra el conjunto de paths completos (entrada a salida) que satisfaga el criterio "all-defs" con respecto a dos variables de tu elección  

    Definition Clear Path: Path donde el nodo inicial es el único que define una variable x.

    Path_1: 1-2-3(T)-4-7-3-8  
    El nodo 2 define la variable global "i" se hace un p-use en la transición al nodo 4 y un c-use en el nodo 7

    Path_2: 1-2-3(T)-4-5-6  
    El nodo 1 define la variable global "elemento" se hace un p-use en la transicion al nodo 5 pero no se realiza ningun c-use.

7. Para cada path identificado, deriva los "path predicate expressions"
    
    path_1:   
    i < len(array) == true ..........(1)  
    array[i] == elemento == true ....(2)
    
    path_2:  
    ~(i < len(array) == true ..........(1)

    path_3:   
    i < len(array) == true ..........(1)  
    ~(array[i] == elemento) == true ....(2)  
    i < len(array) == true ..........(3)  
    array[i] == elemento == true ....(4)
    
    
8. Resuelve las expresiones para generar datos de entrada y computalos para obtener la salida esperada
  
    path_1:  
    0 < 5 == true ..........(1)  
    array[0] == 1 == true ....(2)

    path_2:  
    ~(5 < 5 == true ..........(1)
    
    path_3:  
    2 < 5 == true ..........(1)  
    ~(array[2] == 1) == true ....(2)  
    3 < 5 == true ..........(3)  
    array[3] == 1 == true ....(4)  
    
9. Averigua para cada path si es factible o no
Si todos tus paths son factibles, intenta encontrar un path extra que no lo sea  

    Inicializando: [5,6,9,11,3], 1)
    Path_1: 1-2-3(F)-8
    El numero 1 no esta en el array y por lo tanto el resultdo es none por lo que se considera no factible.

10. Genera la prueba unitaria de dicho algoritmo con los datos de entrada que generaste

11. ¿Puedes introducir algún error a tu código de modo que no sea detectado por las pruebas unitarias?  

    Mandando un array vacío y un numero que no este en el array

## Estados
Genera una funcion el cual recibe un arreglo de modificaciones de alguna variable, las cuales son 3: {"r": "referenciado", "d": "definido", "u": "indefinido"} y devuelve un booleando representado si existe alguna anomalía o no.

Ejemplo 1:
- Entrada: [u, d, r, r, u]
- Salida: False

Ejemplo 2:
- Entrada: [u, d, d, r, u]
- Salida: True

Ejemplo 3:
- Entrada: [u, d, r, d, u]
- Salida: True

## Puntos bonus
Contesta los siguientes puntos para puntos bonus:
1. ¿Cual es la diferencia entre CFT y DFT?

    En control flow testing los criterios son usados en una etapa previa mientas que en el Data flow testing son usados en una siguiente etapa, ademas en data flow testing se enfoca en las anomalias que puede presentar nuestro codigo y el uso de estados en los que puede estar cierta anomalía.

2. Explica porque encontrar una anomalía no necesariamente implica que existe alguna falla

    No existe una falla porque al encontrar una anomalía el codigo sigue funcionando sin presentar errores.
