import math
def basc(v1,v2,v3):
    delta = (v2*v2)-(4*v1*v3)
    if delta <0:
        return False, 0, 0
    else:
        print(f"delta: {delta}")
        return True,((-v2+math.sqrt(delta))/(2*v1)), ((-v2-math.sqrt(delta))/(2*v1))
v1 = int(input("digite o primeiro valor: "))
v2 = int(input("digite o segundo valor: "))
v3 = int(input("digite o terceiro valor: "))

cond, r1,r2 = basc(v1,v2,v3)

if cond:
    print(f"As raizes são: {r1}\te\t{r2}")
else:
    print("não há raizes")


    