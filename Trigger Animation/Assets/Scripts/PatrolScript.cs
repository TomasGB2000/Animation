using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolScript : MonoBehaviour
{
    /***************************************************************************************
* Title: PATROL AI WITH UNITY AND C# - EASY TUTORIAL
* Author: BlackThornProd
* Date: 2018
* Code version: N/A
* Availability: https://www.youtube.com/watch?v=8eWbSN2T8TE
***************************************************************************************/
    public float speed;
    private float waitTime;
    public float startWaitTime;

    public Transform[] moveSpots;
    private int randomspot;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        randomspot = Random.Range(0, moveSpots.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveSpots[randomspot].position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, moveSpots[randomspot].position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                randomspot = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}
