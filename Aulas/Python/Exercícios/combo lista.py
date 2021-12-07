from random import randrange
palavras=["abobora", "gato", "camera", "arvore"]
traço = []
i = randrange(0,4)
x=0
for a in range(len(palavras[i])):
    traço.append("-")
print(*traço,sep=" ")
while x==0:
    chute=input("chute uma letra: ")
    b=0
    c=0
    for a in palavras[i]:
        if chute == a:
            traço.pop(b)
            traço.insert(b,chute)
        b = b+1
    print(*traço,sep=" ")
    for a in traço:
        if a == "-":
            c=c+1
    if c==0:
        x=1