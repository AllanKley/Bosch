# arq = open("S:/COM\Human_Resources/01.Engineering_Tech_School/02.Internal/10 - Aprendizes/5 - Desenvolvimento de Sistemas/Arquivos a serem disponibilizados/datas.csv", "r")
# print(arq.read())

import pandas as pd
df = pd.read_csv("S:/COM\Human_Resources/01.Engineering_Tech_School/02.Internal/10 - Aprendizes/5 - Desenvolvimento de Sistemas/Arquivos a serem disponibilizados/datas.csv", ',', usecols=['country-year'])

# print(df)

lista = []
lista = df.values.tolist()

for i in range(len(lista)):
    print(lista[i])

