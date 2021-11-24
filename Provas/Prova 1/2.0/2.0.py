'''
Faça uma função que receba como argumento uma lista de datas no formato: DD/MM/AAAA, verifique se é 
uma data válida e retorne uma outra lista apenas com as datas válidas.
'''

datas=[]
validas=[]
invalidas=[]
sair=False
while not sair:
    menu=int(input("Menu\n(1)\tinserir nova data\n(2)\tSair\n"))
    if  menu==1:
        datas.append(input("insira nova data no formato DD/MM/AAAA: "))
    elif menu==2:
        sair=True
    else:
        print("input inválido")
     
for data in datas:  #percorre datas
    try:
        dia,mes,ano=data.split("/")
        if (dia>"00" and dia<"32") and (mes>"00" and mes<"13"):
            validas.append(data)    
        else:
            invalidas.append(data)
    except:
        invalidas.append(data)
        
print(f"\nAs datas válidas são: {validas}")