using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public int score;
    public Text text;
    public GameObject BackGround1;
    public GameObject BackGround2;
    public void Start()
    {
        BackGround1.SetActive(true);
        BackGround2.SetActive(false);
    }
    public void addscore()
    {
        score++;
        text.text = score.ToString();
        if(score >= 5)
        {
            BackGround1.SetActive(false);
            BackGround2.SetActive(true);
        }
    }
}
