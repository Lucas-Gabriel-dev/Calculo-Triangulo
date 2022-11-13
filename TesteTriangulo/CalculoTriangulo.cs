namespace TesteTriangulo;
public class CalculoTriangulo
    {
        public int ResultadoTriangulo(string dadosTriangulo)
        {
            List<int> numbers = new List<int>();

            foreach (var item in dadosTriangulo)
            {
                if (char.IsDigit(item))
                {
                    int digito = item - '0';

                    numbers.Add(digito);
                }
            }

            int valueTotal = numbers[0];
            int firstValue = 0;
            int secondValue = 0;
            int count = 2;

            for (var i = 1; i < numbers.Count; i++)
            {
                firstValue = numbers[i];

                if(i < numbers.Count - 1){
                    secondValue = numbers[i + 1];
                }

                if(firstValue >= secondValue){
                    valueTotal += firstValue;
                }

                if(firstValue < secondValue){
                    valueTotal += secondValue;
                }

                i += count;
                count += 1;
            }

            return valueTotal;
        }
    }
