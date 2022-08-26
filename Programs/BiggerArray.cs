using System.Diagnostics;

namespace ConsoleTest.Programs;

public static class BiggerArray
{
      public static int[,,,,,,,,,] arr;
      public static void BigArray(int n)
      {
            int count = 0;
            Stopwatch st = Stopwatch.StartNew();
            arr = new int[n, n, n, n, n, n, n, n, n, n];

            for (int a = 0; a < n; a++)
            {
                  for (int b = 0; b < n; b++)
                  {
                        for (int c = 0; c < n; c++)
                        {
                              for (int d = 0; d < n; d++)
                              {
                                    for (int e = 0; e < n; e++)
                                    {
                                          for (int f = 0; f < n; f++)
                                          {
                                                for (int g = 0; g < n; g++)
                                                {
                                                      for (int h = 0; h < n; h++)
                                                      {
                                                            for (int i = 0; i < n; i++)
                                                            {
                                                                  for (int j = 0; j < n; j++)
                                                                  {
                                                                        arr[a, b, c, d, e, f, g, h, i, j] = count;
                                                                  }
                                                            }
                                                      }
                                                }
                                          }
                                    }
                              }
                        }
                  }
            }





            st.Stop();
            Console.WriteLine(st.Elapsed);


      }
}