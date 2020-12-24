using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shootingandobtaining : MonoBehaviour
{
    public Text []Changableletters;
    public Transform[] Messages;
    public Transform[] objects;
    public AudioSource[] gunnoises;
    public bool keys;
    public int Objective;
    public int key;
    public int Ammo;
    int lights;
    bool Diggichasing;
    // Start is called before the first frame update
    void Start()
    {
        Objective = 0;
        lights = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Turn on and off the flashlights
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (lights == 1)
            {
                objects[2].gameObject.SetActive(false);
                lights = 0;
            } else if (lights == 0)
            {
                lights = 1;
                objects[2].gameObject.SetActive(true);
            }
        }
        //Make guns shoot their FX
        if (objects[3].gameObject.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                objects[4].GetComponent<ParticleSystem>().Play();
                gunnoises[0].Play();
            }
        }
        RaycastHit Hit;
        //Interacting and detecting objects
        if (Physics.Raycast(transform.position, transform.forward, out Hit, 30f))
        {
            Debug.Log(Hit.transform.name);
            if (Hit.transform.tag == "Keys") {
                Changableletters[0].gameObject.SetActive(true);
                Changableletters[0].text = "Press Q to interact with the keys";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    key += 1;
                    Hit.transform.gameObject.SetActive(false);
                    Changableletters[0].gameObject.SetActive(false);
                }
            }
            //Deduct health when shoot on diggi
            if (Hit.transform.tag == "Diggi")
            {
                if (objects[4].gameObject.activeInHierarchy == true)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        Hit.transform.GetComponent<diggiai>().Deducthealth();
                    }
                }
            }
            if (Hit.transform.tag == "Exterminator1")
            {
                Changableletters[0].gameObject.SetActive(true);
                Changableletters[0].text = "Press Q to interact with the exterminator";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    Changableletters[0].gameObject.SetActive(false);
                    Time.timeScale = 0f;
                    Messages[2].gameObject.SetActive(true);
                }
            }
            if (Hit.transform.tag == "door")
            {
                Changableletters[0].gameObject.SetActive(true);
                Changableletters[0].text = "Press Q to interact with the door";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    Changableletters[0].gameObject.SetActive(false);
                    if (keys == false)
                    {
                        Messages[0].gameObject.SetActive(true);
                    }
                    else
                    {
                        Hit.transform.gameObject.SetActive(false);
                        Objective = 3;
                    }
                }
            }
            if (Hit.transform.tag == "Terrain" || Hit.transform.tag == "House")
            {
                Changableletters[0].gameObject.SetActive(false);
            }
        }

        if (Messages[0].gameObject.activeInHierarchy == true || Messages[1].gameObject.activeInHierarchy == true)
        {
            Time.timeScale = 0f;
        }
        if (Vector3.Distance(transform.position, objects[0].transform.position) < 30f)
        {
            if (Objective < 2)
            {
                Objective = 1;
            }
        } else
        {
            if (Objective < 2)
            {
                Objective = 0;
            }
        }

        if (Time.timeScale == 1f)
        {
            if (Objective == 0)
            {
                Changableletters[1].gameObject.SetActive(true);
                Changableletters[2].gameObject.SetActive(false);
            }
            if (Objective == 1)
            {
                Changableletters[1].gameObject.SetActive(false);
                Changableletters[2].gameObject.SetActive(true);
                Changableletters[5].gameObject.SetActive(false);
            }
            if (Objective == 2)
            {
                Changableletters[1].gameObject.SetActive(false);
                Changableletters[2].gameObject.SetActive(false);
                Changableletters[3].gameObject.SetActive(true);
                Changableletters[5].gameObject.SetActive(false);
                Changableletters[6].gameObject.SetActive(true);
            }
            if (Objective == 3)
            {
                Changableletters[1].gameObject.SetActive(false);
                Changableletters[2].gameObject.SetActive(false);
                Changableletters[3].gameObject.SetActive(false);
                Changableletters[5].gameObject.SetActive(true);
                Changableletters[6].gameObject.SetActive(false);
            }
            if (Objective == 4)
            {
                Changableletters[7].gameObject.SetActive(true);
                Changableletters[1].gameObject.SetActive(false);
                Changableletters[2].gameObject.SetActive(false);
                Changableletters[3].gameObject.SetActive(false);
                Changableletters[5].gameObject.SetActive(false);
                Changableletters[6].gameObject.SetActive(false);
            }
        } else
        {
            Changableletters[7].gameObject.SetActive(false);
            Changableletters[1].gameObject.SetActive(false);
            Changableletters[2].gameObject.SetActive(false);
            Changableletters[3].gameObject.SetActive(false);
            Changableletters[4].gameObject.SetActive(false);
            Changableletters[5].gameObject.SetActive(false);
            Changableletters[6].gameObject.SetActive(false);
        }

        if (Vector3.Distance(objects[1].transform.position, transform.position) < 15f)
        {
            objects[1].GetComponent<diggiai>().chasing = true;
        }

        if (Vector3.Distance(objects[5].transform.position, transform.position) < 15f)
        {
            objects[5].GetComponent<diggiai>().chasing = true;
        }

        if (objects[1].GetComponent<diggiai>().chasing == true || objects[5].GetComponent<diggiai>().chasing == true || objects[6].GetComponent<diggiai>().chasing == true || objects[7].GetComponent<diggiai>().chasing == true || objects[8].GetComponent<diggiai>().chasing == true || objects[9].GetComponent<diggiai>().chasing == true)
        {
            Changableletters[7].gameObject.SetActive(false);
            Changableletters[1].gameObject.SetActive(false);
            Changableletters[2].gameObject.SetActive(false);
            Changableletters[3].gameObject.SetActive(false);
            Changableletters[5].gameObject.SetActive(false);
            Changableletters[6].gameObject.SetActive(false);
            Changableletters[4].gameObject.SetActive(true);
        }
        else
        {
            Changableletters[4].gameObject.SetActive(false);
        }
        if (key >= 5)
        {
            keys = true;
            Objective = 3;
        }

        if (Changableletters[6].gameObject.activeInHierarchy == true)
        {
            Changableletters[6].text = key.ToString();
        }
        if (objects[3].gameObject.activeInHierarchy == true)
        {
            Changableletters[9].text = Ammo.ToString();
            if (Ammo >= 1)  
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Ammo -= 1;
                }
            }
        }
        if (Ammo <= 1)
        {
            StartCoroutine(Reloadammo());
        }
    }

    public void startthegameagain() 
    {
        Time.timeScale = 1f;
        Objective = 2;
    }
    public void startthegameagai2()
    {
        Time.timeScale = 1f;
        Objective = 4;
        objects[3].gameObject.SetActive(true);
        Changableletters[8].gameObject.SetActive(true);
        Ammo = 30;
    }

    IEnumerator Reloadammo()
    {
        yield return new WaitForSeconds(5f);
        Ammo = 30;
    }
}
