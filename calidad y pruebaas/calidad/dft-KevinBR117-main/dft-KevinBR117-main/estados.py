def anomalia(lista_estados):
    boolean = True
    for i in range (len(lista_estados)):
        if lista_estados[i] == 'u':
            if (i+1) < len(lista_estados):#verificar si quedan elementos antes de avanzar 
                if lista_estados[i+1] == 'r':
                    boolean = False
        elif lista_estados[i] == 'd':
            if (i+1) < len(lista_estados):
                if (lista_estados[i+1] == 'd' or lista_estados[i+1] == 'u'):
                    boolean = False
        else:#estamos en el estado referenciado
            boolean = True
    return boolean


if __name__ == "__main__":
    print(anomalia(['r','u','r']))
    print(anomalia(['u']))
    print(anomalia(['u','u','d','d']))
    print(anomalia(['d','r']))