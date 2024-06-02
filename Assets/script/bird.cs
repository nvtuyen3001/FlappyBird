using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
public class bird : MonoBehaviour
{
    Rigidbody2D rg;
    public float speed;
    public GameObject gameOverOBJ;
    public GameObject message;
    void Start()
    {
        Time.timeScale = 1.0f;
        message.GetComponent<SpriteRenderer>().enabled = true;
        rg = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if( Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            Sounds.instance.PlayThisSound("wing");
            rg.AddForce(Vector2.up * speed);
            message.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(0);
    }
    void GameOver()
    {
        Sounds.instance.PlayThisSound("die");

        gameOverOBJ.SetActive(true);
        Time.timeScale = 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver();
    }
}
