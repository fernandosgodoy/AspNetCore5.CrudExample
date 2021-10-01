using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace Studies.Core.Tests
{
    public class UndestandingCSharpTest
    {
        [Fact]
        public void Exemplo1()
        {
            int[] recipiente = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            recipiente[0] = 1;

            var totalNoPote = 0;
            for (int i = 0; i < recipiente.Length; i++)
            {
                totalNoPote += recipiente[i];
            }

            while (totalNoPote < 10)
            {
                var slotLivre = 0;
                for (int i = 0; i < recipiente.Length; i++)
                {
                    if (recipiente[i] == 0 || recipiente[i] == int.MinValue)
                    {
                        slotLivre = i;
                        totalNoPote++;
                        break;
                    }
                }
                recipiente[slotLivre] = 1;
            }

            Console.WriteLine("Fechando o recipiente");

        }

        [Fact]
        public void Exemplo1Refatorando()
        {
            List<int> recipiente = new List<int>();
            recipiente.Add(1);

            while (recipiente.Count < 10)
                recipiente.Add(1);

            Debug.WriteLine("Fechando o recipiente");
        }

    }
}
