List<int> numlist = new List<int>();
List<int> numlistS = new List<int>();

Console.WriteLine("Introduzca cuantos valores desea: ");
int len = Convert.ToInt32(Console.ReadLine());

for( int i = 0; i < len; i++){
    Console.WriteLine($"Introduzca el valor {i+1}");
    int num = Convert.ToInt32(Console.ReadLine());
    numlist.Add(num);
    numlistS.Add(num);
}

numlistS.Sort();
numlistS.Reverse();

int numM = numlistS[0];
int pos = numlist.IndexOf(numM);

Console.WriteLine($" El número más alto de su lista es: {numM}, y se encuentra en la posición {pos+1}");
