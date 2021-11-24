nome=[]
curso=[]
matricula=[]
sair=False
data=open("teste2.txt", "w")
data.write("")
data.close()
i=1
while not sair:
    if i == 1:
        nome.append(input("digite seu nome: "))
        curso.append(input("digite seu curso: "))
        matricula.append(input("digite sua matrícula: "))
        i=int(input("Digite 1 para continuar cadastrando e 2 para sair: "))
    elif i == 2:
        sair=True
    else:
        print("input inválido")
    
data=open("cadastro.txt", "a")

for i in range(len(nome)):
    data.write(f"\n{nome[i]},")
    data.write(f"{curso[i]},")
    data.write(f"{matricula[i]}")
data.close()

print("\ncadastro realizado com sucesso!")
print("número de alunos cadastrados:", len(nome))