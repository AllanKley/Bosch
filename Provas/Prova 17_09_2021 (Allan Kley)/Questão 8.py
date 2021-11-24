
import pandas as pd
from matplotlib import pyplot as plt
filmes = pd.read_csv("netflix_titles.csv", sep=",")
duracao=[]
y2015=0
y2016=0
y2017=0
y2018=0
y2019=0
y2020=0
filmes = filmes.dropna()
brasil = filmes.loc[filmes["country"]=="Brazil"]
filmes= filmes.loc[filmes["country"]=="United States"]
filmes=filmes.loc[filmes["release_year"]>=2015]
filmes=filmes.loc[filmes["release_year"]<=2020]

brasil = brasil.sort_values(['duration'])
print("Filmes mais longos do brasil:\n\n", brasil.tail()[["title"]].to_string(index=False))

for i in filmes["release_year"]:
    if i==2015:
        y2015+=1
    elif i==2016:
        y2016+=1
    elif i==2017:
        y2017+=1
    elif i==2018:
        y2018+=1
    elif i==2019:
        y2019+=1
    elif i==2020:
        y2020+=1
        
grupos = ['2015', '2016', "2017", "2018","2019", "2020"]
valores = [y2015, y2016, y2017, y2018, y2019, y2020]
plt.bar(grupos, valores)
plt.title("Filmes americanos 2015-2020")
plt.show()

