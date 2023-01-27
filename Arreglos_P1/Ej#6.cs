List<int> numlist = new List<int>();
List<int> numlist3 = new List<int>();

Console.WriteLine("Introduzca cuantos valores desea: ");
int len = Convert.ToInt32(Console.ReadLine());

for( int i = 0; i < len; i++){
    Console.WriteLine($"Introduzca el valor {i+1}");
    int num = Convert.ToInt32(Console.ReadLine());
    numlist.Add(num);   
    if(num >= 999){
        numlist3.Add(num);
    }
}

if(numlist3.Count()==0){
     Console.WriteLine("No hay numeros mayores de 3 digitos.");
}

foreach(int r in numlist3){
    int pos = numlist.IndexOf(r);
    Console.WriteLine($"La posición de los numeros mayores de 3 digitos se encuentran en: {pos+1}");
}


