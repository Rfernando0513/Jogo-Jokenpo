using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo
{
    class Game
    {
        public enum Resultado
        {
            Ganhar, Perder, Empatar
        }

        public static Image[] images =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Papel.png"),
            Image.FromFile("imagens/Tesoura.png"),
        };

        public Image ImgPc { get; private set; }
        public Image ImgUser { get; private set; }

        public Resultado Play(int user)
        {
            int pc = PlayPc();

            ImgUser = images[user];
            ImgPc = images[pc];

            if(user == pc)
            {
                return Resultado.Empatar;
            }else if (user == 0 && pc == 2 || user == 2 && user == 1 || user == 1 && pc == 0)
            {
                return Resultado.Ganhar;
            }
            else
            {
                return Resultado.Perder;
            }

        }

        private int PlayPc()
        {
            int mil = DateTime.Now.Millisecond;

            if(mil < 333)
            {
                return 0;
            }else if(mil >= 333 && mil < 667)
            {
                return 1;
            }else
            {
                return 2;
            }
        }
    }
}
