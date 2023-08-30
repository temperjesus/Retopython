dia= input ("Ingrese dia de la semana (L,M,MI,J,V,S,D): ")

Horas = int(input("ingrese la cantidad de horas: "))

Minutos = int(input("ingrese la cantidad de minutos: "))
if dia not in ['L','M','MI','J','V','S','D',] or Horas <0 or Minutos<0 or Minutos >59:
    print("Error: Valor ingresado es incorrecto")
else:
    Total_horas = Horas +(1 if Minutos > 5 else 0)
    if dia in ['L','M','MI']:
        costo= Total_horas* 2.0
    elif dia in['J','V']:
        costo= Total_horas* 2.5
    else:
        costo= Total_horas* 3.0
 
print(end="El costo del estacionamiento es:$%.2f"%costo)