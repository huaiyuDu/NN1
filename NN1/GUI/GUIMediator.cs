using NN1.MEMNN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN1.GUI
{
    public class GUIMediator
    {
        public int N { get; set; }

        public int M { get; set; }

        public List<int[]> InputVectors { get; set; }

        public int[,] T { get; set; }

        public List<int[]> TestVectors { get; set; }


        public Action<int, int,List<int[]>> showInputVectors;

        public Action<int> changeRowColor;

        private Random random = new Random();
        public void createTestVectors() {
            InputVectors = new List<int[]>();
            for (int i =0; i < N; i ++) {
                int[] vector = new int[M];
                for (int j = 0; j < M; j++)
                {
                    vector[j] = random.Next(0, 2) == 0 ? -1 : 1;
                }
                InputVectors.Add(vector);
            }
            showInputVectors(N,M,InputVectors);
        }

        public void createModel() {
            T = NN.CreateT(N, M, InputVectors);
            for (int i = 0; i < InputVectors.Count; i++) {
                (Boolean stable, Boolean convergent, int[] v) = NN.CheckConvergent(T, InputVectors[i]);
                Console.WriteLine($"x{i}= [{string.Join(", ", InputVectors[i])}]" );
                if (convergent)
                {
                    Console.WriteLine($"convert to [{string.Join(", ", v)}]");
                }
                else {
                    Console.WriteLine("not convergent");
                }
                if (stable) {
                    changeRowColor(i);
                }
            }
        }



    }
}
