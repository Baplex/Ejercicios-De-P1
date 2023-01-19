
Console.WriteLine("Introduzca su numero: ");
int num= Convert.ToInt32(Console.ReadLine());

int dig1= num/100;
int dig2= (num/10)%10;
int dig3= num%10;
int c1= dig3% dig1;
int c11= dig2% dig1;
int c2= dig1% dig2;
int c22= dig3% dig2;
int c3= dig1% dig3;
int c33= dig2% dig3;

if (num>=100 & num<=999){
  
  if(c1 == 0){
    Console.WriteLine($"{dig3} es multiplo de {dig1}");
  }
  else{
    Console.WriteLine($"{dig3} no es multiplo de {dig1}");
  }
  if(c11 == 0){
    Console.WriteLine($"{dig2} es multiplo de {dig1}");
  }
  else{
    Console.WriteLine($"{dig2} no es multiplo de {dig1}");
  }
  if(c2 == 0){
    Console.WriteLine($"{dig1} es multiplo de {dig2}");
  }
  else{
    Console.WriteLine($"{dig1} no es multiplo de {dig2}");
  }if(c22 == 0){
    Console.WriteLine($"{dig3} es multiplo de {dig2}");
  }
  else{
    Console.WriteLine($"{dig3} no es multiplo de {dig2}");
  }
  if(c3 == 0){
    Console.WriteLine($"{dig1} es multiplo de {dig3}");
  }
  else{
    Console.WriteLine($"{dig1} no es multiplo de {dig3}");
  }
    if(c33 == 0){
    Console.WriteLine($"{dig2} es multiplo de {dig3}");
  }
  else{
    Console.WriteLine($"{dig2} no es multiplo de {dig3}");
  }
}
else{
  Console.WriteLine("Favor introduzca dos enteros de 3 digitos.");
}