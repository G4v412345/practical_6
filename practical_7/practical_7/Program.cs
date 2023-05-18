public interface IParent
{
    string Info();
    double calculation(); 
} 
public class Child1 : IParent
{
    private int pole1;
    private int pole2; 

    public Child1(int pole1,int pole2)
    {
        this.pole1 = pole1;
        this.pole2 = pole2; 
    } 

    public double calculation()
    {
        if (pole2 == 1)
        {
            return pole1 * 3;

        }
        else
        {
            return pole1 * 2; 
        }
    }
     
    public string Info()
    {
        return $"Мiн. допомога = {pole1}, Номер групи iнвалiдностi = {pole2}"; 
    }
} 
public class Child2 : IParent
{
    private double pole1;
    private double pole3;
    public Child2(double pole1, double pole3)
    {
        this.pole1 = pole1;
        this.pole3 = pole3; 
    } 
    public double calculation()
    {
        if (pole3 >= 3 && pole3 <= 5)
        {
            return pole1 * 1.3;
        }
        else if (pole3 > 5)
        {
            return pole1 * 1.5;
        }
        else
        {
            Console.WriteLine("pole3 не входить в значення: 3 до 5 або бiльше 5");            
            return 0; 
        } 
    } 
    public string Info()
    {
        return $"Мiн. допомога = {pole1}, Кiл. дiтей = {pole3}";   
    }
}
class Program
{
    static void Main(string[] args)
    {
        int min_help = 2311;  
        for (int i = 1; i <= 5; i++)
        {
            Random rnd = new Random();
            if (rnd.Next(1,3) == 1)
            {
                Child1 child1 = new Child1(min_help, rnd.Next(1,4));
                Console.WriteLine(child1.Info()); 
                Console.WriteLine($"Допомога: {child1.calculation()}"); 
            }
            else
            {
                Child2 child2 = new Child2(min_help, rnd.Next(3,11));
                Console.WriteLine(child2.Info());
                Console.WriteLine($"Допомога: {child2.calculation()}"); 
            }
        } 
    }
}