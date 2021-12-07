idade=[]                                           
alt=[]
quant = 10                                          #define quantia de dados
soma = 0    
totalunos=0                        


for i in range(quant):                              #coletar dados         
    idade.append(int(input("digite a idade: ")))
    alt.append(float(input("digite a altura: ")))
    
for a in alt:                                       #calcular media
    soma = soma + a
med = soma/quant

for a in range(quant):                              #verificar alturas
    if idade[a]>13 and alt[a]<med:
        totalunos +=1
print("\ntotal alunos nanicos: ",totalunos)                         
