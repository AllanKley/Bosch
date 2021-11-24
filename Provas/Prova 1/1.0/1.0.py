'''
Implemente um sistema que faça o controle de peças para uma indústria. O sistema receberá as informações 
do usuário de quantas peças foram fabricadas. Você deverá construir um menu com as seguintes opções:

a)      Inserir a quantidade de peças fabricadas, em cada mês do ano. Deverá ser gravado em um arquivo 
        txt.

b)      Visualizar a quantidade de peças em cada mês do ano. Deverá ler do arquivo txt.
  
c)      Emitir um relatório com a quantidade média de peças fabricadas. Deverá ser criado um arquivo 
        txt com o resultado. Exemplo: A quantidade média de peças foram: XX.
'''

pecas=[0,0,0,0,0,0,0,0,0,0,0,0]
sair=False
total=0



arq=open("peças.txt", 'w')
arq.write("\nAs peças produzidas neste ano foram: ")
arq.close()
arq=open("peças.txt", 'a')
i=1
for meses in pecas:
    arq.write(f"\nMês {i}: {meses}")
    i+=1
arq.close()

i=1




while not sair:
    
    
    menu=int(input("Menu:\n(1)\tInserir Quantia de peças\n(2)\tVisualizar Quantias\n(3)\tEmitir relatório\n(4)\tSaida\n"))
    
    
    
    if menu==1:
        try:
            mes=int(input("digite o mês que deseja inserir: "))
            pecas.pop(mes-1)
            pecas.insert((mes-1), input("digite o numero de peças: "))
                
            arq=open("peças.txt", 'w')
            arq.write("\nAs peças produzidas neste ano foram: ")
            arq.close()
            arq=open("peças.txt", 'a')
            i=1
            for meses in pecas:
                arq.write(f"\nMês {i}: {meses}")
                i+=1
            arq.close()
        except:
            continue
        
        
        
        
    elif menu==2:
        arq=open("Peças.txt", 'r')
        print(arq.read())
        arq.close()
    elif menu==3:
        for valor in pecas:
            total+=int(valor)
        media=total/12
        print(f"A quantidade média de peças fabricadas foram: {media}.")
        arq2=open("Médias.txt", 'w')
        arq2.write(f"A quantidade média de peças fabricadas foram: {media}.")
        arq2.close
   
    elif menu==4:
        sair=True
    
    else:
        print("input inválido")
    
