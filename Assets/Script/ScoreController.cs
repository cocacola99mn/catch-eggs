using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;

    private int score;
    void Start()
    {
        
    }
    void Update()
    {
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Egg")
        {
            Destroy(target.gameObject);
            score++;
        } 
        if(target.tag == "Death")
        {
            Destroy(target.gameObject);
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }
}
