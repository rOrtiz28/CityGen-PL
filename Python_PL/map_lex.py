import ply.lex as lex

# Implementation of lexical analyzer
# Create Tokens

keywords = {
    'create': 'CREATE',
    'none': 'NONE',

}

tokens = [
             'OBJECT',
             'COMMA',
             'INT',
             'STRING_LITERAL',
             'PERIOD'
         ] + list(keywords.values())

t_COMMA = r'\,'

t_PERIOD = r'\.'

t_STRING_LITERAL = r'\"([^\\\n]|(\\.))*?\"'

t_ignore_COMMENT = '//.*'

t_ignore = ' \t\n'

def t_OBJECT(t):
    r'[a-zA-Z][a-zA-Z]*'
    t.type = keywords.get(t.value, 'OBJECT')
    return t

def t_INT(t):
    r'\d+'
    try:
        t.value = int(t.value)
    except ValueError:
        print("Integer value too large %d", t.value)
        t.value = 0
    return t

def t_BLOCK_COMMENT(t):
    r'/\*(.|\n)*?\*/'
    t.lexer.lineno += t.value.count('\n')

def t_newline(t):
    r'\n+'
    t.lexer.lineno += len(t.value)

def t_error(t):
    print("Illegal character '%s'" % t.value[0])
    t.lexer.skip(1)


lexer = lex.lex()