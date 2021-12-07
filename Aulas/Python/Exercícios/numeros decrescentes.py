m=0
c=0
d=0
u=0
n1 = int(input("digite o numero desejado: "))
if n1>1000:
    print("numero inválido")
else:
    if n1>99:
        c = n1%100
        c = (n1-c)/100
        n1 = n1- (c*100)
    if n1>9:
        d = n1%10
        d= (n1-d)/10
        n1 = n1- (d*10)
    u=n1
    print(c, d, u)



