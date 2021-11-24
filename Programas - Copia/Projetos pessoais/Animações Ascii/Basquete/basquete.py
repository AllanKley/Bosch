import time
delay = .20
print(chr(27) + "[2J")

for a in range(500):
    f0=open("Frame 0.txt", "r")
    f1=open("Frame 1.txt", "r")
    f2=open("Frame 2.txt", "r")
    f3=open("Frame 3.txt", "r")
    f4=open("Frame 4.txt", "r")
    f5=open("Frame 5.txt", "r")
    f6=open("Frame 6.txt", "r")
    f7=open("Frame 7.txt", "r")
    f8=open("Frame 8.txt", "r")
    f9=open("Frame 9.txt", "r")
    f10=open("Frame 10.txt", "r")
    f11=open("Frame 11.txt", "r")
    f12=open("Frame 12.txt", "r")
    f13=open("Frame 13.txt", "r")
    f14=open("Frame 14.txt", "r")
    f15=open("Frame 15.txt", "r")
    f16=open("Frame 16.txt", "r")
    f17=open("Frame 17.txt", "r")
    f18=open("Frame 18.txt", "r")
    f19=open("Frame 19.txt", "r")
    f20=open("Frame 20.txt", "r")
    f21=open("Frame 21.txt", "r")
    frame=[f0,f1,f2,f3,f4,f5,f6,f7,f8,f9,f10,f11,f12,f13,f14,f15,f16,f17,f18,f19,f20,f21]
    
    
    for i in range (0,22,1):
        print(frame[i].read())
        time.sleep(delay)
        print(chr(27) + "[2J")
        
        
    f0.close()
    f1.close()
    f2.close()
    f3.close()
    f4.close()
    f5.close()
    f6.close()
    f7.close()
    f8.close()
    f9.close()
    f10.close()
    f11.close()
    f12.close()
    f13.close()
    f14.close()
    f15.close()
    f16.close()
    f17.close()
    f18.close()
    f19.close()
    f20.close()
    f21.close()
    
    
    



    
