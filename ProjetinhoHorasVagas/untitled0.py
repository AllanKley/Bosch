loop = True
Produtos = [[1, "Pizza", 12.3], [2, "Carne", 15], [3, "Tomate", 5.6], [4,"Miojo", 7.2]]
Carrinho = [[2, "Carne", 15, 1], [4,"Miojo", 7.2, 2]]




def Menu():
  print("================================")
  print("|        Lojinha do Allan      |")
  print("================================")
  print("| 1. Cadastrar Produtos        |")
  print("| 2. Listar Produtos           |")
  print("| 3. Comprar Produtos          |")
  print("| 4. Visualizar Carrinho       |")
  print("| 5. Sair                      |")
  print("================================")




def Listar():
    
    print()
    print("Código - Descrição - Preço")
    
    for produto in Produtos:
        print(" ", produto[0], " - ", produto[1], " - ", produto[2])
    
    
    
    
def Vizualizar():
    print()
    print("Código - Descrição - Preço - Quantia")
    
    for produto in Carrinho:
        print(" ", produto[0], " - ", produto[1], " - ", produto[2], " - ", produto[3])
    
    
    
    
def Cadastrar():
    
    codigo = int(input("Digite o codigo do produto a ser cadastrado: "))
    nome = input("Digite o nome do produto a ser cadastrado: ")
    
    novoProduto = [codigo,nome]
    
    Produtos.append(novoProduto)
   
    
   
    
def Comprar():
    existe = False
    comprado = False
    
    nome = input("Digite o nome do produto que deseja comprar: ")
    
    for produto in Carrinho:
        if(produto[1]==nome):
            comprado=True
            produto[3] += 1
            
            
    if(not comprado):      
        for produto in Produtos:
            if(produto[1]==nome):
                existe=True
                codigo = produto[0]
                preco = produto[2]
        if(existe):
            novoProduto = [codigo,nome, preco, 1]
            Carrinho.append(novoProduto)
        else:
            print("Esse produto não existe ou não está cadastrado")






def Escolha(escolha):
    
    if escolha == 1:
        Cadastrar()
    if escolha == 2:  
        Listar()
    if escolha == 3:
        Comprar()
    if escolha == 4:
        Vizualizar()
    if escolha == 5:
        raise SystemExit

    


while(loop):
    Menu()
    Escolha(int(input()))

