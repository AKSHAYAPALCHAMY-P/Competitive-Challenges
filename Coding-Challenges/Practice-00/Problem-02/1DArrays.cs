namespace Arrays
{
    public class OneDimensionalArrays
    {
        public static void Solution()
        {
            //Array Initialization

            /*way1*/
            int[] nArray = new int[10];

            /*way2*/
            int[] nArray1 = new int[] {10,20,30};

            /*way3*/
            int[] nArray2 = {20,30};


            nArray[0] = 1;
            nArray[1] = 2;
            nArray[2] = 3;  
            nArray[3] = 4;
            nArray[4] = 5;
            nArray[5] = 6;
            nArray[6] = 7;
            nArray[7] = 8;
            nArray[8] = 9;
            nArray[9] = 10;

            for(int i = 0; i < nArray.Length; i++) 
            {
                Console.WriteLine(nArray[i]);
            }


        }
    }
}