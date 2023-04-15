var Name = "Ewa";
var Age = 33;
bool female = true;
var resault1 = "Kobieta poniżej 30lat";
var resault2 = "Ewa 33 lat";
var resault3 ="Niepełnoletni Mężczyzna";
var resault4 = "Mężczyzna powyżej 50 lat";

if(female = true && Age == 33)
{
    if (Name == "Ewa")
    {
        Console.WriteLine(resault2);
    }
    else if (!(Name == "Ewa") && Age < 30)
    {
        Console.WriteLine(resault1);
    }
}

else
{
    if(female == false && Age <18)
    {
        Console.WriteLine(resault3);   
    }
    else if (female == false && Age<50)
    {
        Console.WriteLine(resault4);
    }
}
    
