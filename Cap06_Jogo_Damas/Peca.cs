using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap06_Jogo_Damas
{
    class Peca
    {

        ////////////////////////////////
        /// Atributos e propriedades ///
        ////////////////////////////////

        private char Cor;           // Aspeto da peça

        //////////////
        // Métodos  //
        //////////////

        /////////////////////////
        /// Getters & Setters ///
        /////////////////////////

        public void setCor(char simbolo)
        {
            this.Cor = simbolo;
        }

        public char getCor()
        {
            return Cor;
        }
    }
}
