using zxc;

Zxc zxc = new Zxc(12);
zxc[0] = "Hello";
zxc[1] = "QQQ";
zxc[2] = "Hello";

Console.WriteLine("Введите индекс числа:");
int n = int.Parse(Console.ReadLine());
zxc.printIndex(n);

string[] nums1 = new string[] { zxc[0], zxc[1], zxc[2] };
zxc.Concat(nums1);
zxc.Union(nums1);
zxc.print(nums1);

