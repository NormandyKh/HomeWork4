using HomeWork4.Employee;
using HomeWork4.Matrix;
using HomeWork4.City;
using HomeWork4.CreditCard;


//EMPLOYEE
Console.WriteLine("EMPLOYEE");
Employee emp1 = new Employee("Фродо", 7000);
Employee emp2 = new Employee("Гимли", 12000);

Console.WriteLine("Заработная плата: ");
Console.WriteLine($"{emp1.Name}: {emp1.Salary}");
Console.WriteLine($"{emp2.Name}: {emp2.Salary}");

//увеличиваем зп
emp1.IncreaseSalary(1000);
emp2.IncreaseSalary(250);

Console.WriteLine("\nОбновленная зп после повышения:");
Console.WriteLine($"{emp1.Name}: {emp1.Salary}");
Console.WriteLine($"{emp2.Name}: {emp2.Salary}");

//уменьшаем зп
emp1.DecreaseSalary(750);
emp2.DecreaseSalary(4000);

Console.WriteLine("\nОбновленная зп после уменьшения:");
Console.WriteLine($"{emp1.Name}: {emp1.Salary}");
Console.WriteLine($"{emp2.Name}: {emp2.Salary}");

//отличается ли зп?
Console.WriteLine($"\nЗП у сотрудников одинаковая? {emp1 == emp2}");
Console.WriteLine($"ЗП отличается? {emp1 != emp2}");

//сравниваем зп сотрудников
Console.WriteLine($"\nЗарплата {emp1.Name} больше чем у {emp2.Name} ? {emp1 > emp2}");
Console.WriteLine($"Зарплата {emp1.Name} меньше чем у {emp2.Name} ? {emp1 < emp2}");



//MATRIX
Console.WriteLine("\nMATRIX");
//создаем 2 матрицы 3х3
Matrix matrix1 = new Matrix(3, 3);
matrix1[0, 0] = 1;
matrix1[0, 1] = 2;
matrix1[0, 2] = 3;
matrix1[1, 0] = 4;
matrix1[1, 1] = 5;
matrix1[1, 2] = 6;
matrix1[2, 0] = 7;
matrix1[2, 1] = 8;
matrix1[2, 2] = 9;

Matrix matrix2 = new Matrix(3, 3);
matrix2[0, 0] = 8;
matrix2[0, 1] = 7;
matrix2[0, 2] = 6;
matrix2[1, 0] = 6;
matrix2[1, 1] = 4;
matrix2[1, 2] = 3;
matrix2[2, 0] = 2;
matrix2[2, 1] = 1;
matrix2[2, 2] = 2;

//выодим матрицы на экран
Console.WriteLine("Матрица 1:");
PrintMatrix(matrix1);

Console.WriteLine("Матрица 2:");
PrintMatrix(matrix2);

//сумма матриц
Matrix sumMatrix = matrix1 + matrix2;
Console.WriteLine("Сумма матриц:");
PrintMatrix(sumMatrix);

//отнимаем матрицы
Matrix subMatrix = matrix1 - matrix2;
Console.WriteLine("Разница матриц:");
PrintMatrix(subMatrix);

//умножаем матрицу на число scalar
int scalar = 3;
Matrix scalarMatrix = matrix1 * scalar;
Console.WriteLine($"Матрица 1 умноженная на {scalar}:");
PrintMatrix(scalarMatrix);

//умножаем матрицы друг на друга
Matrix multiMatrix = matrix1 * matrix2;
Console.WriteLine("Матрица 1 умноженная на матрицу 2:");
PrintMatrix(multiMatrix);

//проверяем на ==
bool isEqual = matrix1 == matrix2;
Console.WriteLine($"Равна ли матрица 1 , матрице 2? : {isEqual}");

//проверяем на !=
bool isNotEqual = matrix1 != matrix2;
Console.WriteLine($"Матрица 1 не равна матрице 2? : {isNotEqual}");

//метод для отображения матрицы
static void PrintMatrix(Matrix matrix)
{
    for (int i = 0; i < matrix.Rows; i++)
    {
        for (int j = 0; j < matrix.Columns; j++)
        {
            Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


//CITY
Console.WriteLine("\nCITY");
City city1 = new City { Population = 100000 };
City city2 = new City { Population = 75000 };

Console.WriteLine($"Кол-во населения в городе 1 : {city1.Population}. И городе 2 : {city2.Population}");

city1.IncreasePopulation(1500);
city2.IncreasePopulation(13000);

Console.WriteLine($"\nКол-во населения после увеличения в городе 1 : {city1.Population}. И в городе 2 : {city2.Population}");

city1.DecreasePopulation(12000);
city2.DecreasePopulation(500);

Console.WriteLine($"\nКол-во населения после уменьшения в городе 1 : {city1.Population}. И в городе 2 : {city2.Population}");

Console.WriteLine($"\nПроверяем имеют ли города одинаковое кол-во населения: {city1.Population == city2.Population}");
Console.WriteLine($"Проверяем имеют ли города разное кол-во населения: {city1.Population != city2.Population}");

Console.WriteLine($"\nБольше ли в 1 городе населения чем во 2?: {city1.Population > city2.Population}");
Console.WriteLine($"Меньше ли в 1 городе населения чем во 2?: {city1.Population < city2.Population}");

//CREDIT_CARD
Console.WriteLine("\nCREDIT_CARD");
//cоздаем экземпляр класса CreditCard
CreditCard card1 = new CreditCard("1234 5678 9012 3456", "123", 1000.00m);
CreditCard card2 = new CreditCard("9876 5432 1098 7654", "567", 500.00m);

//используем свойства
Console.WriteLine($"Номер карты: {card1.CardNumber}");
Console.WriteLine($"CVC код: {card1.CvcCode}");
Console.WriteLine($"Баланс карты: {card1.Balance}");

//используем методы увеличения баланса и уменьшения
card1.IncreaseBalance(250.25m);
card2.IncreaseBalance(1000.75m);
Console.WriteLine($"\nБаланс карт после увелечения: ");
Console.WriteLine($"Карта {card1.CardNumber} : {card1.Balance}");
Console.WriteLine($"Карта {card2.CardNumber} : {card2.Balance}");

card1.DecreaseBalance(1200.10m);
card2.DecreaseBalance(75.50m);
Console.WriteLine($"\nБаланс карт после уменьшения: ");
Console.WriteLine($"Карта {card1.CardNumber} : {card1.Balance}");
Console.WriteLine($"Карта {card2.CardNumber} : {card2.Balance}");

//проверка на равенство CVC кода
if (card1 == card2)
{
    Console.WriteLine("\nCVC коды карт совпадают.");
}
else
{
    Console.WriteLine("\nCVC коды карт не совпадают.");
}

//сравнение по балансу
if (card1 > card2)
{
    Console.WriteLine("\nБаланс первой карты больше второй.");
}
else if (card1 < card2)
{
    Console.WriteLine("\nБаланс первой карты меньше второй.");
}
else
{
    Console.WriteLine("\nБалансы карт равны.");
}

// Использование метода Equals
if (card1.Equals(card2))
{
    Console.WriteLine("\nКарты равны по CVC коду.");
}
else
{
    Console.WriteLine("\nКарты не равны по CVC коду.");
}