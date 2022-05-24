using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public enum Type { doll, coin };
    public Type type;
    public int value;

    void Update()
    {
        transform.Rotate(Vector3.up * 30 * Time.deltaTime);
        
    }
}
