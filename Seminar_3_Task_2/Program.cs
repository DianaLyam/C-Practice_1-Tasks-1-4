//Напишите программу, которая принимает вход в координаты двух точек и нахождение расстояния между ними в 3D-пространствах.
// А (3,6,8); В (2,1,-7), -> 15,84
// А (7,-5, 0); В (1,-1,9) -> 11,53

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Ввести координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double result(double x1, double x2, double у1, double у2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

double segmentLength = Math.Round(result(x1, x2, y1, y2, z1, z2), 2);

Console.WriteLine($"Длина отрезка {segmentLength}");