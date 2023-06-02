namespace EncontrarElementoMajoritario.App.Algoritmos
{
    public static class AlgoritmoElementoMajoritario
    {
        public static void EncontrarElementoMajoritarioEmComplexidadeQuadratica(int[] arr, int n)
        {
            int contagemMaxima = 0;
            int indice = -1;
            for (int i = 0; i < n; i++)
            {
                int contagem = 0;
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        contagem++;
                    }
                }
                if (contagem > contagemMaxima) 
                {
                    contagemMaxima = contagem;
                    indice = i;
                }
            }
            if (contagemMaxima > n / 2)
            {
                Console.WriteLine(arr[indice]);
            }
            else
            {
                Console.WriteLine("O array não possui um elemento majoritário");
            }
        }

        public static void EncontrarElementoMajoritarioEmComplexidadeLinear(int[] arr, int n) 
        {
            int candidato = EncontrarCandidato(arr, n);
            if (ChecarSeElementoMajoritario(arr, n, candidato))
            {
                Console.WriteLine(candidato);
            }
            else
            {
                Console.WriteLine("O array não possui um elemento majoritário");
            }
        }

        private static int EncontrarCandidato(int[] arr, int n)
        {
            int indiceCandidato = 0;
            int contagem = 1;
            for (int i = 1; i < n; i++)
            {
                if (arr[indiceCandidato] == arr[i])
                {
                    contagem++;
                }
                else
                {
                    contagem--;
                }
                if (contagem == 0)
                {
                    indiceCandidato = i;
                    contagem = 1;
                }
            }
            return arr[indiceCandidato];
        }

        private static bool ChecarSeElementoMajoritario(int[] arr, int n, int candidato)
        {
            int contagem = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == candidato)
                {
                    contagem++;
                }
            }
            return contagem > n / 2;
        }
    }
}