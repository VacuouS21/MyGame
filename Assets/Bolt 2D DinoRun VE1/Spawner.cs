using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstacleVariants;
    public float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;
    // Start is called before the first frame update
   

    // Update is called once per frame
   private void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, obstacleVariants.Length);
            Instantiate(obstacleVariants[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            if( startTimeBtwSpawn> minTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }
           
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
