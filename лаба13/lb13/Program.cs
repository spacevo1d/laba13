using lb13;
try
{
    #region zadanie1
    //var a = new Spisok();
    //int x;
    //string y = Console.ReadLine();
    //while (y != "")
    //{
    //    x = Convert.ToInt32(y);
    //    if (Math.Abs(x) <= 1000)
    //    {
    //        if (a.count == 0 || a.count == 1)
    //        {
    //            a.Add(new Node(x));
    //        }
    //        else
    //        {
    //            if (Math.Abs(a.First().data - x) < Math.Abs(a.Last().data - x))
    //            {
    //                a.AddFirst(new Node(x));
    //            }
    //            else
    //            {
    //                a.Add(new Node(x));
    //            }
    //        }
    //        y = Console.ReadLine();
    //    }
    //    else
    //    {
    //        Console.WriteLine("Число должно быть по модулю меньше 1000!");
    //    }
    //}
    //a.print();
    #endregion
    #region zadanie2
    //var sp1 = new Spisok();
    //var sp2 = new Spisok();
    //string str;
    //var f = new StreamReader(@"..\..\..\1.txt");
    //while ((str = f.ReadLine()) != null)
    //{
    //    sp1.Add(new Node(Convert.ToInt32(str)));
    //}
    //f.Close();
    //f = new StreamReader(@"..\..\..\2.txt");
    //while ((str = f.ReadLine()) != null)
    //{
    //    sp2.Add(new Node(Convert.ToInt32(str)));
    //}
    //f.Close();
    //int temp = sp1.Count() / 2;
    //sp1.print();
    //sp2.print();
    //var sp3=new Spisok();
    //////Задание 2.a
    ////var tp=sp1.First();
    ////for(int i=0; i<temp-1; i++)
    ////{
    ////    tp = tp.next;
    ////}
    ////var tp1 = tp.next;
    ////tp.next = sp2.head;
    ////sp3.Add(tp);
    ////sp3.Add(tp1);
    ////sp3.print();


    //////Задание 2.б
    //var tp = sp1.First();
    //var tp2 = sp2.First();
    //while (tp != null && tp2 != null)
    //{
    //    sp3.Add(new Node(tp.data));
    //    sp3.Add(new Node(tp2.data));
    //    tp = tp.next;
    //    tp2 = tp2.next;
    //}
    //if (tp == null)
    //{
    //    sp3.Add(tp2);
    //}
    //else if (tp2 == null)
    //{
    //    sp3.Add(tp);
    //}
    //sp3.print();
    #endregion
    #region zadanie3
    //var a = new System.Collections.Generic.LinkedList<int>();
    //int x;
    //string y = Console.ReadLine();
    //while (y != "")
    //{
    //    x = Convert.ToInt32(y);
    //    if (Math.Abs(x) <= 1000)
    //    {
    //        if (a.Count == 0 || a.Count == 1)
    //        {
    //            a.AddLast(x);
    //        }
    //        else
    //        {
    //            if (Math.Abs(a.First() - x) < Math.Abs(a.Last() - x))
    //            {
    //                a.AddLast(x);
    //            }
    //            else
    //            {
    //                a.AddLast(x);
    //            }
    //        }
    //        y = Console.ReadLine();
    //    }
    //    else
    //    {
    //        Console.WriteLine("Число должно быть по модулю меньше 1000!");
    //    }
    //}
    //print(a);
    #endregion
    #region zadanie4
    Console.WriteLine("Введите кол-во чисел:");
    int n = Convert.ToInt32(Console.ReadLine());
    var a = new SpisokC<int>();
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Введите число:");
        a.Add(new Node1<int>(Convert.ToInt16(Console.ReadLine())));
    }
    Console.WriteLine("Какое число искать после команд?");
    int y=Convert.ToInt32(Console.ReadLine());
    var tek = a.head;
    Console.WriteLine("Введите кол-во команд:");
    n = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Введите комманду:");
        string str = Console.ReadLine();
        var str1 = str.Split(" ");
        for (int j = 0; j < Convert.ToInt16(str1[1]); j++)
        {
            if (str1[0] == "R")
            {
                a.Del(tek.next.data);
                tek = tek.next;
            }
            else if (str1[0] == "L")
            {
                a.Del(tek.prev.data);
                tek = tek.prev;
            }
        }
    }
    Console.WriteLine(a.ToString());
    if(a.Exist(y))
    {
        Console.WriteLine($"Число {y} есть в списке");
    }
    else
    {
        Console.WriteLine($"Числa {y} нет в списке");
    }
    #endregion



    void print(LinkedList<int> arr)
    {
        var temp = arr.First;
        Console.Write("Список:" + temp.Value + " ");
        while (temp.Next != null)
        {
            temp = temp.Next;
            Console.Write(temp.Value + " ");
        }
    }
}
catch(Exception e) {
    Console.WriteLine(e.Message);
}