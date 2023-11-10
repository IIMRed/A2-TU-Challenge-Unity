using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        

        internal static int Add(int a, int b)
        {
            throw new NotImplementedException();
        }

        internal static List<int> GenericSort(List<int> toSort, Func<int, int, bool> isInOrder)
        {
            throw new NotImplementedException();
        }

        internal static List<int> GetAllPrimary(int a)
        {
            throw new NotImplementedException();
        }

        internal static bool IsDivisible(int a, int b)
        {
            throw new NotImplementedException();
        }

        internal static bool IsEven(int a)
        {
            throw new NotImplementedException();
        }

        internal static bool IsInOrder(int a, int b)
        {
            throw new NotImplementedException();
        }

        internal static bool IsInOrderDesc(int arg1, int arg2)
        {
            throw new NotImplementedException();
        }

        internal static bool IsListInOrder(List<int> list)
        {
            throw new NotImplementedException();
        }

        internal static bool IsMajeur(int age)
        {
            if (age < 0) throw new ArgumentException();

            //return age >= 18;
            if (age >= 18) return true; 
            else return false;
        }

        internal static bool IsPrimary(int a)
        { 
            for(int i = 2; i <= Mathf.Sqrt(a); i++)
            {
                if(a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        internal static int Power(int a, int b)
        {
            throw new NotImplementedException();
        }

        internal static int Power2(int a)
        {
            throw new NotImplementedException();
        }

        internal static List<int> Sort(List<int> toSort)
        {
            throw new NotImplementedException();
        }
    }
}
