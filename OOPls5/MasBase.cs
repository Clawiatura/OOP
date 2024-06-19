namespace OOPls5
{
    internal class MasBase
    {
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= lenght)
                {
                    throw new IndexOutOfRangeException("Массив больше заданной длины");
                }
                return massiv1[index];
            }

            set
            {
                if (index < 0 || index >= lenght)
                {
                    throw new ArgumentOutOfRangeException("Массив больше заданной длины");
                }
                massiv1[index] = value;
            }

        }
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= lenght)
                {
                    throw new IndexOutOfRangeException("Массив больше заданной длины");
                }
                return massiv1[index];
            }

            set
            {
                if (index < 0 || index >= lenght)
                {
                    throw new ArgumentOutOfRangeException("Массив больше заданной длины");
                }
                massiv1[index] = value;
            }

        }
    }
}