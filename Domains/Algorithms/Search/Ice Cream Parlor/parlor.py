import sys

def search(flavors, cost):
    for flav_one in range(len(flavors)):
        for flav_two in range(len(flavors)):
            if (flav_one != flav_two) and flavors[flav_one] + flavors[flav_two] == money:
                print str(flav_one + 1) + " " + str(flav_two + 1)
                return
            flav_two += 1
        flav_one += 1

test_cases = int(sys.__stdin__.readline().rstrip())

while test_cases > 0:
    test_cases -= 1
    
    money = int(sys.__stdin__.readline().rstrip())
    num_flavors = int(sys.__stdin__.readline().rstrip())
    
    flavors = map(int, sys.__stdin__.readline().rstrip().split(" "))
    
    #print money
    #print num_flavors
    #print flavors
    
    search(flavors, money)
