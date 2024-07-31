# System Testing

## Preguntas

1. ¿Cual es la diferencia en hacer pruebas de integración, con pruebas de sistema?

2. Explica que involucran las pruebas de interoperabilidad

3. Explica que es un buffer overflow

4. ¿Que son los "zero-day attacks"?

5. Explica en que consistía el ataque Log4j

6. De tu proyecto de clase, describe como implementarías las pruebas de sistema

___

## Respuestas

1. Que las pruebas de sistema realizan a un nivel mayor que las de integración.

2. Determinan que tan bien se comporta un produnto entre diferentes sistemas

3. Es cuando la aplicación se le insertan datos con un tamaño más grande al previsto

4. Son ataques que atacan a vulnerabilidades que acaban de ser descubiertas por los desarrolladores.

5. En que alguien hacia una petición en la cual inyectaba codigo de dudosa ética para que este se ejecute en otros servidores/dispositivos. Es relativamente simple.

6. Verificar si los comportammientos funcionan segun lo especificado, que este completo, encontrar tipos de fallas a la hora de mostar los resultados de las peticiones, que satisfaga los requerimientos que dio el profesor.

___

## Guru

Ingresa al siguiente link [What is System Testing?](https://www.guru99.com/system-testing.html) y anota los puntos que consideres importantes.

En base a la plataforma bancaria de Guru99 [demo Guru99](https://demo.guru99.com/V3/) y al [plan de pruebas de sistema](https://docs.google.com/spreadsheets/d/1wglZy_B4UgtLwM-d9nEE9LT_ttMTedWU3ZxyDIkNFsE/edit?usp=sharing), realiza al menos 5 pruebas de sistema de cada categoría (Manager, Customer, WebService) siendo 15 en total. Ademas crea 3 pruebas nuevas y ejecutalas.
