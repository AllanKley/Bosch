list=["1_palmeiras", "2_coritiba", "1_corintians", "3_juventude", "2_fluminense", "3_bahia", "1_cuiaba", "2_cascavel", "3_ponte preta", "2_parana clube", "3_volta redonda"]
div1=[]
div2=[]
div3=[]
for time in list:
    div,times=time.split("_")
    print(div,times)
    if div == "1":
        div1.append(times)
    elif div == "2":
        div2.append(times)
    elif div == "3":
        div3.append(times)
print(f"\nPrimeira divisao: {div1}")
print(f"Segunda divisao: {div2}")
print(f"Terceira divisao: {div3}")
