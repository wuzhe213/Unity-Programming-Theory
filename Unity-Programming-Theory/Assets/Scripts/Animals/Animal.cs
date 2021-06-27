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
        Animator anim = Instance.GetComponent<Animator>();
        anim.SetInteger("Walk", 0);
        anim.SetInteger("Idle", 1);
    }

    public virtual void Walk()
    {
        Animator anim = Instance.GetComponent<Animator>();
        anim.SetInteger("Idle", 0);
        anim.SetInteger("Walk", 1);
        Debug.Log("anim:  " + anim + " cat walk");
    }

    public virtual void Jump()
    {
        Animator anim = Instance.GetComponent<Animator>();
        anim.SetTrigger("jump");
        anim.SetInteger("Walk", 0);
        anim.SetInteger("Idle", 0);
    }

}
