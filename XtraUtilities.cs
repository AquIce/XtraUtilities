using System;

namespace XtraUtilities
{
    class Numbers
    {
        float number;
        int 
            piPrecision,
            maxE;
         
        public Numbers(float number)
        {
            this.number = number;
            this.piPrecision = 1000000;
        }

        public double Add(double baseNumber, double numberToAdd)
        {
            return baseNumber + numberToAdd;
        }

        public double Sub(double baseNumber, double numberToSub)
        {
            return baseNumber - numberToSub;
        }

        public double Mul(double baseNumber, double numberToMul)
        {
            return baseNumber * numberToMul;
        }

        public double Div(double baseNumber, double numberToDiv)
        {
            return baseNumber / numberToDiv;
        }

        public double Abs(double number)
        {
            if(number < 0)
            {
                return -number;
            }
            else
            {
                return number;
            }
        }

        public double Pow(double baseNumber, double exposant)
        {
            if (exposant < 0)
            {
                exposant = Abs(exposant);

                double result = 1;
                for (int i = 0; i < exposant; i++)
                {
                    result *= baseNumber;
                }

                return (1 / result);
            }
            else if (exposant == 0)
            {
                return 1;
            }

            else
            {
                double result = 1;
                for (int i = 0; i < exposant; i++)
                {
                    result *= baseNumber;
                }

                return result;
            }
        }

        public int Exp()
        {
            int exponential = Convert.ToInt32(this.number);

            for(int i = 1; i < Convert.ToInt32(this.number); i++)
            {
                exponential = exponential * Convert.ToInt32(this.number - i);
            }

            return exponential;
        }

        public int PiPrecision
        {
            get
            {
                return this.piPrecision;
            }
            set
            {
                Console.Write("Choose a precision number for pi : ");
                this.piPrecision = Convert.ToInt32(Console.ReadLine());
            }
        }
        public double Pi
        {
            get
            {
                double x = 0;

                for(int i = 1; i < PiPrecision; i += 2)
                {
                    if((i - 3) % 4 == 0)
                    {
                        x -= (1.0 / i);
                    }
                    else
                    {
                        x += (1.0 / i);
                    }
                }

                return x * 4;
            }
        }

        public int EPrecision
        {
            get
            {
                return this.maxE;
            }
            set
            {
                Console.Write("Choose a precision number for e : ");
                this.maxE = Convert.ToInt32(Console.ReadLine());
            }
        }

        public double E
        {
            get
            {
                double exp = Pow(1.0 + (1.0 / EPrecision), EPrecision);
                return exp;
            }
        }

        public double sig(double s)
        {
            double sigmoid = 1 / 1 + Pow(E, - s);
            return sigmoid;
        }
    }

    class List<T>
    {
        T[]
            list;

        public List(T[] list)
        {
            this.list = list;
        }

        public void PrintList()
        {
            Console.Write("{");

            for(int i = 0; i < this.list.Length; i++)
            {
                Console.Write(this.list[i]);

                if (i + 1 != this.list.Length)
                {
                    Console.Write(", ");
                }
            }

            Console.Write("}\n");
        }

        public void Reverse()
        {
            T[] reversed = new T[this.list.Length];

            for(int i = 0; i < this.list.Length; i++)
            {
                reversed[i] = this.list[(this.list.Length - 1) - i];
            }

            for (int i = 0; i < this.list.Length; i++)
            {
                this.list[i] = reversed[i];
            }
        }

        public double ListTot()
        {
            double total = 0;

            for(int i = 0; i < this.list.Length; i++)
            {
                total += Convert.ToDouble(this.list[i]);
            }

            return total;
        }

        public void AddToIndexes(T numberToAdd, int startIndex, int endIndex)
        {
            if(endIndex > this.list.Length - 1 || endIndex < startIndex || startIndex < 0)
            {
                return;
            }

            for (int i = startIndex; i < endIndex + 1; i++)
            {
                this.list[i] += numberToAdd;
            }
        }

        public void SubToIndexes(T numberToSub, int startIndex, int endIndex)
        {
            if(endIndex > this.list.Length - 1 || endIndex < startIndex || startIndex < 0)
            {
                return;
            }

            for (int i = startIndex; i < endIndex + 1; i++)
            {
                this.list[i] -= numberToSub;
            }
        }

        public void MulToIndexes(T numberToMul, int startIndex, int endIndex)
        {
            if(endIndex > this.list.Length - 1 || endIndex < startIndex || startIndex < 0)
            {
                return;
            }

            for (int i = startIndex; i < endIndex + 1; i++)
            {
                this.list[i] *= numberToMul;
            }
        }

        public void DivToIndexes(T numberToDiv, int startIndex, int endIndex)
        {
            if(endIndex > this.list.Length - 1 || endIndex < startIndex || startIndex < 0)
            {
                return;
            }

            for (int i = startIndex; i < endIndex + 1; i++)
            {
                this.list[i] /= numberToDiv;
            }
        }

        public void PowIndexes(int pow, int startIndex, int endIndex)
        {
            if(endIndex > this.list.Length - 1 || endIndex < startIndex || startIndex < 0)
            {
                return;
            }

            Numbers num = new Numbers(1);


            for (int i = startIndex; i < endIndex + 1; i++)
            {
                this.list[i] = num.Pow(this.list[i]), pow);
            }
        }

