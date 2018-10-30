using System;
using System.Collections.Generic;

namespace WF_Udvoitel
{
    class Udvoitel
    {
        int finish;
        int current;
        Stack<int> steps;

        public Udvoitel(int min, int max)
        {
            steps = new Stack<int>();
            GenFinish(min, max);
        }

        public void GenFinish(int min, int max)
        {
            Random rnd = new Random();
            this.finish = rnd.Next(min, max + 1);
            Reset();
        }

        int GetMinSteps(int number)
        {
            int i = 0;
            while (number != 1)
            {
                if(number%2 == 0)
                {
                    number /= 2;
                    i++;
                }
                else
                {
                    number -= 1;
                    i++;
                }
            }
            return i;
        }

        public void Plus()
        {
            steps.Push(current);
            current++;
        }

        public void Multi()
        {
            steps.Push(current);
            current *= 2;
        }

        public void Reset()
        {
            steps.Clear();
            current = 1;
        }

        public void Undo()
        {
            current = steps.Pop();
        }

        public int Current
        {
            get
            {
                return current;
            }
        }

        public int Finish
        {
            get
            {
                return finish;
            }
        }

        public int StepsDone
        {
            get
            {
                return steps.Count;
            }
        }

        public int MinSteps
        {
            get
            {
                return GetMinSteps(finish);
            }
        }
    }
}
