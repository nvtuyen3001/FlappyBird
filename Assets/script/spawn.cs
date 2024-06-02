using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public Object pipe;
    public float maxTime;
    float timer;
    public float high;
    private void Update()
    {
        timer += Time.deltaTime;
        if(timer > maxTime)
        {
            timer = 0;
            Object tmp = Instantiate(pipe, new Vector3(transform.position.x, transform.position.y + Random.Range(-high, high)), Quaternion.identity);
            Destroy(tmp, 10f);
        }
    }
}
