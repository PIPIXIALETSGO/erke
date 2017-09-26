using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collapsed : MonoBehaviour {
    public Renderer renderer;
    bool Up=true;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Up)
        {
            
            transform.Translate(0, 0.1f, 0);
            Up = false;
        }
        else {
           
            transform.Translate(0, -0.1f, 0);
            Up = true;
        }
    }
    void OnCollisionEnter(Collision collision)

   
    {

        renderer.material.color = Color.gray;
        Destroy(gameObject, 0.3f);
    }
    
}
