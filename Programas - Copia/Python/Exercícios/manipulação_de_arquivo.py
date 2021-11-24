try:
    arq=open("arq2.txt", 'w+')
    arq.write("banana")
    #arq.write("banana")
    #arq.seek(0)
    arq.close()
    arq=open("arq2.txt", 'r+')
    print(arq.read())
except Exception as erro:
    print("erro", erro)
finally:
    arq.close()