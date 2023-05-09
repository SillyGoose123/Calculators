def calc(line, operator):
    ls = line.split(operator)
    
    match operator:
        case "+":
            print(int(ls[0]) + int(ls[1]))
        
        case "-":
            print(int(ls[0]) - int(ls[1]))
        
        case "/":
            print(int(ls[0]) / int(ls[1]))
                
        case "*":
            print(int(ls[0]) * int(ls[1]))
        
        case "%":
            print(int(ls[0]) % int(ls[1]))    
    
print("Hello from Calc in Python!")
print("Type \"exit\" to exit.")

while True:
    line = input(">")   
    
    if line == "":
        print("You need to type sth.")
    else:
        if "exit" in line:
            exit(0)

        if "+" in line:
            calc(line, "+")
            
        elif "-" in line:
            calc(line, "-")

        elif "/" in line:
            calc(line, "/")

        elif "*" in line:
            calc(line, "*")

        elif "%" in line:
            calc(line, "%")
        else:
            print("No operator or not supported operator.")
