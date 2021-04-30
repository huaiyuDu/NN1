using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN1.MEMNN
{
    public class NN
    {
        public static int[,] CreateT(int N, int M, List<int[]> vectors) {
            int[,] T = new int[M, M];
            for (int i = 0; i< M; i ++) {
                for (int j = i; j < M; j++)
                {
                    if (i == j)
                    {
                        T[i, i] = 0;
                    }
                    else {
                        int value = 0;
                        for (int k = 0; k < N; k ++) {
                            value = value + vectors[k][i] * vectors[k][j];
                        }
                        T[i, j] = value;
                        T[j, i] = value;
                    }
                }
            }
            return T;
        }

        public static (Boolean, Boolean, int[]) CheckConvergent(int[,] T, int[] v) {
            Boolean statble = false;
            Boolean convergent = false;
            int[] currentV = v;
            int[] lastV = null;
            int[] lastLastV = null;
            while (true) {
                int[] newV = calculate(T, currentV);
                if (checkSame(newV, currentV)) {
                    if (checkSame(newV, v))
                    {
                        statble = true;
                        convergent = true;
                        return (statble, convergent, newV);
                    }
                    else {
                        statble = false;
                        convergent = true;
                        return (statble, convergent, newV);
                    }
                }
                lastLastV = lastV;
                lastV = currentV;
                currentV = newV;
                if (lastLastV != null)
                {
                    if (checkSame(currentV, lastLastV))
                    {
                        statble = false;
                        convergent = false;
                        return (statble, convergent, null);
                    }
                }
            }
            
        }

        private static Boolean checkSame(int[] v1, int[] v2) {
            int size = v1.Length;
            for (int i = 0; i < size; i++)
            {
                if (v1[i]!= v2[i]) {
                    return false;
                }
            }
            return true;
        }
        private static int[] calculate(int[,] T, int[] v) {
            int size = T.GetLength(0);
            int[] result = new int[size];
            for (int i = 0; i < size; i++) {
                int value = 0;
                for (int j = 0; j < size; j++)
                {
                    value = value = T[i, j] * v[j];
                }
                result[i] = signum(value); 
            }
            return result;
        }

        private static int signum(int x) {
            if (x >= 0)
            {
                return 1;
            }
            else {
                return -1;
            }
        }
    }
}
