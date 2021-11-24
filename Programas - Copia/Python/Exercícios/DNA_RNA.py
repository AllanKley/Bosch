rna=""
erro=0
try:
    tamanho=int(input("digite o tamanho da cadeia: "))
    dna=input("digite o dna: ")
    for a in dna:
        if a == "G" or a=="g":
            rna+="C"
        elif a == "C" or a=="c":
            rna+="G"
        elif a == "T" or a=="t":
            rna+="A"
        elif a == "A" or a=="a":
            rna+="U"
        else:
            erro=1
            break
    if erro!=1 and len(dna)==tamanho:
        print(f"DNA: {dna}\nRNA: {rna}")
    else:
        print("input inválido")
except ValueError:
    print("tamanho inválido")
except KeyboardInterrupt:
    print("\nnão pode dar ctrl c")
    
    