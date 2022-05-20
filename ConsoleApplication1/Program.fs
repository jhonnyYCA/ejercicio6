// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.

open System
let suma a b = a + b
let resta a b = a - b
let multiplicacion a b = a * b
let division a b = a / b

[<EntryPoint>]
let main argv = 
    
    let mutable op = 10
    let mutable oper= 10
    
    while (oper > 0) do
        Console.WriteLine("1) suma")
        Console.WriteLine("2) resta")
        Console.WriteLine("3) multiplicacion")
        Console.WriteLine("4) division")
        Console.WriteLine("0) salir")
        let op1 = Console.ReadLine()
        let oper2= Convert.ToInt32(op1)
        oper <- oper2
        if (oper > 0) then  
            Console.WriteLine("introduce 1er numero")
            let a = Console.ReadLine()
            Console.WriteLine("introduce 2er numero")
            let b = Console.ReadLine()
            let num1= Convert.ToInt32(a)
            let num2= Convert.ToInt32(b)
            Console.WriteLine("")
            if(oper = 1) then
                let result = suma num1 num2
                Console.WriteLine("La suma de "+num1.ToString()+" + "+num2.ToString()+" es: "+result.ToString())
            if(oper = 2) then
                let result = resta num1 num2
                Console.WriteLine("La resta de "+num1.ToString()+" + "+num2.ToString()+" es: "+result.ToString())
            if(oper = 3) then
                let result = multiplicacion num1 num2
                Console.WriteLine("La multiplicacion de "+num1.ToString()+" + "+num2.ToString()+" es: "+result.ToString())
            if(oper = 4) then
                let result = division num1 num2
                Console.WriteLine("La division de "+num1.ToString()+" + "+num2.ToString()+" es: "+result.ToString())
        
    let tecla = Console.ReadKey();
    0 // devolver un código de salida entero
