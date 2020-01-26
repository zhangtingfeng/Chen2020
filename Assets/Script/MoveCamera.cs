using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

    public Transform bolltransform;
    private Vector3 offset;
    // Use this for initialization
	void Start () {
        offset = transform.position - bolltransform.position;
        //Debug.Log("11111111111");
    }
	
	// Update is called once per frame
	void Update () {
      transform.position = offset + bolltransform.position;
    }
}
