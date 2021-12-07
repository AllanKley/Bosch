def fact(num):
    fatorial=1
    for a in range(num):
        fatorial*=(a+1)
    print(fatorial)
num=int(input("digite seu numero: "))
fact(num)
