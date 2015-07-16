open('list.txt', 'r+')
list = {'apple':3, 'banana':6, 'Doughnut':8, 'Eclair':7 }

print "Welcome. Let's start the game."

while(True) :
    print "0.Exit / 1. Insert / 2. Delete / 3. Show List"
    print "Choose the Function you want : "
    num = input()

    if num ==1:
        print "Enter the item name : "
        item = raw_input()
        if item in list:
            print "Enter the Value : "
            amount = input()
            list[item] += amount
            print "Insertion finished"
            continue
        else:
            print "Enter the Value : "
            amount = input()
            list[item] = amount
            print "Insertion finished"
            continue
    elif num ==2:
        print "Enter the item name : "
        item = raw_input()
        if item in list:
            print "Enter the Value : "
            amount = input()
            if list[item]-amount>0:
                list[item]-=amount
                print "Removing completed"
                continue

            elif list[item]-amount == 0:
                del list[item]
                print "Removing completed"
                continue
            elif list[item]-amount<0:
                print "Oops! Try again!"
                continue
        else:
            print "Oops! There's no item you want!"
            continue
    elif num ==3:
        print list
        continue
    elif num ==0:
        print "Bye!"
        break
    else:
        print "Oops! Try again!"
        continue
