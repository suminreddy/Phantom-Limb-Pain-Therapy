using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMaster : MonoBehaviour
{

    public int tileColor;
    int timeInterval = 1;
    public float lengthCheck = 0;
    public GameObject[] tagFinder = new GameObject[12];
    // Use this for initialization
    void Start()
    {
        //initialize random number generator, this will create a number that corresponds to tile numbers. 
        tileColor = Random.Range(1, 6);

    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time >= lengthCheck)
        {
            print("the current time is: " + Time.time);
            print("tileColor is: " + tileColor);
            print("LengthCheck's value is: " + lengthCheck);



            switch (tileColor)
            {
                case 1:
                    tagFinder[0].SetActive(true);
                    tagFinder[0].GetComponent<Renderer>().material.color = Color.red;
                    tagFinder[3].SetActive(true);
                    tagFinder[3].GetComponent<Renderer>().material.color = Color.red;
                    tagFinder[1].SetActive(false);
                    tagFinder[2].SetActive(false);
                    tagFinder[4].SetActive(false);
                    tagFinder[5].SetActive(false);
                    tagFinder[6].SetActive(false);
                    tagFinder[7].SetActive(false);
                    tagFinder[8].SetActive(false);
                    tagFinder[9].SetActive(false);
                    tagFinder[10].SetActive(false);
                    tagFinder[11].SetActive(false);
                  
                    /*tagFinder[4].GetComponent<Renderer>().material.color = Color.clear;
                    tagFinder[5].GetComponent<Renderer>().material.color = Color.clear;
                    tagFinder[6].GetComponent<Renderer>().material.color = Color.clear;
                    tagFinder[7].GetComponent<Renderer>().material.color = Color.clear;
                    tagFinder[8].GetComponent<Renderer>().material.color = Color.clear;
                    tagFinder[9].GetComponent<Renderer>().material.color = Color.clear;
                    tagFinder[10].GetComponent<Renderer>().material.color = Color.clear;
                    tagFinder[11].GetComponent<Renderer>().material.color = Color.clear;*/ 
                    break;
                case 2:
                    tagFinder[1].SetActive(true);
                    tagFinder[1].GetComponent<Renderer>().material.color = Color.red;
                    tagFinder[2].SetActive(true);
                    tagFinder[2].GetComponent<Renderer>().material.color = Color.red;
                    tagFinder[0].SetActive(false);
                    tagFinder[3].SetActive(false);
                    tagFinder[4].SetActive(false);
                    tagFinder[5].SetActive(false);
                    tagFinder[6].SetActive(false);
                    tagFinder[7].SetActive(false);
                    tagFinder[8].SetActive(false);
                    tagFinder[9].SetActive(false);
                    tagFinder[10].SetActive(false);
                    tagFinder[11].SetActive(false);
                    
                    /*tagFinder[0].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[1].GetComponent<Renderer>().material.color = Color.blue;
                    tagFinder[2].GetComponent<Renderer>().material.color = Color.blue;
                    tagFinder[3].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[4].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[5].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[6].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[7].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[8].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[9].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[10].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[11].GetComponent<Renderer>().material.color = Color.grey;*/
                    break;
                case 3:
                    tagFinder[4].SetActive(true);
                    tagFinder[4].GetComponent<Renderer>().material.color = Color.yellow;
                    tagFinder[7].SetActive(true);
                    tagFinder[7].GetComponent<Renderer>().material.color = Color.yellow;
                    tagFinder[0].SetActive(false);
                    tagFinder[1].SetActive(false);
                    tagFinder[2].SetActive(false);
                    tagFinder[3].SetActive(false);
                    tagFinder[5].SetActive(false);
                    tagFinder[6].SetActive(false);
                    tagFinder[8].SetActive(false);
                    tagFinder[9].SetActive(false);
                    tagFinder[10].SetActive(false);
                    tagFinder[11].SetActive(false);
                  
                    /*tagFinder[0].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[1].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[2].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[3].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[4].GetComponent<Renderer>().material.color = Color.red;
                    tagFinder[5].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[6].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[7].GetComponent<Renderer>().material.color = Color.red;
                    tagFinder[8].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[9].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[10].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[11].GetComponent<Renderer>().material.color = Color.grey;*/
                    break;
                case 4:
                    tagFinder[5].SetActive(true);
                    tagFinder[5].GetComponent<Renderer>().material.color = Color.yellow;
                    tagFinder[6].SetActive(true);
                    tagFinder[6].GetComponent<Renderer>().material.color = Color.yellow;
                    tagFinder[0].SetActive(false);
                    tagFinder[1].SetActive(false);
                    tagFinder[2].SetActive(false);
                    tagFinder[3].SetActive(false);
                    tagFinder[4].SetActive(false);
                    tagFinder[7].SetActive(false);
                    tagFinder[8].SetActive(false);
                    tagFinder[9].SetActive(false);
                    tagFinder[10].SetActive(false);
                    tagFinder[11].SetActive(false);
                    /*tagFinder[0].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[1].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[2].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[3].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[4].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[5].GetComponent<Renderer>().material.color = Color.blue;
                    tagFinder[6].GetComponent<Renderer>().material.color = Color.blue;
                    tagFinder[7].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[8].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[9].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[10].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[11].GetComponent<Renderer>().material.color = Color.grey;
                    */
                    break;
                case 5:
                    tagFinder[8].SetActive(true);
                    tagFinder[8].GetComponent<Renderer>().material.color = Color.blue;
                    tagFinder[11].SetActive(true);
                    tagFinder[11].GetComponent<Renderer>().material.color = Color.blue;
                    tagFinder[0].SetActive(false);
                    tagFinder[1].SetActive(false);
                    tagFinder[2].SetActive(false);
                    tagFinder[3].SetActive(false);
                    tagFinder[4].SetActive(false);
                    tagFinder[5].SetActive(false);
                    tagFinder[6].SetActive(false);
                    tagFinder[7].SetActive(false);
                    tagFinder[9].SetActive(false);
                    tagFinder[10].SetActive(false);
                    /*
                    tagFinder[0].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[1].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[2].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[3].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[4].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[5].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[6].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[7].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[8].GetComponent<Renderer>().material.color = Color.red;
                    tagFinder[9].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[10].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[11].GetComponent<Renderer>().material.color = Color.red;
                    */
                    break;
                case 6:
                    tagFinder[9].SetActive(true);
                    tagFinder[9].GetComponent<Renderer>().material.color = Color.blue;
                    tagFinder[10].SetActive(true);
                    tagFinder[10].GetComponent<Renderer>().material.color = Color.blue;
                    tagFinder[0].SetActive(false);
                    tagFinder[1].SetActive(false);
                    tagFinder[2].SetActive(false);
                    tagFinder[3].SetActive(false);
                    tagFinder[4].SetActive(false);
                    tagFinder[5].SetActive(false);
                    tagFinder[6].SetActive(false);
                    tagFinder[7].SetActive(false);
                    tagFinder[8].SetActive(false);
                    tagFinder[11].SetActive(false);
                    /* 
                    tagFinder[0].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[1].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[2].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[3].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[4].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[5].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[6].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[7].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[8].GetComponent<Renderer>().material.color = Color.grey;
                    tagFinder[9].GetComponent<Renderer>().material.color = Color.blue;
                    tagFinder[10].GetComponent<Renderer>().material.color = Color.blue;
                    tagFinder[11].GetComponent<Renderer>().material.color = Color.grey;
                    */
                    break;
            }

            
            lengthCheck += timeInterval;
            tileColor = Random.Range(1, 6);
        }

        // quit the application once 5 minutes have passed. 
        if (Time.time == 300.0f)
        {

            Application.Quit();
        }


    }
}


// how to update every second: https://answers.unity.com/questions/122349/how-to-run-update-every-second.html
// Find with tag: https://docs.unity3d.com/ScriptReference/GameObject.FindGameObjectsWithTag.html
