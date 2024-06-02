using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    public float Speed;

    void Update()
    {
        transform.position +=  Vector3.left * Speed * Time.deltaTime;
    }
}
