lista = [145645, 443564, 633, 84563, 766, 75, 856, 2334, 897, 56, 874]
print(lista)
i=lista.index(float(input("digite o item a ser excluido: ")))
lista.pop(i)
incluir = int(input("digite o que deseja incluir na lista: "))
lista.insert(i, incluir)
print("\n",lista)