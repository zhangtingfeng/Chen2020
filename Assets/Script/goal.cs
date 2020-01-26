using UnityEngine;
using System.Collections;

public class goal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider c) {
        Debug.Log("OnTriggerEnter");
        //gameObject.GetComponent<Renderer>().material.color = Color.blue;
        gameObject.GetComponent<AudioSource>().Play();
    }

    void OnTriggerExit(Collider c)
    {
        Debug.Log("OnTriggerExit");
        gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}
