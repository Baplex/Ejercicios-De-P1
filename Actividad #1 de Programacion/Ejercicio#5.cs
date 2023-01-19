
Console.WriteLine("Introduzca su numero: ");
int num= Convert.ToInt32(Console.ReadLine());

int dig1= num/100;
int dig2= (num/10)%10;
int dig3= num%10;

if (num>=100 & num<=999){
  
  if(dig1 > dig2 & dig1 > dig3){
    Console.WriteLine($"El numero {dig1} se encuentra en primera posición.");
    Console.WriteLine($"El valor maximo de su numero es {dig1}");
  }
  if(dig2 > dig1 & dig2 > dig3){
    Console.WriteLine($"El numero {dig2} se encuentra en segunda posición.");
    Console.WriteLine($"El valor maximo de su numero es {dig2}");
  }
  if(dig3 > dig1 & dig3 > dig2){
    Console.WriteLine($"El numero {dig3} se encuentra en tercera posición.");
    Console.WriteLine($"El valor maximo de su numero es {dig3}");
  }
}
else{
  Console.WriteLine("Favor introduzca dos enteros de 3 digitos.");
}