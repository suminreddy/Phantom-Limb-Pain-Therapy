using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;

public class mainmenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

     void OnGUI()
    {
        GUI.contentColor = Color.black; 
        GUI.Label(new Rect(50, 50, 300, 50), "Press Any Key To Load Game"); 
    }

    // Update is called once per frame
    void Update () {
		if(Input.anyKey)
        {
            Debug.Log("A key has been pressed");
            SceneManager.LoadScene("basicScene", LoadSceneMode.Single); 
        }
	}
}
