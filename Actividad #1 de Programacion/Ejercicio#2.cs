
Console.WriteLine("Introduzca su numero: ");
int num= Convert.ToInt32(Console.ReadLine());

if (num >=10 & num <=99){
  for (int i = 2; i < num; i++) {
    if (num % i == 0) {
    Console.WriteLine($"{num} no es un numero primo");
    break;  
    }
     else if (num % i != 0) {
    Console.WriteLine($"{num} es un numero primo");
    break; 
     }
  }
}
