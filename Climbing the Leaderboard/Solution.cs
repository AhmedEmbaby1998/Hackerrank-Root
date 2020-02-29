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

class Solution {

   static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            //remove duplicates scores 
            //O(n) time complexity,O(n) space complexity
            int top;
            var dist = Distinct(scores,out  top);
            //now the last index in dist that filled with scores is index top
            int[] rv = new int[alice.Length];
            for (int i = 0; i < alice.Length; i++)
            {
                //add 1 as BinarySearch works with 0 index but ranking is 1 base indexed counted
                rv[i] = BinarySearch(dist, top,alice[i])+1;
            }
            return rv;
        }

        private static int[] Distinct(int [] arr,out int top)
        {
            var dis = new int [arr.Length];
            int t = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i==0)
                {
                    dis[t++] = arr[0];
                }
                else if (arr[i]!=dis[t-1])
                {
                    dis[t++] = arr[i];
                }

            }

            top = t;//the dist is filled to index top-1
            return dis;
        }
        public static  int BinarySearch(int [] arr,int top ,int mark){
            int start=0;int end=top-1;int middle=0;
            while (start<=end){
                middle =(start+end)/2;
                if(arr[middle]==mark) return middle;
                if (mark < arr[middle])
                    start = middle + 1;
                else
                    end = middle - 1;
            }
            return mark>arr[middle]?middle:middle+1;
        }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int scoresCount = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int aliceCount = Convert.ToInt32(Console.ReadLine());

        int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))
        ;
        int[] result = climbingLeaderboard(scores, alice);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
