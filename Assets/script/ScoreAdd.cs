using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdd : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindAnyObjectByType<Score>().addscore();
        Sounds.instance.PlayThisSound("point");

    }
}
