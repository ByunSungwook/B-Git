class shape :
    area = raw_input()
    perimeter = raw_input()

    def calcArea(self):
        return self.area

    def calcPerimeter(self):
        return self.perimeter

    def printInfo(self):
        print ("area : %d \t perimeter : %d \t " , self.calcArea(), self.calcPerimeter())
