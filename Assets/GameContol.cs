using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    [SerializeField]
    public GameObject gameOverText;
    public Text scoreText;
    public static GameControl instance;
    public bool gameOver = false;
    
    public float scrollSpeed = -1.5f;

    private int score = 0;
    private int scoredeaths= 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (gameOver == true  && Input.GetKeyDown(KeyCode.Space))
        { 
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void Scored()
    {
        if (gameOver)
        {
            enabled = false;
            SceneManager.LoadScene("SampleScene");

        }
        score++;
        scoreText.text = "Wins:  " + score.ToString();
    }

    public void Died()
    {
        gameOver = true;

        if (gameOver == true)
        {
            gameOverText.SetActive(true);
        }
        scoredeaths++;
    }

    

}