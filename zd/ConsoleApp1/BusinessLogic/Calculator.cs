namespace BusinessLogic
{
    public class Calculator
    {
        /// <summary>
        /// funkcja add to funkcja dodajaca 2 liczby, ktore podajemy w Program cs przy wywolaniu jej 
        /// </summary>
        /// <param name="a">liczba a</param>
        /// <param name="b">liczba b</param>
        /// <returns></returns>
       
        public static int add(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// substract odejmuje liczby
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int substract(int a, int b)
        {
            return a - b;
        }
    }
}
