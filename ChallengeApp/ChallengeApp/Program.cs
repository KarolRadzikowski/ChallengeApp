var name = "Ewa";
var Age = 33;
bool kobieta = true;
var resualt1 = "Kobirta poniżej 30 lat";
var resualt2 = "Ewa lat 33";
var resualt3 = "Mężczyzna nie pełnoletni";

if (kobieta == false)
{
    Console.WriteLine(resualt3);
}
if (kobieta == true && Age < 30)
{
    Console.WriteLine(resualt1);
}
else if (name == "Ewa" && Age == 33)
{
    Console.WriteLine(resualt2);
}