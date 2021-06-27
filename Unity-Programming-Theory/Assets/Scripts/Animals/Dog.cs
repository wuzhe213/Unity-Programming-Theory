using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    public Dog(GameObject prefab) : base(prefab)
    {

    }

    public override void Idle()
    {
        base.Idle();
    }

    public override void Walk()
    {
        base.Walk();
    }

    public override void Jump()
    {
        base.Jump();
    }
}
