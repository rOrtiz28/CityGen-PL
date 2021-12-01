import ply.yacc as yacc

import map_lex
import os.path

tokens = map_lex.tokens

keys = []

def p_exp(p):
    '''
    exp : crt
           
    '''

def p_crt(p):
   # Function that add the objects type, coordinates and model to the textfile
   
    '''
   crt : CREATE OBJECT 
       | CREATE OBJECT float float float
       | CREATE OBJECT float float float INT
   '''
    
    if p[2].casefold() == "car".casefold():
        print(len(p))
        if len(p) == 3:
            p_textfile(p)
            p_success()
        elif len(p) == 6:
            p_textfile(p)
            p_success()
        elif len(p) == 7:
            p_textfile(p)
            p_success()
                
    elif p[2].casefold() == "house".casefold():
        if len(p) == 3:
            p_textfile(p)
            p_success()
        elif len(p) == 6:
            p_textfile(p)
            p_success()
        elif len(p) == 7:
            p_textfile(p)
            p_success()
              
    elif p[2].casefold() == "item".casefold():
        if len(p) == 3:
            p_textfile(p)
            p_success()
        elif len(p) == 6:
            p_textfile(p)
            p_success()
        elif len(p) == 7:
            p_textfile(p)
            p_success()
            
    elif p[2].casefold() == "person".casefold():
        if len(p) == 3:
            p_textfile(p)
            p_success()
        elif len(p) == 6:
            p_textfile(p)
            p_success()
        elif len(p) == 7:
            p_textfile(p)
            p_success()  
            
    elif p[2].casefold() == "plane".casefold():
        if len(p) == 3:
            p_textfile(p)
            p_success()
        else:
            p_error(1)
    else:
        p_error(0)



def p_float(p):
    '''
   float : INT PERIOD INT
         | INT
   '''
    if len(p) == 4:
        p[0] = str(p[1]) + p[2] + str(p[3])
    else:
        p[0] = p[1]



def p_list(p):
    '''
    list : term
        | list COMMA term
    '''
    if len(p) == 2:
        p[0] = [p[1]]
    else:
        p[0] = p[1] + [p[3]]


def p_term(p):
    '''
    term : INT
        | STRING_LITERAL
        
    '''
    p[0] = p[1]


def p_error(p):
    if p == 0:
        print("The object doesn't exist")
    elif p == 1:
        print("The plane can only be created")
    else:
        print("Syntax Error!")

def p_success():
    print("The object was created successfully!")
   

def p_textfile(p):
    # Function that creates and write the objects in the textfile
    UserInput = open('UserInput.txt', 'a')
    
    if(os.path.isfile('./UserInput.txt') == False):
        with open('UserInput.txt', 'x') as f:
            f.write('')
    elif(os.path.isfile('./UserInput.txt') == True):
        if len(p) == 3:
            UserInput.write(p[2] + ' ' + '0' + ' ' + '0'+ ' ' + '0' + ' ' + '1' + '\n')      
        elif len(p) == 6:
            UserInput.write(p[2] + ' ' + str(p[3]) + ' ' + str(p[4]) + ' ' + str(p[5]) + ' ' + '1' + '\n')
        elif len(p) == 7:
            UserInput.write(p[2] + ' ' + str(p[3]) + ' ' + str(p[4]) + ' ' + str(p[5]) + ' ' + str(p[6]) + '\n')

def getparser():
    return yacc.yacc()