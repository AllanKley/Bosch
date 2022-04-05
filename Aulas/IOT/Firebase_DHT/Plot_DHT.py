import pyodbc
import matplotlib.pyplot as plt
import seaborn as sns
import pandas as pd



server = 'JVLPC0510\SQLSERVER'
database = 'DHT-Allan'
username = 'AllanKley'
password = 'admin'
driver= '{ODBC Driver 17 for SQL Server}'


conn= pyodbc.connect('DRIVER='+driver+';SERVER='+server+';PORT=1433;DATABASE='+database+';UID='+username+'; PWD='+ password)
cursor=conn.cursor()
cursor.execute("SELECT Temperatura, Umidade, timestamp FROM dbo.Sensor")

registros=cursor.fetchall()
print("A quantia de registros eh: ", len(registros));
print("")

row = cursor.fetchone()
listaTemperatura=[]
listaUmidade=[]
listatempo=[]
for row in registros:
    listaTemperatura.append(row[0])
    listaUmidade.append(row[1])
    listatempo.append(str(row[2]))
    
    
    



df=pd.DataFrame({"Temperatura":listaTemperatura, "Tempo":listatempo, "Umidade":listaUmidade})




print(df)






# specify plot layouts with different width using subplots()
f, axs = plt.subplots(2,1,
                      figsize=(8,6),
                      sharex=True,
                      gridspec_kw=dict(height_ratios=[1,1]))

sns.lineplot(data= df,
                x="Tempo", y="Temperatura",
                ax=axs[0],
                )

sns.lineplot(data= df,
                x="Tempo", y="Umidade",
                ax=axs[1],
                )
f.tight_layout()
