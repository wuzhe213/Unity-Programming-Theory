using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    private GameObject prefab;

    public GameObject Instance
    {
        get; set;
    }


    public GameObject Prefab
    {
        get { return prefab; }
    }

    public Animal(GameObject prefab)
    {
        this.prefab = prefab;
    }

    public virtual void Idle()
    {

    }

    public virtual void Walk()
    {

    }

    public virtual void Jump()
    {

    }

}
