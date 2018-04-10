using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meal_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter How Many Members :");
            int members = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter Members Name : ");
            string[] member_name = new string[100];
            for(int i=0;i<members ;i++)
            {
                Console.Write((i+1).ToString()+":");
                member_name[i] = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Enter Per Members Meal : ");
            double[] member_meal = new double[100];
            for (int i = 0; i < members; i++)
            {
                Console.Write(member_name[i] + ":");
                member_meal[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Enter Per Members Bazar Cost : ");
            double[] member_bazar = new double[100];
            for (int i = 0; i < members; i++)
            {
                Console.Write(member_name[i] + ":");
                member_bazar[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("----------------------------------------");

            double totalMeal=0;
            for(int i=0;i<members ;i++)
            {
                totalMeal = totalMeal + member_meal[i];
            }
            Console.WriteLine("Total Meal :"+totalMeal);

            double totalBazarCost = 0;
            for (int i = 0; i < members; i++)
            {
                totalBazarCost = totalBazarCost + member_bazar[i];
            }
            Console.WriteLine("Total Bazar Cost :" + totalBazarCost);

            double perMealCost = 0;
            perMealCost = Math.Round((totalBazarCost / totalMeal),2);
            Console.WriteLine("Per Meal Cost :" + perMealCost);
            Console.WriteLine("----------------------------------------");


            Console.WriteLine("Per Members Meal Cost : ");
            double[] member_meal_cost = new double[100];
            for (int i = 0; i < members; i++)
            {
                member_meal_cost[i] = Math.Round(perMealCost * member_meal[i],2);
            }
            for (int i = 0; i < members; i++)
            {
                Console.WriteLine(member_name[i] + ":" + member_meal_cost[i]);
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");



            Console.WriteLine("Total Bazar Cost Calculation:");
            double[] member_meal_cost_Calc = new double[100];
            for (int i = 0; i < members; i++)
            {
                member_meal_cost_Calc[i] = Math.Round((member_meal_cost[i] - member_bazar[i]), 2);
            }
            for (int i = 0; i < members; i++)
            {
                string m;
                if(member_meal_cost_Calc[i]>0)
                {
                    m = "Given";
                }
                else
                {
                    m = "Taken";
                }
                Console.WriteLine(member_name[i] + ":" + member_meal_cost_Calc[i] +"("+ m +")");
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");




            //Console.WriteLine("Check");
            //for (int i = 0; i < members; i++)
            //{
            //    Console.WriteLine(member_name[i] + ":" + member_meal_cost[i]);
            //}



            Console.ReadKey();
        }
    }
}
