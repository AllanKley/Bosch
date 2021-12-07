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
    frame=[f0,f1,f2,f3,f4,f5,f6]
    for i in range (0,6,1):
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
    f0=open("Frame 0.txt", "r")
    f1=open("Frame 1.txt", "r")
    f2=open("Frame 2.txt", "r")
    f3=open("Frame 3.txt", "r")
    f4=open("Frame 4.txt", "r")
    f5=open("Frame 5.txt", "r")
    f6=open("Frame 6.txt", "r")
    frame=[f0,f1,f2,f3,f4,f5,f6]
    for i in range (6,0,-1):
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
    



    
