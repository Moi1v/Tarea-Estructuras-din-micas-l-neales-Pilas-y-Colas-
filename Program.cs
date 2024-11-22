using System;

public class PuestoDeLimonadas
{
    public static bool PuestoLimonadas(int[] billetes)
    {
        int cambio5 = 0; 
        int cambio10 = 0; 

        foreach (int billete in billetes)
        {
            if (billete == 5)
            {
                
                cambio5++;
            }
            else if (billete == 10)
            {
                
                if (cambio5 > 0)
                {
                    cambio5--;
                    cambio10++;
                }
                else
                {
                    return false;
                }
            }
            else if (billete == 20)
            {
                
                if (cambio10 > 0 && cambio5 > 0)
                {
                    cambio10--;
                    cambio5--;
                }
                else if (cambio5 >= 3)
                {
                    cambio5 -= 3;
                }
                else
                {
                    return false;
                }
            }
        }

        return true;
    }

    public static void Main(string[] args)
    {
        
        Console.WriteLine(PuestoLimonadas(new int[] { 5, 5, 5, 10, 20 })); 
        Console.WriteLine(PuestoLimonadas(new int[] { 5, 5, 10, 10, 20 })); 
        Console.WriteLine(PuestoLimonadas(new int[] { 10, 10 }));           
        Console.WriteLine(PuestoLimonadas(new int[] { 5, 5, 10 }));         
    }
}
