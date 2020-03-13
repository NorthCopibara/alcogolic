using System;

namespace algaritm
{
    class Program
    {
        static void Main(string[] args)
        {
            RandonGanerate rand = new RandonGanerate();

            ABubble bubble = new ABubble();

            rand.GenerateArray(100000);

            var startTime = System.Diagnostics.Stopwatch.StartNew();

            rand._array = bubble.Sort_2(rand._array); //algaeitm

            startTime.Stop();
            var resultTime = startTime.Elapsed;

            // elapsedTime - строка, которая будет содержать значение затраченного времени
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                resultTime.Hours,
                resultTime.Minutes,
                resultTime.Seconds,
                resultTime.Milliseconds);

            for (int i = 0; i < rand._array.Length; i++)
            {
                Console.WriteLine(rand._array[i] + "\n");
            }

           

            Console.WriteLine(elapsedTime);
        }
    }

    public class RandonGanerate 
    {
        public int[] _array;

        public void GenerateArray(int count)
        {
            _array = new int[count];

            for (int i = 0; i < count; i++)
            {
                Random rand = new Random();
                int value = rand.Next(0, 1000);

                _array[i] = value;
            }
        }
    }

    public class ABubble 
    {
        public int[] Sort_1(int[] array) 
        {
            int temp;

            for (int i = 0; i < array.Length; i++) 
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j]) 
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

        public int[] Sort_2(int[] array)
        {
            int temp;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            return array;
        }
    }
}
