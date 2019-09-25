// Learn more about F# at http://fsharp.org

open System.IO
open FSharp.Text.Lexing

let LexAndParseFromString (text : string) =
    let lexbuf = LexBuffer<char>.FromString text
    let countFromParser = Parser.start Lexer.tokenize lexbuf

    printfn "%O" countFromParser

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    LexAndParseFromString "**A**"
    //LexAndParseFromString "text"
    0 // return an integer exit code
