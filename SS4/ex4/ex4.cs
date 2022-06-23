int yrsOfService = 3;
double salary = 1500;
int bonus = 0;
if (yrsOfService < 5)
{
    if(salary < 500) 
    {
        bonus = 100;
    }
    else
    {
        bonus = 200;
    }
}
else
{
    bonus = 700;
}
Console.WriteLine("Bonus amount: "+bonus);