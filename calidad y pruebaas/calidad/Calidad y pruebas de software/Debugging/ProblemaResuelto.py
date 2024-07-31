""" La idea primero es poder usar el whyle para añadir la funcion de que se repita la lista de
articulos para darle al usuario la opcion de escoger varios articulos y no solo uno
Además poder suma y almacenar el precio de los productos en un total con los descuentos aplicados """

opcion=0
menu = True                     # ========== Agrego variable menu ==========

teclado_Gamer=20000
desc_teclado_Gamer = 0.15       # ========== Agrego variable del descuento para cada articulo ==========

tarjeta_Video=25000
desc_tarjeta_Video = 0.08

monitor_LCD=30000
desc_monitor_LCD = 0.05

motherboard=40000
desc_motherboard = 0.03

Total_sin_desc = 0              # ========== Agrego 2 variables ==========
Total_con_desc = 0


print('Articulos en desc:')
print('1. Teclado Gamer (20000 colones)')
print('2. Tarjeta de Video (25000 colones)')
print('3. Monitor LCD (30000 colones)')
print('4. Tarjeta Madre (40000 colones)')
                                            # ========== Agrego opcion salir ==========
print('5. Salir')

# while opcion<6:

while menu == True:              # ========== Modifico el while ==========
    opcion = int(input('\nDigite el numero del articulo que desea: '))      # ========== Se sube la peticion arriba del while ==========
    
    if opcion == 1:
        desc=teclado_Gamer * desc_teclado_Gamer     # ========== Uso variable del descuento del producto ==========
        Total_sin_desc += teclado_Gamer     # ========== Uso variable del total sin descuento ==========
        Total_con_desc += teclado_Gamer-desc       # ========== Uso1 variable del total con descuento y modifico ==========
        # resta=teclado_Gamer-desc
                                        # ========== Modifico el print ==========
    # print('El precio a pagar por el articulo es: ', resta)
    # print('Con un desc del 15%')
        print(f"El precio original del producto es de {teclado_Gamer} colones pero tiene un descuento del {desc_teclado_Gamer*100}%\n"
        f"El total hasta ahora es de ${Total_con_desc} en vez de ${Total_sin_desc} gracias a los descuentos")
        #break                          # ========== Se elimina el break ==========

    elif opcion == 2:
        desc=tarjeta_Video * desc_tarjeta_Video
        Total_sin_desc += tarjeta_Video
        Total_con_desc += tarjeta_Video - desc
        print(f"El precio original del producto es de {tarjeta_Video} colones pero tiene un descuento del {desc_tarjeta_Video*100}%\n"
        f"El total hasta ahora es de ${Total_con_desc} en vez de ${Total_sin_desc} gracias a los descuentos")
    
    elif opcion==3:
        desc=monitor_LCD * desc_monitor_LCD
        Total_sin_desc += monitor_LCD
        Total_con_desc += monitor_LCD - desc
        print(f"El precio original del producto es de {monitor_LCD} colones pero tiene un descuento del {desc_monitor_LCD*100}%\n"
        f"El total hasta ahora es de ${Total_con_desc} en vez de ${Total_sin_desc} gracias a los descuentos")

    elif opcion==4:
        desc=motherboard * desc_motherboard
        Total_sin_desc += motherboard
        Total_con_desc += motherboard - desc
        print(f"El precio original del producto es de {motherboard} colones pero tiene un descuento del {desc_motherboard*100}%\n"
        f"El total hasta ahora es de ${Total_con_desc} en vez de ${Total_sin_desc} gracias a los descuentos")

    elif opcion==5:
        print(f"El total de ${Total_con_desc} en vez de ${Total_sin_desc} usted ahorro {Total_sin_desc-Total_con_desc} colones!\n")
        break

    else:
        print('Error, opcion incorrecta')
        print('Intentelo de nuevo')