using System;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace EnumsExtensions
{
    enum CharacterType
    {
        Warrior,
        Mage,
        Archer,
        Monach,
        Shaman,
        Paladin,
        Rogue,
        Druid
    }

    enum AttackType
    {
        Melee,
        Range,
        Magic,
    }


    enum GameState
    {
        Start,
        Pause,
        Resume,
        End
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enums
            //WeekOfDay weekOfDay = WeekOfDay.Monday;
            //Console.WriteLine(Enum.GetUnderlyingType(typeof(WeekOfDay)));

            //WeekOfDay weekOfDay = (WeekOfDay)12;

            //if(Enum.IsDefined(typeof(WeekOfDay), weekOfDay))
            //{
            //    Console.WriteLine(weekOfDay);

            //}
            //else
            //{
            //    Console.WriteLine("No Enum with that code");
            //}

            //var days = (WeekOfDay[])Enum.GetValues(typeof(WeekOfDay));


            //for (int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            //int index = 0;
            //while (index < 7)
            //{
            //    Console.WriteLine((WeekOfDay)index);
            //    index++;
            //}

            #endregion

            string name = "Tural";

            name.ModifyAndShow();






        }

    }
 


}
