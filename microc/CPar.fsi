// Signature file for parser generated by fsyacc
module CPar
type token = 
  | EOF
  | LPAR
  | RPAR
  | LBRACE
  | RBRACE
  | LBRACK
  | RBRACK
  | SEMI
  | COMMA
  | ASSIGN
  | AMP
  | NOT
  | SEQOR
  | SEQAND
  | EQ
  | NE
  | GT
  | LT
  | GE
  | LE
  | MODASSIGN
  | DIVASSIGN
  | TIMESASSIGN
  | MINUSASSIGN
  | PLUSASSIGN
  | PREDEC
  | PREINC
  | ANDASSIGN
  | LSHIFTASSIGN
  | RSHIFTASSIGN
  | XORASSIGN
  | ORASSIGN
  | PLUS
  | MINUS
  | TIMES
  | DIV
  | MOD
  | AND
  | OR
  | XOR
  | QUEST
  | COLON
  | RSHIFT
  | LSHIFT
  | INT
  | CHAR
  | FLOAT
  | ELSE
  | IF
  | NULL
  | PRINT
  | PRINTLN
  | RETURN
  | VOID
  | WHILE
  | DO
  | UNTIL
  | FOR
  | IN
  | RANGE
  | SWITCH
  | CASE
  | DEFAULT
  | PRINTC
  | PRINTF
  | CSTFLOAT of (float32)
  | CSTCHAR of (char)
  | CSTSTRING of (string)
  | NAME of (string)
  | CSTINT of (int)
  | CSTBOOL of (int)
type tokenId = 
    | TOKEN_EOF
    | TOKEN_LPAR
    | TOKEN_RPAR
    | TOKEN_LBRACE
    | TOKEN_RBRACE
    | TOKEN_LBRACK
    | TOKEN_RBRACK
    | TOKEN_SEMI
    | TOKEN_COMMA
    | TOKEN_ASSIGN
    | TOKEN_AMP
    | TOKEN_NOT
    | TOKEN_SEQOR
    | TOKEN_SEQAND
    | TOKEN_EQ
    | TOKEN_NE
    | TOKEN_GT
    | TOKEN_LT
    | TOKEN_GE
    | TOKEN_LE
    | TOKEN_MODASSIGN
    | TOKEN_DIVASSIGN
    | TOKEN_TIMESASSIGN
    | TOKEN_MINUSASSIGN
    | TOKEN_PLUSASSIGN
    | TOKEN_PREDEC
    | TOKEN_PREINC
    | TOKEN_ANDASSIGN
    | TOKEN_LSHIFTASSIGN
    | TOKEN_RSHIFTASSIGN
    | TOKEN_XORASSIGN
    | TOKEN_ORASSIGN
    | TOKEN_PLUS
    | TOKEN_MINUS
    | TOKEN_TIMES
    | TOKEN_DIV
    | TOKEN_MOD
    | TOKEN_AND
    | TOKEN_OR
    | TOKEN_XOR
    | TOKEN_QUEST
    | TOKEN_COLON
    | TOKEN_RSHIFT
    | TOKEN_LSHIFT
    | TOKEN_INT
    | TOKEN_CHAR
    | TOKEN_FLOAT
    | TOKEN_ELSE
    | TOKEN_IF
    | TOKEN_NULL
    | TOKEN_PRINT
    | TOKEN_PRINTLN
    | TOKEN_RETURN
    | TOKEN_VOID
    | TOKEN_WHILE
    | TOKEN_DO
    | TOKEN_UNTIL
    | TOKEN_FOR
    | TOKEN_IN
    | TOKEN_RANGE
    | TOKEN_SWITCH
    | TOKEN_CASE
    | TOKEN_DEFAULT
    | TOKEN_PRINTC
    | TOKEN_PRINTF
    | TOKEN_CSTFLOAT
    | TOKEN_CSTCHAR
    | TOKEN_CSTSTRING
    | TOKEN_NAME
    | TOKEN_CSTINT
    | TOKEN_CSTBOOL
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startMain
    | NONTERM_Main
    | NONTERM_Topdecs
    | NONTERM_Topdec
    | NONTERM_Vardec
    | NONTERM_CaseList
    | NONTERM_CaseDec
    | NONTERM_Vardesc
    | NONTERM_Fundec
    | NONTERM_Paramdecs
    | NONTERM_Paramdecs1
    | NONTERM_Block
    | NONTERM_StmtOrDecSeq
    | NONTERM_Stmt
    | NONTERM_StmtM
    | NONTERM_StmtU
    | NONTERM_Expr
    | NONTERM_ExprNotAccess
    | NONTERM_AtExprNotAccess
    | NONTERM_Access
    | NONTERM_Exprs
    | NONTERM_Exprs1
    | NONTERM_Const
    | NONTERM_ConstChar
    | NONTERM_ConstFloat
    | NONTERM_Type
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val Main : (FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> FSharp.Text.Lexing.LexBuffer<'cty> -> (Absyn.program) 
