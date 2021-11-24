'''
Desenvolva um sistema que faça o cálculo do imposto a ser pago de vários usuários, seguindo a tabela 
abaixo.
  
O sistema deverá receber o nome de cada usuário e o valor. Depois grave os resultados em um arquivo com 
as seguintes informações de cada usuário: nome, valor informado e imposto a ser pago.
  
Também grave no arquivo quantos usuários pagaram em cada faixa de imposto. Exemplo: 
  
4 usuários na faixa de 7,50%.
  
6 usuários na faixa de 15,00%.
'''
nome=[]
valor=[]
quantias=[0,0,0,0,0]
imp=[]
a=0
alq=[0,7.5,15,22.5,27.5]
sair=False
while not sair:
    menu=int(input("Menu\n(1)\tinserir novo valor\n(2)\tSair\n"))
    if  menu==1:
        nome.append(input("digite seu nome: "))
        valor.append(float(input("digite o valor: ")))
        if valor[a]<0:
            print("valor inválido")
        elif valor[a]<1903.98:
            al=0
            quantias[0]+=1
        elif valor[a]<2826.65:
            al=7.5
            quantias[1]+=1
        elif valor[a]<3751.05:
            al=15
            quantias[2]+=1
        elif valor[a]<4664.68:
            al=22.5
            quantias[3]+=1
        else:
            al=27.5
            quantias[4]+=1
        imp.append(al)
        a+=1
    elif menu==2:
        sair=True
    else:
        print("input inválido")
    
inf={"nome":nome,"valor":valor,"imposto":imp}


arq=open("database.txt", 'w')
arq.write("")
arq.close()

for b in range(len(inf["nome"])):
    g=1
    arq=open("database.txt", 'a')
    arq.write(f"\n\nusuário {b+1}\n")
    arq.close()
    for cada in inf.keys():
        if g==1:
            arq=open("database.txt", 'a')
            arq.write("\nNome: ")
            arq.close()
        elif g ==2:
            arq=open("database.txt", 'a')
            arq.write("\nValor: ")
            arq.close()
        else:
            arq=open("database.txt", 'a')
            arq.write("\nAliquota: ")
            arq.close()
        arq=open("database.txt", 'a')
        arq.write(f"\n{str(inf[cada][b])}\n")
        arq.close()
        g+=1
    
    
arq=open("database.txt", 'a')
arq.write("\n\na quantia de cada aliquota foi: ")
arq.close()

for i in range(len(quantias)):
    arq=open("database.txt", 'a')
    arq.write(f"\n{quantias[i]} usuários na faixa de {alq[i]}%")
    arq.close()