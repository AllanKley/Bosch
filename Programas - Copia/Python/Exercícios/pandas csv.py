import pandas as pd
'''
dados={
       "nome":["allan", 'carlo', 'murilo', "nicholas", 'gabriel', 'moll', 'alison', 'nathan', 'thiago','bruno'],
       "ip":[61561,651561,651561,651561,65561,651561,651561,56156156,56156156,11861861],
      "idade":[17,17,17,17,19,19,19,18,18,20]
       }
'''

vendas={
        "valor": [654,98,235,168,754,613,684,218,357,147],
        "quantidade": [1,5,7,8,9,12,6,7,3,2],
        "data venda": [1994,2000,2012,2003,2021,2022,2020,2023,2035,2034]
        }

"""
#mostrar 8 primeiros
print(pd.DataFrame(dados).head(8))

#data=pd.DataFrame(dados)
#print(data.head(8))
"""

"""
#mostrar todos com 18 anos de idade
data=pd.DataFrame(dados)
print(data.loc[data["idade"]==18])
"""

"""
#idades mais frequentes
data=pd.DataFrame(dados)
print(data["idade"].value_counts().head(3))
"""

"""
#organizar por ip
data=pd.DataFrame(dados)
print(data.sort_values(by="ip"))
"""

"""
data=pd.DataFrame(dados)
print(data["idade"].mean())
"""

'''
titulo=[]
ano=[]
saida=False

while not saida:
    i=int(input("Menu\n(1)\tnovo titulo\n(2)\tSair\n"))
    if i==1:
        titulo.append(input("digite o título: "))
        ano.append(int(input('digite o ano: ')))
    if i==2:
        saida=True
    else:
        print("input invalido")
        
        
dados={"titulo": titulo,"ano": ano}
data=pd.DataFrame(dados)    
print("\n",data.loc[data["ano"]>data["ano"].mean()])
'''

"""
dados = pd.read_csv("dados csv.csv", sep=";")
print(dados.tail(int(len(dados)/2)))

"""

'''
todo = pd.DataFrame(vendas)
novas = todo.loc[todo["data venda"]>2020]
novas.to_csv("vendas.csv")
'''