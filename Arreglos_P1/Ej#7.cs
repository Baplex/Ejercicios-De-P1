List<int> numlist = new List<int>();

Console.WriteLine("Introduzca cuantos valores desea: ");
int len = Convert.ToInt32(Console.ReadLine());

for( int i = 0; i < len; i++){
    Console.WriteLine($"Introduzca el valor {i+1}");
    int num = Convert.ToInt32(Console.ReadLine());
    numlist.Add(num);
}

double avg = Queryable.Average(numlist.AsQueryable());
Console.WriteLine($"El average de los numeros introducidos es: {avg}");



