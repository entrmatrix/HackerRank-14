# Enter your code here. Read input from STDIN. Print output to STDOUT
import sys

numTests = int(sys.stdin.readline())

while(numTests > 0):
    numTests-=1
    line = sys.stdin.readline().strip()
    
    funny = True
    
    for i in xrange(0, len(line)/2):
        funny = abs(ord(line[i]) - ord(line[i+1])) == abs(ord(line[len(line)-i-1]) - ord(line[len(line)-i-2]))
        if not funny:
            break
           
    print("Funny" if funny else "Not Funny")