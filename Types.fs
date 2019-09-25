namespace Utils
module Types =

    type MFMTree =
        | Root of MFMTree
        | Bold of string * MFMTree
        | Text of string * string

    let makeRootTree (tree: MFMTree) : MFMTree =
        Root (tree)

    let makeTextTree (text:string) (isRoot:bool) : MFMTree =
        if isRoot
        then makeRootTree (Text ("text", text))
        else Text ("text", text)

    let makeBoldTree (text: MFMTree) (isRoot: bool) : MFMTree =
        //let textTree = makeTextTree text false
        if isRoot
        then makeRootTree (Bold ("bold", text))
        else Bold ("bold", text)
