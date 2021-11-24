nomemes=["janeiro", "fevereiro", "marco", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro"]
a=["01","02","03","04","05","06","07","08","09","10","11","12"]
data=input("digite a data: ")
try:
    dia,de,mesextenso,de2,ano=data.split(" ")

    for i in nomemes:
        if i == mesextenso:
            mes=a[nomemes.index(i)]
            
    print(dia,mes,ano, sep="/")
except:
    print("input invalido")