import sys

numSticks = int(sys.stdin.readline())
sticks = map(int, sys.stdin.readline().strip('\n').split(" "))
sticks.sort();

#print sticks

index = 0
toCut = 0
while index < numSticks:
    print str(numSticks - index)# + " left"
    
    toCut = sticks[index]
    #print toCut
    index+=1
    while index < numSticks and toCut >= sticks[index]:
        index += 1