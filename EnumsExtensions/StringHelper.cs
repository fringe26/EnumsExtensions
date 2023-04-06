using System;

namespace EnumsExtensions
{
    public static class StringHelper
    {
        public static void ModifyAndShow(this string value)
        {
            string result = value + " Salam";
            Console.WriteLine(result);
        }

    }

    public static class EnemyHelper
    {
        public static void Attack(this Enemy enemy, string enemyName)
        {
            Console.WriteLine("Attack " + enemyName);
        }
    }


    public class Enemy
    {
        public string Name { get; set; }
    }
}
