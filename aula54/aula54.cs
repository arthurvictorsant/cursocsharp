using System;

// Namespaces

namespace Calc1{
    
class Area{
    public static float Quad(float b, float h){
        if(b ==0 || h == 0){
            throw new Exception("Base ou altura não podem ser igual a 0");
        }
        return b * h;
    }
}

}

namespace Calc2{
    class Area{
    public static float Quad(float b, float h){
        if(b ==0 || h == 0){
            throw new Exception("Base ou altura não podem ser igual a 0");
        }
        return b * h;
    }
}
}



class Aula53{
    static void Main(){

        float area = 0;
        

        try {
            area = Calc1.Area.Quad(0F,5F);
            Console.WriteLine("Area do quad..: {0}",area);

        }catch(Exception e){ //Captura o erro em "e"
            Console.WriteLine("ERRO: {0}",e.Message);
          
        } finally{ 
            Console.WriteLine("Fim do processo");
        }

        


    }
}