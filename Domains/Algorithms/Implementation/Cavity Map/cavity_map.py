import sys

numLines = int(sys.__stdin__.readline())
cavityMat = [[0 for x in range(numLines)] for x in range(numLines)]

i = 0;
while(i < numLines):
    cavityMat[i] = list(sys.__stdin__.readline().strip('\n'))
    #print cavMat[i]
    i += 1

def onBorder(row, col):
    return row == 0 or row == numLines - 1 or col == 0 or col == numLines - 1

def checkCavity(row, col):
    if onBorder(row, col):
        return False
    #print "Coord: " + str(row) + "," + str(col) + " " + str(cavityMat[row][col])
    #print cavityMat[row-1][col] + " " + cavityMat[row][col-1] + " " + cavityMat[row][col+1] + " " + cavityMat[row+1][col]

    return (cavityMat[row][col] > cavityMat[row-1][col]
            and cavityMat[row][col] > cavityMat[row][col-1]
            and cavityMat[row][col] > cavityMat[row][col+1]
            and cavityMat[row][col] > cavityMat[row+1][col])


for row in range(numLines):
    for col in range(numLines):
        if(checkCavity(row, col)):
            sys.stdout.write('X')
        else:
            sys.stdout.write(cavityMat[row][col])
    sys.stdout.write('\n')
    