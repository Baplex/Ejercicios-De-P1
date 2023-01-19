
Console.WriteLine("Introduzca su numero: ");
int num= Convert.ToInt32(Console.ReadLine());
int dig1= num/10;
int dig2= num%10;
int resultado = dig1 + dig2;

if (num >=10 & num <=99){
    Console.WriteLine($"El resultado de la suma es: {resultado}");
}
else{
    Console.WriteLine("Introduzca un numero de 2 digitos.");
}
