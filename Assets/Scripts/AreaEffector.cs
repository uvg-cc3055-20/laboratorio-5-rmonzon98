using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {

    public GameObject child;
    public bool activated;
    public float time=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;        
        if (time >= 2)
        {
            activated = !activated;
            child.SetActive(activated);
            time = 0;
        }

    }
}
