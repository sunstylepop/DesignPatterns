using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        interface Isubject
        {
            void RegisterObserver(Iobserver obv);
            void RemoveObserver(Iobserver obv);
            void NotifyObserver(string message);
        }

        public interface Iobserver
        {
            void update(string message);
        }

        public class superMarket : Isubject
        {
            List<Iobserver> ObserverList = new List<Iobserver>();

            public void RegisterObserver(Iobserver User)
            {
                ObserverList.Add(User);
            }

            public void RemoveObserver(Iobserver user)
            {
                int userIndex = ObserverList.IndexOf(user);
                if (ObserverList.Count > 0 && userIndex >= 0)
                    ObserverList.RemoveAt(userIndex);
            }

            public void NotifyObserver(string message)
            {
                foreach (var i in ObserverList)
                    i.update(message);
            }




            //以下為包裝此Class 用的method 
            public void RigestCustomer(Iobserver user){
                RegisterObserver(user);
            }

            public void RemoveCustomer(Iobserver user)
            {
                RemoveObserver(user);
            }
            public void SendDM(string DMContent)
            {
                Console.WriteLine("send DM.....");
                NotifyObserver(DMContent);
            }
        }

        private class HouseWife : Iobserver
        {
            string _Name { get; set; }

            public HouseWife(string Name)
            {
                this._Name = Name;
            }
            
            //供Observer呼叫使用
            public void update(string messages)
            {
                Console.WriteLine(string.Format("    {0} get DM Content : {1}", _Name, messages));
            }

        }


        /* 觀察者模式
         * 實作家庭主婦像大賣場註冊會員
         * 大賣場會主動發送DM
         */
        static void Main(string[] args)
        {
            //透過此物件主動傳送資料給註冊使用者
            //需實作Isubject、Iobserver介面
            superMarket sm = new superMarket();

            HouseWife Judy = new HouseWife("Judy");
            HouseWife Mindy = new HouseWife("Mindy");

            //註冊
            sm.RigestCustomer(Judy);
            sm.RigestCustomer(Mindy);

            //傳送訊息給所有註冊者
            sm.SendDM("computer sale NT:$99");

            //取消註冊
            sm.RemoveCustomer(Mindy);

            sm.SendDM("desk sale NT:$20");

            Console.ReadLine();
            

        }
    }
}
