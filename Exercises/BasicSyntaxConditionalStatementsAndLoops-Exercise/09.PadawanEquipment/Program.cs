double moneyAmount = double.Parse(Console.ReadLine());
int studentsCount = int.Parse(Console.ReadLine());
double saberPrice = double.Parse(Console.ReadLine());
double robePrice = double.Parse(Console.ReadLine());
double beltPrice = double.Parse(Console.ReadLine());

double percent = (double)studentsCount * 0.10;
double allSabers = studentsCount + Math.Ceiling(percent);
double sabers = saberPrice * allSabers;

double robes = studentsCount * robePrice;

double beltsDiscount = studentsCount - Math.Ceiling((double)(studentsCount / 6));
double belts = beltPrice * beltsDiscount;

double total = sabers + robes + belts;
if (total <= moneyAmount)
{
    Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
}
else
{
    Console.WriteLine($"John will need {(total - moneyAmount):f2}lv more.");
}