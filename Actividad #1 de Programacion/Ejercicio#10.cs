
Console.WriteLine("Introduzca su primer numero: ");
int num= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduzca su segundo numero: ");
int num2= Convert.ToInt32(Console.ReadLine());

int dif =0;
int numM= 0;
int numm= 0;

if (num>num2){
  dif = num - num2;
  numM= num;
  numm= num2;
}

if(num2>num){
  dif= num2 - num;
  numM= num2;
  numm= num;
}


if(dif<=10){
  Console.WriteLine("Su diferencia es menor que 10. Los numeros comprendidos son:");
  for( int x = numm; x<= numM; x++){
    Console.WriteLine(x);
  }
}
else{
  Console.WriteLine("Su diferencia no es menor que 10.");
}

