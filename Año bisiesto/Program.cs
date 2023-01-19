Console.WriteLine("Inserte su año: ");
int num = Convert.ToInt32(Console.ReadLine());

int check1 = num % 100;
int check2 = num % 400;
int check3 = num % 4;

bool c1= false;
bool c2= false;
bool c3= false;

if(check1 == 0){    
    c1 = true;
}
if(check2 == 0){
    c2 = true;
}
if(check3 == 0){
    c3 = true;
}


if(c1 == false & c3 == true){
    Console.WriteLine($"Su año ({num}) es bisiesto!");
}
if(c1 == true & c2 == true & c3 == true){
    Console.WriteLine($"Su año ({num}) es bisiesto!");
}


if(c3 == false){
    Console.WriteLine($"Su año ({num}) no es bisiesto.  :c");
}
else if(c1 == false & c2 == false & c3 == false){
    Console.WriteLine($"Su año ({num}) no es bisiesto.  :c");
}
else if(c1 == true & c2 == false & c3 == true){
    Console.WriteLine($"Su año ({num}) no es bisiesto.  :c");
}
