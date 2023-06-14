using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    // Complete the maximizingXor function below.
    static int maximizingXor(int l, int r)
    {
        int ret = 0;
        for (int i = l; i <= r; i++)
        {
            for (int j = l; j <= r; j++)
            {
                 long num = i ^ j;
                if ( num> ret) 
                {
                    ret = (int)num;
                }
            }
        }
        return ret;
    }

    static void Main(string[] args)
    {
     //   TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int l = Convert.ToInt32(Console.ReadLine());

        int r = Convert.ToInt32(Console.ReadLine());

        int result = maximizingXor(l, r);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
