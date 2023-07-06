namespace ListOfMethods
{
    public class Methods
    {
        public static void PrintArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
        public static string[] CreateArray(int size)
        {
            string[] res = new string[size];
            for (int i = 0; i < size; i++)
            {
                res[i] = Convert.ToString(new Random().Next(0, 10000));

            }
            return res;
        }


        public static string[] CopiArray(string[] arr)
        {
            string[] res = new string[arr.Length];
            Array.Copy(arr, res, arr.Length);
            return res;
        }

        public static string[] LengthElement(string[] arr)
        {
            string[] res = new string[] { };
            int j = 0;
            foreach (var item in arr)
            {
                if (item.Length <= 3)
                {
                    Array.Resize(ref res, res.Length + 1);
                    res[j] = item;
                    j++;
                }
            }
            return res;
        }

        public static string[] LengthElementSort(string[] arr)
        {
            int size = arr.Length;
            SortQuick(arr, 0, size - 1);
            string[] res = new string[] { };
            int j = 0;
            foreach (var item in arr)
            {
                if (item.Length <= 3)
                {
                    Array.Resize(ref res, res.Length + 1);
                    res[j] = item;
                    j++;
                }
                else break;
            }
            return res;
        }

        public static string[] SortQuick(string[] collection, int left, int right)
        {
            int i = left;
            int j = right;

            int pivot = collection[Random.Shared.Next(left, right)].Length;
            while (i <= j)
            {
                while (collection[i].Length < pivot) i++;
                while (collection[j].Length > pivot) j--;

                if (i <= j)
                {
                    string t = collection[i];
                    collection[i] = collection[j];
                    collection[j] = t;
                    i++;
                    j--;
                }
            }
            if (i < right) SortQuick(collection, i, right);
            if (left < j) SortQuick(collection, left, j);
            return collection;
        }

        public static string[] LengthElement1(string[] el)
        {
            string[] newarray = new string[el.Length];

            for (int i = 0; i < el.Length; i++)
            {
                if (el[i].Length <= 3)
                {
                    newarray[i] = el[i];
                }
            }
            return newarray;
        }
        static void Main() { }
    }
}