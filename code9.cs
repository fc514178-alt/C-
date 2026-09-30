using System;

class exercicio9
{
    class serVivo{
        public int Vida {get; protected set;}
        public string Nome {get; protected set;}
         public arma[] armaequipada;


        public serVivo(int vida, string nome)
        {
            Vida = vida;
            Nome = nome;
        }
        public void receberDano(int Dano)
        {
            Vida -= Dano;

            if(Vida < 0)
            {
                Vida = 0;
            }
        }
    }

    class Inimigo:serVivo
    {
        public Inimigo ( int Vida, string Nome):base(Vida,Nome)
        {
           armaequipada = new arma[1];
        }
    }
    class Personagem:serVivo
    {
        public Personagem(int Vida, string Nome):base(Vida,Nome)
        {}
    }

    public static void Main()
    {
        Personagem  personagem1 = new Personagem(100, "Heroi");
    }

    class arma
    {
        public string Nome {get; protected set;}
        public int Dano {get; protected set;}

        public string Tipo {get; protected set;}

        public arma(string nome, int dano, string tipo)
        {
           Dano = dano;
           Nome = nome;
           Tipo = tipo;
        }
    }
}