using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // ArrayList : 아무타입이나 넣고 크기 자유롭게 변함, 살짝 느림(사용 잘 안함)
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("1");
            arrayList.Add(true);

            List<int> iList = new arrayList<int>(); // (리스트) : value를 넣는 일반적인 자료구조, 자주 쓰임
            //iList.Contanins


            intList.Add(2);
            intList.Add(1);
            intList.Add(3);
            intList.Sort();


            Dictionary<int, string> myDic = new Dictionary<int, string>(); // (elrtusjfl) : key, value
            //myDic.ADD(2, "2번");
            string value = myDic[2];
            //myDic.Containskey();
            //myDic.ContainsValue();


            Stack<int> myStack = new Stack<int>; //(스택) : 마지막에 넣은게 뽑힘(LIFO)
            myStack.Push(1); 
            Quene<int>(큐) : 처음 넣은게 뽑힘(LIFO)
        }
    }
}
