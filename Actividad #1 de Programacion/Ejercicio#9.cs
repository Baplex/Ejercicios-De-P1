
Console.WriteLine("Introduzca su numero: ");
int num= Convert.ToInt32(Console.ReadLine());

int dig2= (num%1000)/100;
int dig3= (num%100)/10;

if (num>=1000 & num<=9999){
  
  if(dig2==dig3){
    Console.WriteLine("Los digitos 2 y 3 son iguales!");
  }
  else{
    Console.WriteLine("Los digitos 2 y 3 no son iguales.");
  }
}
else{
  Console.WriteLine("Favor introduzca dos enteros de 4 digitos.");
}