grammar Calculator;

expression
   : lhs=expression op=(PLUS | MINUS) rhs=multiplyingExpression #add
   | multiplyingExpression                                      #skipAdd
   ;

multiplyingExpression
   : lhs=multiplyingExpression op=(TIMES | DIV) rhs=powExpression #mul
   | powExpression                                                #skipMul
   ;

powExpression
   : lhs=signedAtom (POW rhs+=powExpression)*
   ;

signedAtom
   : PLUS operand=signedAtom  #plusAtom
   | MINUS operand=signedAtom #minusAtom
   | fnc=func_                #funcAtom
   | atm=atom                 #atomAtom
   ;

atom
   : scientific                    #scientificAtom
   | LPAREN expr=expression RPAREN #parenthesisAtom
   ;

scientific
   : SCIENTIFIC_NUMBER
   ;

func_
   : fnc=funcname LPAREN ps+=expression (COMMA ps+=expression)* RPAREN
   ;

funcname
   : COS
   | TAN
   | SIN
   | ACOS
   | ATAN
   | ASIN
   | LOG
   | LN
   | SQRT
   ;


COS
   : 'cos'
   ;


SIN
   : 'sin'
   ;


TAN
   : 'tan'
   ;


ACOS
   : 'acos'
   ;


ASIN
   : 'asin'
   ;


ATAN
   : 'atan'
   ;


LN
   : 'ln'
   ;


LOG
   : 'log'
   ;


SQRT
   : 'sqrt'
   ;


LPAREN
   : '('
   ;


RPAREN
   : ')'
   ;


PLUS
   : '+'
   ;


MINUS
   : '-'
   ;


TIMES
   : '*'
   ;


DIV
   : '/'
   ;


COMMA
   : ','
   ;


POINT
   : '.'
   ;


POW
   : '^'
   ;


SCIENTIFIC_NUMBER
   : NUMBER ((E1 | E2) SIGN? NUMBER)?
   ;


fragment NUMBER
   : ('0' .. '9') + ('.' ('0' .. '9') +)?
   ;


fragment E1
   : 'E'
   ;


fragment E2
   : 'e'
   ;


fragment SIGN
   : ('+' | '-')
   ;


WS
   : [ \r\n\t] + -> skip
   ;