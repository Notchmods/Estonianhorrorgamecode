using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diggiai : MonoBehaviour
{
    public Transform Player;
    public Transform[] Patrolpoints;
    public GameObject[] texts;
    private bool patrolpoint1;
    private bool patrolpoint2;
    private bool patrolpoint3;
    private bool patrolpoint4;
    private bool patrolpoint5;
    public bool chasing = false;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        //Make Diggi go to patrol point 1
        patrolpoint1 = true;
        //Set health
        health = 100;   
    }

    // Update is called once per frame
    void Update()
    {
        //End the game if he's extremely close to you
        if (Vector3.Distance(transform.position, Player.position) < 0.3f)
        {
            Debug.Log("Collided");
            texts[2].gameObject.SetActive(true);
            Time.timeScale = 0;
        }

        //If the distance is less than 10 metres
            if (Vector3.Distance(transform.position, Player.position) < 50f)
            {
                //Look at the player and follow them
                transform.LookAt(Player.transform);
                transform.Translate(Vector3.forward * 10f * Time.deltaTime);
                chasing = true;
             }else
             {
                chasing = false;
             }       

        if(chasing == false)
        {
            //Change to objective to normal objective
            if (Time.timeScale == 1)
            {

            }
            else
            {
                texts[1].gameObject.SetActive(false);
                texts[0].gameObject.SetActive(false);
            }
            //Detect whether they're close to the patrol points then change it
            if (Vector3.Distance(transform.position, Patrolpoints[0].transform.position) < 10f)
            {
                patrolpoint1 = false;
                patrolpoint2 = true;
                patrolpoint3 = false;
                patrolpoint4 = false;
                patrolpoint5 = false;
            }
            if (Vector3.Distance(transform.position, Patrolpoints[1].transform.position) < 10f)
            {
                patrolpoint1 = false;
                patrolpoint2 = false;
                patrolpoint3 = true;
                patrolpoint4 = false;
                patrolpoint5 = false;
            }
            if (Vector3.Distance(transform.position, Patrolpoints[2].transform.position) < 10f)
            {
                patrolpoint1 = false;
                patrolpoint2 = false;
                patrolpoint3 = false;
                patrolpoint4 = true;
                patrolpoint5 = false;
            }
            if (Vector3.Distance(transform.position, Patrolpoints[3].transform.position) < 10f)
            {
                patrolpoint1 = false;
                patrolpoint2 = false;
                patrolpoint3 = false;
                patrolpoint4 = false;
                patrolpoint5 = true;
            }
            if (Vector3.Distance(transform.position, Patrolpoints[4].transform.position) < 10f)
            {
                patrolpoint1 = true;    
                patrolpoint2 = false;
                patrolpoint3 = false;
                patrolpoint4 = false;
                patrolpoint5 = false;
            }
            //Head towards the points
            if (patrolpoint1 == true)
            {
                transform.LookAt(Patrolpoints[0].transform.position);
                transform.Translate(Vector3.forward * 10f * Time.deltaTime);
            }
            if (patrolpoint2 == true)
            {
                transform.LookAt(Patrolpoints[1].transform.position);
                transform.Translate(Vector3.forward * 10f * Time.deltaTime);
            }
            if (patrolpoint3 == true)
            {
                transform.LookAt(Patrolpoints[2].transform.position);
                transform.Translate(Vector3.forward * 10f * Time.deltaTime);
            }
            if (patrolpoint4 == true)
            {
                transform.LookAt(Patrolpoints[3].transform.position);
                transform.Translate(Vector3.forward * 10f * Time.deltaTime);
            }
            if (patrolpoint5 == true)
            {
                transform.LookAt(Patrolpoints[4].transform.position);
                transform.Translate(Vector3.forward * 10f * Time.deltaTime);
            }
        }


        if(health <= 0)
        {
            chasing = false;
            gameObject.SetActive(false);
        }
    }

    public void Deducthealth()
    {
        health -= 25;
    }

}

