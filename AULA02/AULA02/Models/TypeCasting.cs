namespace AULA02.Models
{
    public class TypeCasting
    {
        // Declarando variaveis na classe 
        public int myInteger = 20;
        public long myLong;
        public string myType1;
        public string myType2;


          
        public TypeCasting()
        {
            // Conversão implicita de tipos
            myLong = myInteger;
            // myInteger = myLong;
            // Neste caso o long é muito grande
            //para o nt e a conversão é implicta
            //não é permitida.

            long myLong2 = 138129210;
            int myInteger2;
            myInteger2 = (int)myLong2;

            // É possivel identificar qual seria 
            // o tipo de uma variavel em tempo de execução.
            myType1 = myLong2.GetType().ToString();
            myType2 = myInteger2.GetType().ToString();
        }
    }
}
