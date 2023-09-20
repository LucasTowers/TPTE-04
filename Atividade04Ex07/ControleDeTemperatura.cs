using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04Ex07
{
    public class ControleDeTemperatura
    {
        private double temperaturaDefinida;

        public double TemperaturaDefinida
        {
            get { return temperaturaDefinida; }
            set
            {
                if (value < 16 || value > 30)
                {
                    throw new ArgumentException("A temperatura definida deve estar entre 16°C e 30°C.");
                }
                temperaturaDefinida = value;
            }
        }

        public ControleDeTemperatura(double temperaturaInicial)
        {
            TemperaturaDefinida = temperaturaInicial;
        }

        // Outros métodos relacionados ao controle de temperatura podem ser adicionados aqui.
    }
}
