namespace AlgorithmAndDatastructure.CustomArray
{
    public class MySwapClass
    {
        public static void Swap<T>(ref T valOne, ref T valTwo)
        {
            T temp = valOne;
            valOne = valTwo;
            valTwo = temp;
        }
    }
}