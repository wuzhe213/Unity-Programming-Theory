using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    private GameObject prefab;
    private GameObject instance;

    public Animal(GameObject prefab)
    {
        this.prefab = prefab;
        instance = Instantiate(prefab, Vector3.zero, prefab.transform.rotation);
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
