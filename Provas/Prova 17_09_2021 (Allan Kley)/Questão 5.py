from random import randrange
joq =["pedra", "papel", "tesoura"]
sair=False
while not sair:
    i=int(input("Digite 1 para continuar jogando e 2 para sair: "))
    if i == 1:
        jogada=int(input("Escolha sua jogada:\n(1)\tPedra\n(2)\tPapel\n(3)\tTesoura\n"))
        comp = randrange(1,4)
        if jogada == 1 and comp == 1:
            vit = "Empate"
        elif jogada==1 and comp == 2:
            vit = "Derrota"
        elif jogada==1 and comp == 3:
            vit = "Vitória"
        elif jogada==2 and comp == 1:
            vit = "Vitória"
        elif jogada==2 and comp == 2:
            vit = "Empate"
        elif jogada==2 and comp == 3:
            vit = "Derrota"            
        elif jogada==3 and comp == 1:
            vit = "Derrota"
        elif jogada==3 and comp == 2:
            vit = "Vitória"
        elif jogada==3 and comp == 3:
            vit = "Empate"   
        else:
            print("input inválido")
        print(f"Jogada da máquina: {joq[comp-1]}")
        print(vit," !!")
    elif i == 2:
        sair=True
    else:
        print("input inválido")
