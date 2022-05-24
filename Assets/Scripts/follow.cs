using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public Vector3 firstTarget;

    void Update()
    {
        transform.position = target.position + offset - firstTarget;
    }
}
