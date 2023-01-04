using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace project
{
    class CustInfo
    {//fields
       public int Id;
      public string Name;
      public string Number;
      }
      class cus{
        public static void Main(string[] args){
            Console.WriteLine("enter number of persons:");
            //string a;
            int b;
            b=Convert.ToInt32(Console.ReadLine());
           
            List <CustInfo> clist = new List<CustInfo>();//List defination
            int vcusId;
            string VcusName;
            string VcusNum;
            for(int i=1;i<=b;i++)//accepting the customer details
            {
                Console.WriteLine($"Enter the id");
                vcusId=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter the name");
                VcusName = Console.ReadLine();
                Console.WriteLine($"Enter the name");
                VcusNum= Console.ReadLine();
                clist.Add(new CustInfo {Id=vcusId , Name= VcusName , Number = VcusNum} );
            }
            filewrite(clist);
            fileread(clist);
        }
        static void filewrite(List <CustInfo> clist){
             string str;
              StreamWriter f = File.CreateText(@"C:\Example\diamond.dat");//writing in file
                foreach(CustInfo c in clist){
                    str = c.Id.ToString()+","+c.Name+","+c.Number;
                    Console.WriteLine(str);
                    f.WriteLine(str);
                }
                f.Close();
                }
                //read from file
                static void fileread(List <CustInfo> clist){
                StreamReader fil = new StreamReader(@"C:\project1\firstProject\demo.dat");//reading from file
                string s=fil.ReadLine();
                string[] arr=s.Split(',');
                int n =Convert.ToInt32(arr[0]);
                clist.Add(new CustInfo{Id=n , Name= arr[1] , Number = arr[2]});
                Console.WriteLine("the datails are");
                foreach(CustInfo cust in clist){//display
                    Console.WriteLine(" {0}",cust.Id);
                    Console.Write(" {0}",cust.Name);
                    Console.Write(" {0}",cust.Number);
                }
                }
    }
    }