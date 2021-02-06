using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    

    public int death = 0;
    public int wins = 0;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        Jump.OnDead += Died;
    }

    void Died() {
        death++;
    }

    // Update is called once per frame
    void Update()
    {
        
        scoreText.text = "Deaths: " + death + " Wins: " + wins;
    } 
}
