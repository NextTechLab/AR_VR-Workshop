using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class React : MonoBehaviour {

    public TrackableBehaviour trackable1;
    public TrackableBehaviour trackable2;

    public GameObject atom1;
    public GameObject atom2;

    public GameObject canvas;

    public float speed = 1f;
    public float seperation = 2.5f;

    private void Start()
    {
        canvas.SetActive(false);
    }
    
    void Update () 
    {
	    if(trackable1.CurrentStatus == TrackableBehaviour.Status.TRACKED && trackable2.CurrentStatus == TrackableBehaviour.Status.TRACKED)	
            {

                // Debug.Log("Reaccc");
                // Debug.Log("World Sodium: " + atom1.transform.position);
                // Debug.Log("World Chlorine: " + atom2.transform.position);
                
                if((atom1.transform.position - atom2.transform.position).magnitude > seperation)
                {
                    canvas.SetActive(false);
                    atom1.transform.position = Vector3.MoveTowards(atom1.transform.position, atom2.transform.position, speed * Time.deltaTime);
                }   
                else
                {
                    canvas.SetActive(true);
                }
            
            }
            else
            {

                atom1.transform.position = Vector3.MoveTowards(atom1.transform.position, new Vector3(trackable1.transform.position.x, atom1.transform.position.y ,trackable1.transform.position.z) , speed * Time.deltaTime);
                atom2.transform.position = Vector3.MoveTowards(atom2.transform.position, new Vector3(trackable2.transform.position.x, atom2.transform.position.y ,trackable2.transform.position.z), speed * Time.deltaTime);
            }
	}
}
