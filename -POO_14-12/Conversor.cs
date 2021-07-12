namespace POO_14_12
{
    public static class Conversor
    {
        private static float cotacaoDolar = 5.10f;
        public static float valorUsuario;
        public static float conversorDolarParaReal(){
            return valorUsuario * cotacaoDolar;
        }
        public static float converterRealParaDolar(){
            return valorUsuario / cotacaoDolar;
         }

        private static float cotacaoEuro = 6.22f;
         public static float conversorEuroparaReal(){
             return  valorUsuario * cotacaoEuro;
             }

         public static float converterRealParaEuro(){
             return valorUsuario / cotacaoEuro;
         }    
         }
    }
