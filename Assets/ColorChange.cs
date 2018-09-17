using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {
    public Renderer rend; 

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.grey;


    }

    // Update is called once per frame
    void Update () {
	}
}
