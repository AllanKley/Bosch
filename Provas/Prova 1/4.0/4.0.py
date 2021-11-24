'''
Leia o arquivo CSV com os top 1000 melhores filmes do IMDB (Link: 
https://raw.githubusercontent.com/peetck/IMDB-Top1000-Movies/master/IMDB-Movie-Data.csv) e faça as 
seguintes operações:
  
a) Crie um DataFrame e organize os filmes por ordem alfabética. Grave o resultado em um novo CSV.
  
b) Crie um DataFrame para todos os filmes que a receita esteja zerada. Grave o resultado em um novo CSV.
  
c) Crie um DataFrame para os 10 filmes mais lucrativos e os 10 filmes menos lucrativos (desconsiderando 
   os com receita zerada). Grave o resultado em um novo arquivo CSV.

d) Crie um DataFrame apenas com as colunas Título, Diretor e Ano. Grave o resultado em um arquivo CSV.
'''
import pandas as pd
filmes = pd.read_csv("filmes.txt", sep=",")

alfab= filmes.sort_values(['Title'])
zerado = filmes.loc[filmes["Revenue (Millions)"]==0]
filtro= filmes[["Title", "Director", "Year"]]
filtro2= filmes[["Rank","Title", "Revenue (Millions)"]]
semzero=filtro2.loc[filmes["Revenue (Millions)"]!=0]
orden=semzero.sort_values(["Revenue (Millions)"])
orden2=pd.concat([orden.head(10),orden.tail(10)])


alfab.to_csv("alfabético.csv")
filtro.to_csv("filtrado.csv")
zerado.to_csv("zerado.csv")
orden2.to_csv("mais e menos lucraticos.csv")