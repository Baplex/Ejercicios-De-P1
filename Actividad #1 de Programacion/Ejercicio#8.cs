
Console.WriteLine("Introduzca su numero: ");
int num= Convert.ToInt32(Console.ReadLine());

int dig1= num/10000;
int dig2= (num%10000)/1000;
int dig3= (num%1000)/100;
int dig4= (num%100)/10;
int dig5= num%10;

if (num>=10000 & num<=99999){
  
  if(dig1==dig5 & dig2==dig4){
    Console.WriteLine("Su numero es capicua    C:");
  }
  else{
    Console.WriteLine("Su numero no es capicua  :c");
  }
}
else{
  Console.WriteLine("Favor introduzca dos enteros de 5 digitos.");
}