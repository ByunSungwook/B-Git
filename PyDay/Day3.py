f = open('user.txt', 'r+')
f2 = open('subject.txt', 'r+')

user = f.readlines()
subject = f2.readlines()


def checksubject():
    print()

def sugang():
    print()

def delsubject():
    print()

def checksugang():
    print()

while(True) :
    print("0.Exit / 1.Check subject list / 2. Sugang apply / 3. Delete applied subject / 4 . Check  applied list")
    print("Choose your function")
    func = input()
    if func == 1 :
        checksubject()
    elif func == 2 :
        sugang()
    elif func == 3 :
        delsubject()
    elif func == 4 :
        checksugang()
    elif func == 0 :
        print ("Program Shutdown. Bye!")
        break
    else :
        print("Invalid value. please try again")
        continue