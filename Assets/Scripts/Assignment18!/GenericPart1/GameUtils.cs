using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18q
{
    public class GameUtils
    {

        public static string DescribeItem<T>(T something)
        {
            return "This item is a " + something.ToString();
        }

    }
}