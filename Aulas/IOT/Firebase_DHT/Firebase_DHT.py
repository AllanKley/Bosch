import requests
import pyodbc
import time

def sinal():
 proxies = {'https': "http://disrct:saladigital0311@10.224.200.26:8080/"}
 temp = "https://dht-allan-default-rtdb.firebaseio.com/Sensor/Temperatura.json"
 umi = "https://dht-allan-default-rtdb.firebaseio.com/Sensor/Umidade.json"
 temperatura = float(requests.get(temp, proxies=proxies).content)
 umidade = float(requests.get(umi, proxies=proxies).content)
 return temperatura, umidade



def InserirBD(sinal):
 server = 'JVLPC0510\SQLSERVER'
 database = 'DHT-Allan'
 username = 'AllanKley'
 password = 'admin'
 cnxn = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+ password)
 cursor = cnxn.cursor()
 cursor.execute(f"INSERT dbo.Sensor (Temperatura, Umidade) VALUES ({sinal[0]},{sinal[1]});")
 cursor.commit()
 print("Inserido com sucesso!")
 
 



server = 'JVLPC0510\SQLSERVER'
database = 'DHT-Allan'
username = 'AllanKley'
password = 'admin'
driver= '{ODBC Driver 17 for SQL Server}'

conn= pyodbc.connect('DRIVER='+driver+';SERVER='+server+';PORT=1433;DATABASE='+database+';UID='+username+';PWD='+ password)
cursor=conn.cursor()

cursor.execute("SELECT Temperatura, timestamp FROM dbo.Sensor")
row = cursor.fetchone()

lista=[]
listatempo=[]

while row:
    lista.append(row[0])
    listatempo.append(str(row[1])) 
    row = cursor.fetchone()
    
    
def apresentar(sinal):
 print(f"Temperatura: {sinal[0]}")
 print(f"Umidade: {sinal[1]}")
 

while True:
     valores=sinal()
     apresentar(valores)
     InserirBD(valores)
     time.sleep(30)
   
    

    
    
    