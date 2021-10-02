using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    public float gravity = -10f;

    public void Attract(Transform body)
    {
        Vector3 gravityUp = (body.position - transform.position).normalized;
        Vector3 bodyUp = body.up;

        body.GetComponent<Rigidbody>().AddForce(gravityUp * gravity);

        Quaternion targetrotation = Quaternion.FromToRotation(bodyUp, gravityUp) * body.rotation;

        body.rotation = Quaternion.Slerp(body.rotation, targetrotation, 50 * Time.deltaTime);
    }
}
