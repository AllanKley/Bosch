nota=float(input("digite sua nota: "))

if(nota<0 or nota>10):
    print("nota invalida")
elif(nota<5):
    print("nota vermelha")
elif(nota>8):
    print("parabéns")
else:
    print("nota azul")