        public void Push(T number)
        {
            T[] temp = new T[this.list.Length];

            for(int i = 0; i < this.list.Length; i++)
            {
                temp[i] = this.list[i];
            }

            this.list = new T[this.list.Length + 1];

            for(int i = 0; i < this.list.Length - 1; i++)
            {
                this.list[i] = temp[i];
            }

            this.list[this.list.Length - 1] = number;
        }

        public void Pop()
        {
            T[] temp = new T[this.list.Length];

            for (int i = 0; i < this.list.Length; i++)
            {
                temp[i] = this.list[i];
            }

            this.list = new T[this.list.Length - 1];

            for (int i = 0; i < this.list.Length; i++)
            {
                this.list[i] = temp[i];
            }
        }

        public void Insert(T number, int index)
        {
            T[] temp1 = new T[index];

            for (int i = 0; i < temp1.Length; i++)
            {
                temp1[i] = this.list[i];
            }

            T[] temp2 = new T[this.list.Length - temp1.Length];

            for (int i = 0; i < temp2.Length; i++)
            {
                temp2[i] = this.list[i+temp1.Length];
            }

            this.list = new T[this.list.Length + 1];

            for (int i = 0; i < temp1.Length; i++)
            {
                this.list[i] = temp1[i];
            }

            this.list[index] = number;

            for(int i = 0; i < temp2.Length; i++)
            {
                this.list[i + temp1.Length + 1] = temp2[i];
            }
        }

        public void Remove(int index)
        {
            T[] temp1 = new T[index];

            for (int i = 0; i < temp1.Length; i++)
            {
                temp1[i] = this.list[i];
            }

            T[] temp2 = new T[this.list.Length - temp1.Length - 1];

            for (int i = 0; i < temp2.Length; i++)
            {
                temp2[i] = this.list[i + temp1.Length + 1];
            }

            this.list = new T[this.list.Length - 1];

            for (int i = 0; i < temp1.Length; i++)
            {
                this.list[i] = temp1[i];
            }

            for (int i = 0; i < temp2.Length; i++)
            {
                this.list[i + temp1.Length] = temp2[i];
            }
        }

        public void Reset()
        {
            this.list = new T[this.list.Length];
        }

        public void FillWith(double number)
        {
            for(int i = 0; i < this.list.Length; i++)
            {
                this.list[i] = number;
            }
        }

        public void Extend(int numberOfIndexesToAdd)
        {
            T[] temp = new double[this.list.Length];

            for(int i = 0; i < this.list.Length; i++)
            {
                temp[i] = this.list[i];
            }

            this.list = new T[this.list.Length + numberOfIndexesToAdd];

            for (int i = 0; i < temp.Length; i++)
            {
                this.list[i] = temp[i];
            }
        }

        public void ExtendWith(int numberOfIndexesToAdd, double value)
        {
            T[] temp = new double[this.list.Length];

            for (int i = 0; i < this.list.Length; i++)
            {
                temp[i] = this.list[i];
            }

            this.list = new T[this.list.Length + numberOfIndexesToAdd];

            for (int i = 0; i < temp.Length; i++)
            {
                this.list[i] = temp[i];
            }

            for(int i = temp.Length; i < this.list.Length; i++)
            {
                this.list[i] = value;
            }
        }

        public void ResetToDim(int length)
        {
            this.list = new T[length];
        }

        public void ResetAndFill(int length, double value)
        {
            this.ResetToDim(length);
            this.FillWith(value);
        }

        public int[] Find(double value)
        {
            int[] indexesFound;
            int count = 0;
            for(int i = 0; i < this.list.Length; i++)
            {
                if (this.list[i] == value)
                {
                    count++;
                }
            }
            
            indexesFound = new int[count];

            int j = 0;

            for (int i = 0; i < this.list.Length; i++)
            {
                if (this.list[i] == value)
                {
                    indexesFound[j] = i;
                    j++;
                }
            }

            return indexesFound;
        }
    }

    class Functions
    {
        double
            x,
            y;

        public Functions(double x)
        {
            this.x = x;
        }

        public void SetToConstant(double output)
        {
            this.y = output;
        }

        public void SetToLinear(double factor)
        {
            this.y = this.x * factor;
        }

        public void SetToAffin(double factor, double term)
        {
            this.y = this.x * factor + term;
        }

        public void SetToQuad(int degree, double factor, double term)
        {
            Numbers num = new Numbers(0);

            this.y = num.Pow(this.x, degree) * factor + term;
        }
    }

    class Equations
    {
        public class OneOne
        {
            double
                factorOne,
                termOne,
                factorTwo,
                termTwo;

            public OneOne(double factorOne, double termOne, double factorTwo, double termTwo)
            {
                this.factorOne = factorOne;
                this.termOne = termOne;
                this.factorTwo = factorTwo;
                this.termTwo = termTwo;
            }

            public string Canonic()
            {
                double term = this.termOne - this.termTwo;
                term /= factorTwo;
                double factor = this.factorOne - this.factorTwo;

                string Res = Convert.ToString(factor) + "x " + Convert.ToString(term);

                return Res;
            }
        }
    }
}