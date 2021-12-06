using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;
    public float Xincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public float minX;
    public float maxX;
    public int health = 5;
    public Text healthDisplay;

    private float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
        targetPos =new Vector2( transform.position.x,transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        healthDisplay.text = health.ToString();

        if (time > 0f)
        {
            // Subtract the difference of the last time the method has been called
            time -= Time.deltaTime;
        }

        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.W) && transform.position.y < maxHeight && time <= 0)
        {
            time = 0.15f;
            targetPos =new Vector2(transform.position.x,transform.position.y+Yincrement );
          
        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight && time <= 0)
        {
            time = 0.15f;
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
           
        }
        else if (Input.GetKeyDown(KeyCode.D) && transform.position.x < maxX && time <= 0)
        {
            time = 0.15f;
            targetPos = new Vector2(transform.position.x+Xincrement, transform.position.y );

        }
        else if (Input.GetKeyDown(KeyCode.A) && transform.position.x > minX && time <= 0)
        {
            time = 0.15f;
            targetPos = new Vector2(transform.position.x-Xincrement, transform.position.y);
        }
    }
}
