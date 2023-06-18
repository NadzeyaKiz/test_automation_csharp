using CSharpOOP3;

Flowers flowers = new Flowers();

// Попытка записи значения в поле color
flowers.color = "Red"; // Error Line: Field 'Flowers.color' is inaccessible due to its protection level

// Попытка чтения значения из поля color
string flowerColor = flowers.color; // Error Line: Field 'Flowers.color' is inaccessible due to its protection level
Console.WriteLine("Flower color: " + flowerColor);

// Запись значения в свойство Color
flowers.Color = "Blue";

// Попытка записи значения в свойство Price
flowers.Price = 10.99; // Error Line: Property or indexer 'Flowers.Price' cannot be assigned to -- it is read only

// Чтение значения из свойства Price
double flowerPrice = flowers.Price;


Console.WriteLine("Flower price: " + flowerPrice);