using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{
    public static UIScore instance;

    public Text scoreText;

    int score = 0;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = score.ToString();
    }

    public void AddPoint() 
    {
        score += 10;
        scoreText.text = score.ToString();
    }


    void Update()
    {
        
    }
}
