using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16q
{
    public class Officer : Character
    {


        public Officer(string name, int health, Position position) : base(name, health, position) { }

        public Officer() : base() { }
        public override void Displayifo()
        {
            Debug.Log("Officer ");
            base.Displayifo();
        }
    }
}