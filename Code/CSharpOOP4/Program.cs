using CSharpOOP4;

#region Calculation of the Ball shape
Console.WriteLine("----------------------");
Ball ball = new Ball(10);
ball.DisplayShapeInfo();
Console.WriteLine("----------------------");
#endregion

#region Calculation of the Cylinder shape
Console.WriteLine("----------------------");
Cylinder cylinder = new Cylinder("Cylinder", 10, 5);
cylinder.DisplayShapeInfo();
Console.WriteLine("----------------------");
#endregion

#region Calculation of the Piramid shape
Console.WriteLine("----------------------");
Piramid piramid = new Piramid("Piramid", 46, 4);
piramid.DisplayShapeInfo();
Console.WriteLine("----------------------");
#endregion