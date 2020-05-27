namespace ProjetoPoo
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado;


        /// <summary>
        /// Conversão de string para bool
        /// </summary>
        /// <param name="condicao"></param>
        /// <returns> true or false </returns>

            public bool Ligar(string condicao){
                switch(condicao){
                    case "sim":
                    ligado = true;
                    break;
                    case "nao":
                    ligado = false;
                    break; 
                    default:
                    break;
                }
                return ligado;
    }
}