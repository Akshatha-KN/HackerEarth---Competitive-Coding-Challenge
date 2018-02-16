/*
// Sample code to perform I/O:
 
name = Console.ReadLine();                  // Reading input from STDIN
Console.WriteLine("Hi, {0}.", name);        // Writing output to STDOUT
 
// Warning: Printing unwanted or ill-formatted data to output will cause the test cases to fail
*/
 
// Write your code here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace s_c3
{
    class s_c3
    {
    public static int SumOfXOR(int a,int b)
        {  
            return a | b;
        }
        public static int[] GetMinKValues(int[][] arr,int K)
        {
            
            var query = arr.OrderBy(a => a[2]).Select((s,i)=>new {  index=i });
            int[] result = (from i in query where i.index < K select i.index).ToArray();
 
            return result;
        }
        static void Main(string[] args)
        {
            string inputLine1 = Console.ReadLine();
            string[] arr = inputLine1.Split(' ');
            int N = Convert.ToInt32(arr[0]);
            int M = Convert.ToInt32(arr[1]);
            int K = Convert.ToInt32(arr[2]);
            int[] inputLine2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[][] edges = new int[M][];
            string[] input3;
            for (int i = 0; i < M; i++)
            {
                input3 = Console.ReadLine().Split(' ');
                edges[i] = new int[3];
                edges[i][0] = Convert.ToInt32(input3[0]);
                edges[i][1] = Convert.ToInt32(input3[1]);
            }
            for (int i =0; i < M; i++)
            {
                edges[i][2] = SumOfXOR(inputLine2[edges[i][0]-1], inputLine2[edges[i][1]-1]);
            }
 
            int[] result = GetMinKValues(edges, K);
            for(var j = 0; j < K; j++)
            {
                Console.WriteLine(result[j]+1);
            }
           
        }
    }}
