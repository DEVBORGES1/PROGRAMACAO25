namespace AULA02.Models
{
    public class DataType
    {
        public char myVar = 'a';
        public const char myConst = 'b';

        public char myChar1 = 'f';
        public char myChar2 = ':';
        public char myChar3 = 'x';


        // Podemos tambem atribuir referencias 
        // de caracteres Unicode 

        public char myChar4 = '\u2726';

        // Podemos ainda mesclar caracteres especiais 
        //como, nova linha, tabulação e etc

        public string textLine = "Esta é uma linha de texto \n\n\nE esta é outra linha";

        /*
         \e caracter de escape
         \n Nova linha 
         \r Retorno
         \t Tabulação horizontal
         \" aspas duplas, usandas para exibir aspas dentro de string
         \' aspas simples, usadas para exibir aspas dentro da string
         */

        // insterpolação de String
        // Combinando string de diferentes maneiras no c#

        private int count = 10;
        public string message; 
        public DataType()
        {
            message = $"O Contador está em {count}";

            string username = "BORGES";
            int inboxCount = 10;
            int maxCount = 100;

            message += $"\nO usuário {username} tem {inboxCount} mensagens.";
            message += $"\nEspaço restante em sua caixa {maxCount - inboxCount}.";
             
                
        }
    }
}
