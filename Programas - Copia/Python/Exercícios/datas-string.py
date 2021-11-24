dia=""
mes=""
ano=""
nomemes=["janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro"]
data=input("digite a data: ")
for a in range(0,2):
    dia+=data[a]
for b in range(3,5):
    mes+=data[b]
for c in range(6,10):
    ano+=data[c]
if (dia>"00" and dia<"32") and (mes>"00" and mes<"13"):
    print(f"{dia} de {nomemes[int(mes)-1]} de {ano}")
else:
    print("input invalido")

