# ------------- Questão 1 -------------
# dolar = int(input("Digite o valor em Dolares: "))
# print(f"O valor em reais é {dolar*3.77} R$")



# ------------- Questão 2 -------------
# tupla_Campeoes = ( [1995, "Suécia", "Noruega"], [1991, "China", "Estados-Unidos"], [1999, "Estados-Unidos", "Estados-Unidos"], [2003, "Estados-Unidos", "Alemanha"], [2007, "China", "Alemanha"], [2011, "Alemanha", "Japão"], [2015, "Canada", "Estados-Unidos"], [2019, "França", "Estados-Unidos"])
# arrumado = sorted(tupla_Campeoes, reverse=True)

# for i in range(5):
#     print(f"Campeão de {arrumado[i][0]}: {arrumado[i][2]}")



# ------------- Questão 3 -------------
# saida = False

# while not saida:
#     print("")
#     print("-----------------------ESCOLHA SEU COMBO-----------------------")
#     print("")
#     print("")
#     print(" COMBO 1")
#     print(" X-Salada (+ Fritas + KS sabores)")
#     print(" Valor: 23,99")
#     print("")
#     print(" COMBO 2")
#     print(" X-Picanha Bacon (+ Fritas + KS sabores)")
#     print(" Valor: 27,99")
#     print("")
#     print(" COMBO 3")
#     print(" X-Calabresa Vinagrete (+ Nuggets + KS sabores)")
#     print(" Valor: 26,99")
#     print("")
#     print(" COMBO 4")
#     print(" X-Frango Salada (+ Aneis de cebola + KS sabores)")
#     print(" Valor: 25,99")
#     print("")
#     print(" COMBO 5")
#     print(" Duplo Cheddar Bacon (+ Fritas + KS sabores)")
#     print(" Valor: 32,99")
#     print("")
#     print(" COMBO KIDS")
#     print(" X-Burguer (+ Batata Sorriso + Coca 200ml ou Suco + Danoninho)")
#     print(" Valor: 16,90")
    
#     combo = int(input("-----------   "))
#     print("")
#     if(combo == 1):
#         print(" O custo de seu lanche eh: 23,99 R$")
#         saida = True
#     elif(combo == 2):
#         print(" O custo de seu lanche eh: 27,99 R$")
#         saida = True
#     elif(combo == 3):
#         print(" O custo de seu lanche eh: 26,99 R$")
#         saida = True
#     elif(combo == 4):
#         print(" O custo de seu lanche eh: 25,99 R$")
#         saida = True
#     elif(combo == 5):
#         print(" O custo de seu lanche eh: 32,99 R$")
#         saida = True
#     elif(combo == 6):
#         print(" O custo de seu lanche eh: 16,90 R$")
#         saida = True
#     else:
#         print("Combo invalido")

# ------------- Questão 4 -------------
# saida = False
# i=0
# lista=[]
# while not saida:
#     sair = 5
#     num = int(input6 + 5("Digite um valor: "))
#     print(f"O valor multiplicado por 2 eh: {num*2}")
#     lista.append(num*2)
#     i=i+1
#     while (sair != 1) and (sair != 2):
#         sair = int(input("Deseja sair?\n(1) SIM\n(2) NÃO\n---------  "))
#         if(sair == 1):
#             saida = True    
            
# print("\n\nValores dobrados: \n",lista)


# ------------- Questão 5 -------------
# try:
#     conta=input("digite a operação desejada separada por espaço: ")
#     num1,op,num2=conta.split(" ")
#     if op=="+":
#         result=int(num1)+int(num2)
#     elif op=="-":
#         result=int(num1)-int(num2)
#     elif op=="*" or op==".":
#         result=int(num1)*int(num2)
#     elif op=="/":
#         result=int(num1)/int(num2)      
#     print(f"o resultado é: {result}")
# except ValueError:
#     print("input inválido")
# except KeyboardInterrupt:
#     print("\nnão é possivel realizar ctrl+c")
# except NameError:
#     print("operador inválido")
# except ZeroDivisionError:
#     print("Não divida por 0")
# except Exception:
#     print("Erro inesperado")


# ------------- Questão 6 -------------
# def cont():
#   num = int(input("Digite o numero que deseja chegar: "))
#   for i in range(num):
#       print(i+1)
#       print("-"*50)

# saida = False
# while not saida:

#     sair = 5
    
#     cont()
    
#     while (sair != 1) and (sair != 2):
#         sair = int(input("Deseja sair?\n(1) SIM\n(2) NÃO\n---------  "))
#         if(sair == 1):
#             saida = True    
            
# ------------- Questão 7 -------------
# f = open("Questao_7.txt", "w")
# f.write("")
# f.close()

# txt = input("Digite o texto que deseja salvar:\n--------  ")

# f = open("Questao_7.txt", "a")
# f.write(txt)
# f.close()




# ------------- Questão 8 -------------

# PULADA

# ------------- Questão 9 -------------
# saida = False
# while not saida:

#     sair = 5
    
#     n = int(input("Verificar numero primo: "))
#     mult=0
#     if(n<0):
#         n = n*-1
    
#     for count in range(2,n):
#         if (n % count == 0):
#             mult += 1
    
#     if(mult==0):
#         print("\nÉ primo")
#         saida = True 
#     else:
#         print("\nNão é primo")
#         print("-"*50)
    
              
# ------------- Questão 10 -------------



# ------------- Inicia a lista

# lista = []

# ------------- define tamanho da lista 

# tam = int(input("tamanho: "))


# ------------- preenche e printa a lista

# for i in range (1,tam+1,1):
#     x = int(input("valor: "))
#     lista.append(x)
# print(lista)


# ------------- ordena a lista me ordem crescente e printa a nova lista

# for i in range(tam):
#     for j in range(tam):
#         if lista[j] > lista[i]:
#             lista[i],lista[j] = lista[j], lista[i]
# print("lista nova: ", lista)










