public class ContadorSeguro
{
    private int contador=0;
    

    public ContadorSeguro()
    {
        contador=0;
    }
}
// int x = 10;
// int y =0;
// if(y != 0)
// {
//     int resultado= x / y;
// }
// else
// {

// Console.WriteLine("nao e possivel dividir por zero");

// }

//    try
//    {
//      int [] numeros={1,2,3};
     
//      Console.WriteLine(numeros[5]);
//    }
//    catch (System.Exception ex)
//    {
    
//         Console.WriteLine("erro de localizaçao de vetor");
//    }
// try
// {
//     int [] numeros={1,2,3};
    
//     Console.WriteLine(numeros[5]);

    
// }
// catch (System.Exception)
// {
   
// }
 try
   {
     int a = int.Parse("2");
     int idade=-1;
     if (idade < 0)
     {
        throw new IdadeInvalidaException("idade nao pode se negativa.");
     }
     
   
   }
    catch ( IdadeInvalidaException ex)
    {
        
        Console.WriteLine( ex.Message);
    }
   catch (System.FormatException)
   {
    
        Console.WriteLine("erro de formato!");
   }
    catch (Exception ex)
   {
    
        Console.WriteLine("erro generico:" + ex.Message);
   }
   finally
   {
         Console.WriteLine("programa encerrado");
   }


