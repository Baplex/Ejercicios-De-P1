List<string> abc = new List<string>();
List<string> abcRot13 = new List<string>();
List<string> final = new List<string>();
char[] array;

Console.WriteLine("Introduzca el codigo que desea decifrar: ");
string ciph = Console.ReadLine();

array = ciph.ToCharArray();

for(char i = 'A'; i <= 'Z'; i++){
    abc.Add(i.ToString());
}

for(char i = 'N'; i <= 'Z'; i++){
    abcRot13.Add(i.ToString());
}
for(char i = 'A'; i <= 'M'; i++){
    abcRot13.Add(i.ToString());
}

foreach(char e in array){
string p = e.ToString();
    if (e >= 'A' && e <= 'Z'){ 
    int indx = abc.IndexOf(p);
    string z = abcRot13[indx];
    final.Add(z);
    }
    else{
        final.Add(p);
    }
}

char sp = ',';
string resultado = String.Join(sp, final);
string resultadof = resultado.Replace(",", "");
Console.WriteLine(resultadof);