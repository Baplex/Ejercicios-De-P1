
Console.WriteLine("Introduzca su primer numero: ");
int num= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduzca su segundo numero: ");
int num2= Convert.ToInt32(Console.ReadLine());

int sum = num + num2;

if (num>=10 & num<=99 & num2 >=10 & num2 <=99){
  Console.WriteLine($"La suma de sus dos numeros ({num}) y ({num2}) es igual a: {sum})");
  if(sum %2 ==0){
    Console.WriteLine($"El numero {sum} es par.");
  }
  else{
    Console.WriteLine($"El numero {sum} es impar.");
  }
}
else{
  Console.WriteLine("Favor introduzca dos enteros de 2 digitos.");
}