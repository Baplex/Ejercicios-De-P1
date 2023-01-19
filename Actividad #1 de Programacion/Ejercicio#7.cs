Console.WriteLine("Introduzca el primer numero: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduzca el segundo numero: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1>num2){
    Console.WriteLine("Introduzca el tercer numero: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    if(num1>num2){
        Console.WriteLine($"{num1} > {num2}");
    }
    if(num2>num1){
        Console.WriteLine($"{num2} > {num1}");
    }
}
if(num2>num1){
    Console.WriteLine("Introduzca el tercer numero: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    if(num1>num2){
        Console.WriteLine($"{num1} > {num2}");
    }
    if(num2>num1){
        Console.WriteLine($"{num2} > {num1}");
    }
}
if(num1 == num2){
    Console.WriteLine("Introduzca el tercer numero: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    if(num1>num2){
        Console.WriteLine($"{num1} > {num2}");
    }
    if(num2>num1){
        Console.WriteLine($"{num2} > {num1}");
    }
    if(num2 == num1){
        Console.WriteLine("Los numeros son iguales.");
    }
}