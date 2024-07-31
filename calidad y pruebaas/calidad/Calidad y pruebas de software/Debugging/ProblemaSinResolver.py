opcion=0
teclado_Gamer=20000
tarjeta_Video=25000
monitor_LCD=30000
motherboard=40000

print('Articulos en descuento:')
print('1. Teclado Gamer (20000 colones)')
print('2. Tarjeta de Video (25000 colones)')
print('3. Monitor LCD (30000 colones)')
print('4. Tarjeta Madre (40000 colones)')

while opcion<6:
    opcion= int(input('\nDigite el numero del articulo que desea: '))
    print()

    if opcion==1:
        descuento=teclado_Gamer*0.15
        resta=teclado_Gamer-descuento
        print('El precio a pagar por el articulo es: ', resta)
        print('Con un descuento del 15%')
        break;
    elif opcion==2:
        descuento=tarjeta_Video*0.08
        resta=tarjeta_Video-descuento
        print('El precio a pagar por el articulo es: ', resta)
        print('Con un descuento del 8%')
        break;
    elif opcion==3:
        descuento=monitor_LCD*0.05
        resta=monitor_LCD-descuento
        print('El precio a pagar por el articulo es: ', resta)
        print('Con un descuento del 5%')
        break;
    elif opcion==4:
        descuento=motherboard*0.03
        resta=motherboard-descuento
        print('El precio a pagar por el articulo es: ', resta)
        print('Con un descuento del 3%')
        break;
    else:
        print('Error, opcion incorrecta')
        print('Intentelo de nuevo')