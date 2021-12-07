from random import randrange
naipe=["ouro","espadas","copas", "paus"]
dealer=[]
player=[]
cont=0
i=True
rodada=1
for i in range(2):
    temp1=randrange(1,11)
    temp2=randrange(1,11)
    if temp1>10:
        temp1=10
    if temp2>10:
        temp2=10
    dealer.append(temp1)
    player.append(temp2)
while i:

    if cont==0:
        print("\n---------------------------------------------------------------------------------------------------------------------\n")  
        print("Cartas Dealer: \t\t\t_?_\t\t_{}_".format(dealer[1]))
        print("Suas cartas iniciais: \t_{}_\t\t_{}_".format(player[0],player[1]))
    
    if cont==1:
        player.append(randrange(1,11))
        dealer.append(randrange(1,11))
        if sum(player)>=21:
            break
        print("\n---------------------------------------------------------------------------------------------------------------------\n")  
        print("Cartas Dealer: \t\t\t_?_\t\t_{}_".format(dealer[1]))
        print("Suas cartas iniciais: \t_{}_\t\t_{}_".format(player[0],player[1]))
        for a in range(2,len(player)):
            print("{} hit:\t_{}_".format(a-1,player[a]))
        if (sum(dealer)<21):
            for b in range(2,len(dealer)):
                print("{} hit:\t_{}_".format(b-1,dealer[b]))
        rodada+=1
        
    cont=int(input("\nDeseja receber outra carta?\n(1) HIT\n(2) STAND\n"))
    if cont!=1 and cont!=2:
        print("input inválido")
    elif cont==2:
        break
print("\n---------------------------------------------------------------------------------------------------------------------\n")   
if sum(dealer)>sum(player) or sum(player)>21:    
    print("DERROTA !!!!\n\nRESULTADOS\nPlayer:\t{}\nDealer:\t{}".format(sum(player),sum(dealer)))  
else:
    print("VITORIA !!!!\n\nRESULTADOS\nPlayer:\t{}\nDealer:\t{}".format(sum(player),sum(dealer)))
        