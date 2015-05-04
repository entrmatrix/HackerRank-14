import sys

def left_right_equal(array):     
    left_sum = right_sum = 0
    
    for num in elements:
        right_sum += num
        
    for i in xrange(len(array)):
        right_sum -= array[i]
        
        if left_sum == right_sum:
            return True
        
        left_sum += array[i]
        i+=1
        
    return False

test_cases = int(sys.__stdin__.readline())

while test_cases > 0:
    test_cases -= 1
    
    num_elements = int(int(sys.__stdin__.readline()))
    elements = map(int, sys.__stdin__.readline().split(" "))
    
    print "YES" if left_right_equal(elements) else "NO"
