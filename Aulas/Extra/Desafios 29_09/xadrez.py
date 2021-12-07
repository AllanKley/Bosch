from random import randrange
posicao=[1,1]
movimentos=[[1,2],[1,-2],[2,1],[2,-1],[-1,2],[-1,-2],[-2,1],[-2,-1]]
moves=[]
x=int(input("digite a linha desejada: "))
y=int(input("digite a coluna desejada: "))

while posicao[0]!=x or posicao[1]!=y:
   
    i = randrange(0,8)
    if ((posicao[0]+movimentos[i][0]>0) and (posicao[1]+movimentos[i][1]>0) and (posicao[0]+movimentos[i][0]<8) and (posicao[1]+movimentos[i][1]<8)):
        posicao[0]+=movimentos[i][0]    
        posicao[1]+=movimentos[i][1]
        moves.append(posicao.copy())
        
    

print("\nMovimentos: \n")

print(moves)
