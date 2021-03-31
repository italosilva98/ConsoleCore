using GameTop.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradora estas pateando \n";
        }

        public string Corre()
        {
            return "Maradora estas corriendo \n";
        }

        public string Passe()
        {
            return "Maradora estas pasando \n";
        }
    }
}