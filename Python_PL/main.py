import sys
import map_parser

parser = map_parser.getparser()

# Takes in User input and parses it

print("City Generator\nUse the *create* *object* to create different objects of a city!\n")
while True:
    try:
        parse_in = input('>>')
        parser.parse(parse_in)
    except (EOFError, KeyboardInterrupt):
        break