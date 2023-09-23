using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04Ex10
{
    public class MonitorDeSaude
    {
        private const double PressaoArterialMinima = 70.0;
        private const double PressaoArterialMaxima = 130.0;
        private const int FrequenciaCardiacaMinima = 60;
        private const int FrequenciaCardiacaMaxima = 100;

        public double PressaoArterial { get; private set; }
        public int FrequenciaCardiaca { get; private set; }

        public MonitorDeSaude(double pressaoArterial, int frequenciaCardiaca)
        {
            VerificarPressaoArterial(pressaoArterial);
            VerificarFrequenciaCardiaca(frequenciaCardiaca);

            PressaoArterial = pressaoArterial;
            FrequenciaCardiaca = frequenciaCardiaca;
        }

        public void AtualizarSinaisVitais(double novaPressaoArterial, int novaFrequenciaCardiaca)
        {
            VerificarPressaoArterial(novaPressaoArterial);
            VerificarFrequenciaCardiaca(novaFrequenciaCardiaca);

            PressaoArterial = novaPressaoArterial;
            FrequenciaCardiaca = novaFrequenciaCardiaca;
        }

        private void VerificarPressaoArterial(double pressaoArterial)
        {
            if (pressaoArterial < PressaoArterialMinima || pressaoArterial > PressaoArterialMaxima)
            {
                throw new ArgumentException($"Pressão arterial fora do intervalo saudável ({PressaoArterialMinima} - {PressaoArterialMaxima}).");
            }
        }

        private void VerificarFrequenciaCardiaca(int frequenciaCardiaca)
        {
            if (frequenciaCardiaca < FrequenciaCardiacaMinima || frequenciaCardiaca > FrequenciaCardiacaMaxima)
            {
                throw new ArgumentException($"Frequência cardíaca fora do intervalo saudável ({FrequenciaCardiacaMinima} - {FrequenciaCardiacaMaxima}).");
            }
        }
    }
}
