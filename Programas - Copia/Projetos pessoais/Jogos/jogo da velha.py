from random import randrange
palavras=["abobora", "gato", "camera", "arvore", "cobra", "girafa", "espaconave", "coracao", "cinema", "controle", "importante", "genio", "televisao", "cenario", "fortuna"]
tracao = []
i = randrange(0,15)
x=0
vidas=5
for a in range(len(palavras[i])):
    tracao.append("-")
print(*tracao,sep=" ")
print("vidas: ",vidas)
while x==0:
    if vidas<=0:
        print("\n\n\ngame over")
        g=25
        break
    chute=input("chute uma letra: ")
    g=0
    b=0
    c=0
    for a in palavras[i]:
        if chute == a:
            tracao.pop(b)
            tracao.insert(b,chute)
            g=g+1
        b = b+1
    if g==0:
        vidas=vidas-1
    print(*tracao,sep=" ")
    print("Vidas: ",vidas)
    for a in tracao:
        if a == "-":
            c=c+1
    if c==0:
        x=1
if g!=25:
    print("\n\n\nParabens")          
