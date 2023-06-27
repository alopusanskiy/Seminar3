// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void Distance(int firX, int firY, int firZ, int secX, int secY, int secZ)
{
    double result = Math.Sqrt(Math.Pow(firX - secX, 2) + Math.Pow(firY - secY, 2) + Math.Pow(firZ - secZ, 2));
    System.Console.WriteLine(result);
}

System.Console.Write("Введите кординаты точки по 3-м осям последовательно X, Y, Z: ");
int firstX = Convert.ToInt32(Console.ReadLine());
int firstY = Convert.ToInt32(Console.ReadLine());
int firstZ = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите кординаты точки по 3-м осям последовательно X, Y, Z: ");
int secondX = Convert.ToInt32(Console.ReadLine());
int secondY = Convert.ToInt32(Console.ReadLine());
int secondZ = Convert.ToInt32(Console.ReadLine());

Distance(firstX, firstY, firstZ, secondX, secondY, secondZ);





