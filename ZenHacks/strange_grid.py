# Enter your code here. Read input from STDIN. Print output to STDOUT
import sys

input = sys.stdin.readline().split()

row = int(input[0]) - 1 
col = int(input[1]) - 1


number = (row/2) * 10 + 2 * col

if row % 2 is 1:
    number = number + 1

print number;