try:
    conta=input("digite a operação desejada separada por espaço: ")
    num1,op,num2=conta.split(" ")
    if op=="+":
        result=int(num1)+int(num2)
    elif op=="-":
        result=int(num1)-int(num2)
    elif op=="*" or op==".":
        result=int(num1)*int(num2)
    elif op=="/":
        result=int(num1)/int(num2)      
    print(f"o resultado é: {result}")
except ValueError:
    print("input inválido")
except KeyboardInterrupt:
    print("\nnão é possivel realizar ctrl+c")
except NameError:
    print("operador inválido")
except ZeroDivisionError:
    print("Não divida por 0")
except Exception:
    print("Erro inesperado")