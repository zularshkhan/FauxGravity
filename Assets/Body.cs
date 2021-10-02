using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    public PlanetGravity attracter;

    private void Start()
    {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        GetComponent<Rigidbody>().useGravity = false;
    }

    private void Update()
    {
        attracter.Attract(transform);
    }
}
