a = input("digite 5 valores: ")
a1,a2,a3,a4,a5 = a.split()
listaa = [a1, a2, a3, a4, a5]
b = input("digite mais 5 valores: ")
b1,b2,b3,b4,b5 = b.split()
listab = [b1, b2, b3, b4, b5]
listac=listaa+listab
print(listac)
i=listac.index(input("digite o item que deseja excluir: "))
listac.pop(i)
print(listac)
