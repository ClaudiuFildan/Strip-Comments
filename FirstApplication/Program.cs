using System;

namespace FirstApplication
{
    class Program
    {
        public static String FunctionFirst(string InputString1, string[] MarkerString)
        {
            // Variable AuxiliarString is used to transform the initial string in a vector of strings.
            // Variable MarkerString1 is used initialize the new line sequence as the separation marker.
            // Using the overloaded method Split, the function is set to pass over the empty string.
            
            string[] MarkerString1 = { "\n" };

            string[] InputString;
            InputString = InputString1.Split(MarkerString1, StringSplitOptions.RemoveEmptyEntries);

                   
            
            

            // Variable AuxiliarStringLoop is used to keep the resulted strings from the split operation.
            // Variable AuxiliarString is used to keep each row of the processed string.
            // Variable charAux is used to help eliminate the space character at the end of the row.
            string[] AuxiliarString = new string[InputString.Length];
            string[] AuxiliarStringLoop = { "" };
            char[] charAux;

            // It passes through each line of the input string.
            for (int i = 0; i < InputString.Length; i++)
            {
                // Divide in multiple string each each row at the given markers.
                // Using the overloaded method, the function is set to pass over the empty string.
                AuxiliarStringLoop = InputString[i].Split(MarkerString, StringSplitOptions.RemoveEmptyEntries);

                // Convert the string before the markers in a vector of chars to better facilitate the acces to each character.
                charAux = AuxiliarStringLoop[0].ToCharArray();

                // If the last character is the space character, it will be eliminated, coping all the element except the last one
                // in another variable.
                // otherwise it will be copied in another variable.
                if (Equals(charAux[charAux.Length - 1], ' '))
                {
                    //Console.WriteLine("The last character in the row is:" + charAux[charAux.Length - 1] + ";");
                    AuxiliarStringLoop[0] = AuxiliarStringLoop[0].Substring(0, AuxiliarStringLoop[0].Length - 1);
                }
                else
                {
                    //Console.WriteLine("The last character in the row is:" + charAux[charAux.Length - 1] + ";");
                    AuxiliarStringLoop[0] = AuxiliarStringLoop[0];
                }

                // Transfer the optain result in a Vector of strings.
                AuxiliarString[i] = AuxiliarStringLoop[0];

            }

            // Initialization of the output string.
            string OutputString = null;
            
            // It passes through all the rows and combines them in one string.
            for (int i = 0; i < AuxiliarString.Length; i++)
            {

                OutputString = OutputString + AuxiliarString[i];
                // If it is not the last element the new line sequence is added. 
                if (i != AuxiliarString.Length - 1)
                {
                    OutputString = OutputString + "\n";
                }

            }

            // Return the output string.
            return OutputString;
        }
        static void Main(string[] args)
        {
            // Initialization of the input string.            
            //string[] InputString;
            //InputString = new String[3] { "apples,pears # and bananas", "grapes", "bananas !apples" };
            string InputString1 = "apples,pears # and bananas\ngrapes\nbananas !apples";
            // Initialization of the markers.
            string[] MarkerString = { "#", "!" };

            // Variable FinalAnswer is used to receive the output string from the function 
            // FunctionFirst.
            string FinalAnswer = FunctionFirst(InputString1, MarkerString);

            // Display the input string.
            Console.WriteLine("\nInput String:");
            Console.WriteLine(InputString1);

            // Display the output string.
            Console.WriteLine("\nOutput String:");
            Console.WriteLine(FinalAnswer);

        }
    }
}
