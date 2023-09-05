using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI livesText;
    [SerializeField] private int lives = 3;
    [SerializeField] private GameObject gameOver;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void ReceiveDamage()
    {
        if(lives > 1)
        {
            lives --;
            livesText.text = lives.ToString();
        }
        else
        {
            lives--;
            livesText.text = lives.ToString();
            gameOver.SetActive(true);
            Time.timeScale = 0f;
        }
        
    }
}
