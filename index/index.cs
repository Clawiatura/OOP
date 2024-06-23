using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace zxc;
public class Zxc
{
    private string[] mas;

    public Zxc(int n)
    {
        this.mas = new string[n];
    }
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < mas.Length)
                return mas[index];
            else throw new ArgumentOutOfRangeException();
        }
        set
        {
            if (index >= 0 && index <= mas.Length)
                mas[index] = value;
        }

    }
    public string[] Concat(string[] sourse)
    {
        string[] res = new string[sourse.Length];
        for (int i = 0; i < sourse.Length; i++)
        {
            res[i] = mas[i] + (sourse[i]);
        }
        return res;
    }
    public string[] Union(string[] sourse)
    {
        string[] res = new string[sourse.Length];
        for (int i = 0; i < sourse.Length; i++)
        {
            if (mas[i] == sourse[i])
            {
                List<string> tempList = new List<string>(mas);
                tempList.RemoveAt(i);
                mas = tempList.ToArray();

            }
            res[i] = mas[i] + (sourse[i]);
        }

        return res;
    }
    public void print(string[] sourse)
    {
        string[] res = new string[sourse.Length];
        for (int i = 0; i < sourse.Length; i++)
        {
            res[i] = mas[i] + (sourse[i]);
            Console.WriteLine(res[i]);
        }
    }

    public void printIndex(int index)
    {
        for (int i = 0; i <= mas.Length; i++)
        {
            if (mas[i] == index.ToString());
            {
                Console.WriteLine(mas[index-1]); break;
            }
            {

            }
        }
    }
}




