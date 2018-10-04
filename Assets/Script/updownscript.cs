using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updownscript : MonoBehaviour {
    public float speed = 10f;
    public float height = 0.1f;
    public float offset = 8f;


    Vector3 pos;
    // Use this for initialization
    void Start () {
        pos = transform.localPosition;
    }
	
	// Update is called once per frame
	void Update () {
        float newY = (Mathf.Sin(Time.time*speed) + offset)*height;
        transform.localPosition = new Vector3(pos.x, newY, pos.z);
    }
}
