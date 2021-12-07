menu=1
while menu!=4:
    try:
        menu=int(input(("MENU:\n\n(1)\tAdicionar IP\n(2)\tSobrescrever\n(3)\tLer IPs\n(4)\tSair\n")))
        if menu == 1:
            IP=input("Digite o IP a ser adicionado: ")
            try:
                ip=open("IPs.txt", 'a')
                ip.write(f"{IP},")
            except Exception:
                print("erro ao salvar IP")
            finally:
                ip.close()
        elif menu==2:
            IP=input("Digite o IP a ser adicionado: ")
            try:
                ip=open("IPs.txt", 'w')
                ip.write(f"{IP},")
            except Exception:
                print("erro ao salvar IP")
            finally:
                ip.close()
        elif menu==3:
            ip=open("IPs.txt", 'r')
            print(f"\nIPs = {ip.read()}")
        elif menu==4:
            break  
        else:
            print("input inválido")
    except KeyboardInterrupt:
        print("\nnão é possivel realizar ctrl+c")
    