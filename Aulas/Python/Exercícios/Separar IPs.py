i=0
iptemp=""
iplista=[]
ipseptemp=""
ipsep=[]
validos=[]
invalidos=[]
IPinv=open("IPs_inv.txt", "w")
IPinv.write("")
IPinv.close()
IP=open("IPs.txt", 'r')

for a in IP.read():     #coloca ips numa lista
   if a !=",":
     iptemp+=a
   else:
     iplista.append(iptemp)
     iptemp=""
     
for c in iplista:  #percorre ips
    erro=0
    for b in iplista[i]:     #percorre letras de cada ip
        if b !=".":
            ipseptemp+=b
        else:
            ipsep.append(ipseptemp)
            ipseptemp=""
    ipsep.append(ipseptemp)
    ipseptemp=""
    
    if len(ipsep)!=4:
        invalidos.append(ipsep)
    
    else:
        for d in ipsep:
            try:
                if int(d) <0 or int(d)>255:
                    erro=1
            except Exception:
                erro=1
            
        if erro==1:
            invalidos.append(ipsep)
            
        else:
            validos.append(ipsep)
          
    ipsep=[]
    i+=1 
IPinv=open("IPs_inv.txt", "a")
IPinv.write("Validos: \n\n")    
IPinv.close()
for y in range(len(validos)):
    IPinv=open("IPs_inv.txt", "a")
    IPinv.write(f"IP válido: {validos[y]}\n")    
    IPinv.close()
IPinv=open("IPs_inv.txt", "a")
IPinv.write("\n\n\n\n\nInvalidos: \n\n")    
IPinv.close()
for u in range(len(invalidos)):
    IPinv=open("IPs_inv.txt", "a")
    IPinv.write(f"IP inválido: {invalidos[u]}\n")    
    IPinv.close()

