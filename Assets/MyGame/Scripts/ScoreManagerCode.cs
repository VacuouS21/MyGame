using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerCode : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public Text scoreDisplay;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("TrueObstacle"))
        {
            score++;
        }
    }
    }
