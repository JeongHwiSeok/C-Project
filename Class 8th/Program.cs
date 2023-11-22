using System;
using System.Collections;
using System.Collections.Generic;

namespace Class_8th
{
    public class GameObject
    {
        private string name;
        
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 콜렉션

            #region ArrayList
            //ArrayList arrayList = new ArrayList();

            //arrayList.Add(10);
            //arrayList.Add("String");
            //arrayList.Add(57.5f);
            //arrayList.Add('A');

            //foreach(object element in arrayList)
            //{
            //    Console.WriteLine(element);
            //}

            //arrayList.Remove(10);

            //Console.WriteLine("");
            //Console.WriteLine("arrayList Count : " + arrayList.Count);

            //foreach (object element in arrayList)
            //{
            //    Console.WriteLine(element);
            //}
            #endregion

            #region List
            //List<string> list = new List<string>();

            //list.Capacity = 10;

            //list.Add("메이플스토리");
            //list.Add("서든어택");
            //list.Add("바람의나라");
            //list.Add("피파온라인");
            //list.Add("마구마구");

            #endregion

            #region LinkedList
            //LinkedList<int> linkedList = new LinkedList<int>();

            //linkedList.AddFirst(10);
            //linkedList.AddFirst(20);
            //linkedList.AddLast(100);

            //foreach(int element in linkedList)
            //{
            //    Console.WriteLine(element);
            //}

            #endregion

            #region Random 클래스
            //Random random = new Random();
            //int[] a = new int[43];
            ////for (int i = 5; i > 0; i--)
            ////{
            ////    int rand = random.Next(0, i);
            ////    Console.WriteLine("Game name : " + list[rand]);
            ////    list.RemoveAt(rand);

            ////}
            //for (int i = 0; i < 5; i++)
            //{
            //    int rand = random.Next(1, 20);
            //    if (a[rand] == 0)
            //    {
            //        a[rand]++;
            //        Console.WriteLine(rand);
            //    }
            //}
            //Console.WriteLine("");
            //for (int i = 0; i < 5; i++)
            //{
            //    int rand = random.Next(21, 43);
            //    if (a[rand] == 0)
            //    {
            //        a[rand]++;
            //        Console.WriteLine(rand);
            //    }
            //}
            #endregion

            #region Stack
            //Stack<int> stack = new Stack<int>();

            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //stack.Push(40);
            //stack.Push(50);

            //stack.Pop();
            //Console.WriteLine("Stack Peek : " + stack.Peek());

            //foreach(var element in stack)
            //{
            //    Console.WriteLine(element);
            //}

            #endregion

            #region Queue
            //Queue<GameObject> queue = new Queue<GameObject>();
            //string[] objectName = new string[4] { "Cube", "Sphere", "Capsule", "Cylinder" };

            //queue.Enqueue(new GameObject());
            //queue.Enqueue(new GameObject());
            //queue.Enqueue(new GameObject());
            //queue.Enqueue(new GameObject());

            //int queueSize = queue.Count;

            //for(int i = 0; i < queueSize; i++)
            //{
            //    GameObject gameObject = queue.Dequeue();
            //    gameObject.Name = objectName[i];
            //    Console.WriteLine(gameObject.Name);
            //}
            #endregion

            #region HashTable
            //Hashtable hashTable = new Hashtable();

            //// Key - Value
            //hashTable.Add("Sword", 1000);
            //hashTable.Add('A', 57.5f);

            //foreach(DictionaryEntry pair in hashTable)
            //{
            //    Console.WriteLine("Key : " + pair.Key + " " + "Value : " + pair.Value);
            //}

            #endregion

            #region Dictionary
            //Dictionary<string, int> dictionary = new Dictionary<string, int>();

            //dictionary.Add("MapleStory", 2003);
            //dictionary.Add("League of Legend", 2011);
            //dictionary.Add("MiniFighter", 2003);

            //if(dictionary.ContainsKey("MapleStory"))
            //{
            //    Console.WriteLine("Key가 존재합니다.");
            //}

            //foreach(var element in dictionary)
            //{
            //    Console.WriteLine(element);
            //}
            #endregion

            #endregion
        }
    }
}
