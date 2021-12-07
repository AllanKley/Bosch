win=False
l1=["_","|","_","|","_"]
l2=["_","|","_","|","_"]
l3=[" ","|"," ","|", " "]
i=0

win =1
def possib():
    g=0
    if(((l1[0]==l1[2]) and (l1[0]==l1[4])) and (l1[0]!="_" and l1[0]!=" ") or ((l2[0]==l2[2]) and (l2[0]==l2[4])) and (l2[0]!="_" and l2[0]!=" ") or ((l3[0]==l3[2]) and (l3[0]==l3[4])) and (l3[0]!="_" and l3[0]!=" ") or ((l1[0]==l2[0]) and (l1[0]==l3[0])) and (l1[0]!="_" and l1[0]!=" ") or ((l1[2]==l2[2]) and (l1[2]==l3[2])) and (l1[2]!="_" and l1[2]!=" ") or ((l1[4]==l2[4]) and (l1[4]==l3[4])) and (l1[4]!="_" and l1[4]!=" ") or ((l1[0]==l2[2]) and (l1[0]==l3[4])) and (l1[0]!="_" and l1[0]!=" ") or ((l1[4]==l2[2]) and (l1[4]==l3[0])) and (l1[4]!="_" and l1[4]!=" ")):
                return 2
    else: 
        for a in l1:
            if a == "_" or a==" ":
                g=1
        for b in l2:
            if b == "_" or b==" ":
                g=1
        for c in l3:
            if c == "_" or c==" ":
                g=1
    return g
while win==1:
    
    if i%2==0:
        a="x" 
    else:
        a="o"
        
    print("\n---------------------------------------------------------------------------------------------------------------------\n")  
    print(*l1,sep="")
    print(*l2,sep="")
    print(*l3,sep="")
    print("")
    print("Dê o seu chute")
    linha=int(input("Linha: "))
    coluna=int(input("Coluna: "))
    if coluna==1:
        coluna=0
    elif coluna==2:
        coluna=2
    elif coluna==3:
        coluna=4
    if linha==1:
       l1.pop(coluna)
       l1.insert(coluna, a) 
    elif linha==2:
       l2.pop(coluna)
       l2.insert(coluna, a )
    else:
       l3.pop(coluna)
       l3.insert(coluna, a)
       
    #### Possibilidades
    win=possib()
    if win==2:
        print("\n---------------------------------------------------------------------------------------------------------------------\n")  
        print(*l1,sep="")
        print(*l2,sep="")
        print(*l3,sep="")
        print("\n\nVitória de",a,"!!!!!")
        break
    elif win == 0:
        print("\n---------------------------------------------------------------------------------------------------------------------\n")  
        print(*l1,sep="")
        print(*l2,sep="")
        print(*l3,sep="")
        print("\n\nDeu Velha!!!!!")
        break
    i+=1
    
    
    
       
        
               

