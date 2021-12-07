nome = input("digite seu nome: ")
dias=float(input("informe a quantidade de dias em que faz o curso: "))
tipo=input("informe o tipo de curso: B-básico; I-Intermediário e A-Avançado\n")

if(tipo=="B"):
    tot=(dias*7)*15
elif(tipo=="I"):
    tot=(dias*8,5)*20
elif(tipo=="A"):
    tot=(dias*10)*25
else:
    print("tipo inválido")

print("o valor a ser pago por",nome,"é:",tot,"reais")