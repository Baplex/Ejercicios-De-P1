
Console.WriteLine("Introduzca su numero: ");
int num= Convert.ToInt32(Console.ReadLine());
int dig1= num/10;
int dig2= num%10;

if (num >=10 & num <=99){
  for (int i = 2; i < dig1; i++) {
    if (dig1 % i == 0) {
    Console.WriteLine($"En el numero {num}, {dig1} no es un numero primo");
    continue;
    }
     else if (dig1 % i != 0) {
    Console.WriteLine($"En el numero {num}, {dig1} es un numero primo");
     continue;
     }
  }
  for (int i = 2; i < dig2; i++) {
    if (dig2 % i == 0) {
    Console.WriteLine($"En el numero {num}, {dig2} no es un numero primo");
    continue;  
    }
     else if (dig2 % i != 0) {
    Console.WriteLine($"En el numero {num}, {dig2} es un numero primo");
    continue; 
     }
  }
}
else{
  Console.WriteLine("Introduzca un numero de dos digitos.");
}