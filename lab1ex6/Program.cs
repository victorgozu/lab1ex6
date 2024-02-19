/*
 * Ex 6
Scrieti un program care va verifica daca un numar citit de la tastatura este par sau
impar
 In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.
 Google :even and odd number

*/

Console.WriteLine("Introduceti un numar par sau impar");
int numar = int.Parse(Console.ReadLine());


if (numar % 2 == 0)
{
    Console.WriteLine("par");
}
else
{
    Console.WriteLine("impar");
}
