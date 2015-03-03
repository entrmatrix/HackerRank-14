# Enter your code here. Read input from STDIN. Print output to STDOUT

import Queue
import sys

numTests = int(sys.stdin.readline());

while (numTests > 0):
    numTests -=1;
    
    towns, numRoads = sys.stdin.readline().split()
    #print "towns: " + towns + " roads: " + roads
    
    towns = int(towns)
    numRoads = int(numRoads)
    
    #adjMat = [ [0]*towns for _ in xrange(towns) ]
    adjMat = [0]*towns;
    roads = {}
    
    while numRoads > 0:
        numRoads -= 1;
        src, dst = sys.stdin.readline().split()
        
        src = int(src) - 1
        dst = int(dst) - 1
        
        if src in roads:
            roads[src].append(dst)
        else:
            roads[src] = [dst]
            
        if dst in roads:
            roads[dst].append(src)
        else:
            roads[dst] = [src]
           
    
    start = int(sys.stdin.readline()) - 1
    
    #print roads
    
    if start in roads:
        for road in roads[start]:
            adjMat[road] = -1

    
    #print adjMat
    visited = [False] * towns
    q = Queue.Queue();
    
    visited[start] = True;
    q.put(start);
    
    while not q.empty():
        current = q.get();
        #print "visiting: " + str(current)
        for index in xrange(towns):
            if not visited[index] and (current not in roads or index not in roads[current]):
                visited[index] = True
                q.put(index)
                adjMat[index] = adjMat[current] + 1
                
    result = "";
    for dist in adjMat:
        if(dist is not 0):
            result += str(dist) + " "
    
    print result.strip();
    
