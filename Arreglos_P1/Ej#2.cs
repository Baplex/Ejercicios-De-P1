List<int> numlist = new List<int>();
List<int> numlistP = new List<int>();

Console.WriteLine("Introduzca cuantos valores desea: ");
int len = Convert.ToInt32(Console.ReadLine());

for( int i = 0; i < len; i++){
    Console.WriteLine($"Introduzca el valor {i+1}");
    int num = Convert.ToInt32(Console.ReadLine());
    numlist.Add(num);
    if(num % 2 == 0){
    numlistP.Add(num);
    }
}

if(numlistP.Count() == 0){
    Console.WriteLine("No hay numeros pares en su lista");
    System.Environment.Exit(0);
}
numlistP.Sort();
numlistP.Reverse();

int numM = numlistP[0];
int pos = numlist.IndexOf(numM);

Console.WriteLine($" El número par más alto de su lista es: {numM}, y se encuentra en la posición {pos+1}");
