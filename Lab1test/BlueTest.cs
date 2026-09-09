using System.ComponentModel.Design;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a > 0 && b > 0) || (a < 0 && b < 0))
            {
                answer = true;

            } 
            


            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            if (Math.Abs(d - Math.Round(d)) >= 0.0001)
            {
                answer = true;
            }

            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b == 0)
            {
                return false;
            }
            if (a % b == 0)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double max = d;
            if (Math.Abs(f) > Math.Abs(max) )
            {
                max = f;
            }
            if (Math.Abs(g) > Math.Abs(max))
            {
                max = g;
            }
            return max;
            
            

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double y;
            if (x <= -1)
            {
                y = 0;
            }
            else if (x <= 0)
            {
                y = x + 1;

            }
            else
            {
                y = 1;
            }
            return y;
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double r = Math.Sqrt(circleS / Math.PI);
            double a = Math.Sqrt(squareS);
            if (2 * r <= a)
            {
                answer = true;

            }
            else
            {
                answer = false;
            }
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            
            // end

            return answer;
        }
    }
}
