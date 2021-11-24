gols=[]
total=0
nome = input("digite seu nome: ")
part = int(input("digite a quantidade de partidas jogadas: "))

for i in range(part):
    gols.append(int(input(f"Quantos gols na partida {i+1}?\t")))
    
for i in gols:
    total+=i

dic = {"nome": nome,"gols": gols,"total": total}

print("\n\n",dic)
print(f"\n jogador {nome} jogou {part} partidas.")

for i in range(part):
    print(f"Na partida {i+1} fez {gols[i]} gols")
    
print("Com um total de ", dic["total"])