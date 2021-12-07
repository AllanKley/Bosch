peso=float(input("digite seu peso em kilogramas: "))

altura=float(input("digite sua altura em metros: "))

imc=(peso)/(altura**2)

if imc<20:
    print("abaixo do peso")
elif imc<=25:
    print("peso normal")
elif imc<=30:
    print("acima do peso")
else:
    print("obesidade")