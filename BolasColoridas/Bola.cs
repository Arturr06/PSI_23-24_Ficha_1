using System;

namespace BolasColoridas
{
    public class Bola
    {
        private Cor cor;
        private float raio;
        private int nvezes;

        public Bola(float raio, Cor cor)
        {
            this.cor = cor;
            this.raio = raio;
            nvezes = 0;
        }

        public void Pop()
        {
            raio = 0;
        }

        public void Atirar()
        {
            if(raio > 0) nvezes++;
        }

        public int NVezes()
        {
            return nvezes;
        }

        public float GetRaio()
        {
            return raio;
        }

        public int GetCor()
        {
            return cor.GetGrau();
        } 
    }
}