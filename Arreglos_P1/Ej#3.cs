List<int> numlist = new List<int>();
List<int> numlistPr = new List<int>();

Console.WriteLine("Introduzca cuantos valores desea: ");
int len = Convert.ToInt32(Console.ReadLine());

bool Prime(int n){
    if (n < 2){
    return false;
    }

    for (int i=2; i<=Math.Sqrt(n); i++){
        if (n%i == 0){
        return false;
    }
    }
    return true;
}

for( int i = 0; i < len; i++){
    Console.WriteLine($"Introduzca el valor {i+1}");
    int num = Convert.ToInt32(Console.ReadLine());
    numlist.Add(num);
    if(Prime(num)){
    numlistPr.Add(num);
    }
}

if(numlistPr.Count() == 0){
   Console.WriteLine("No hay numeros primos en su lista");
    System.Environment.Exit(0);
}

numlistPr.Sort();
numlistPr.Reverse();

int numM = numlistPr[0];
int pos = numlist.IndexOf(numM);

Console.WriteLine($" El número primo más alto de su lista es: {numM}, y se encuentra en la posición {pos+1}");

