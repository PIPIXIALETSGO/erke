using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class restart : MonoBehaviour {
    float y;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnTriggerEnter(Collider other)
    {

        SceneManager.LoadScene("scene2", LoadSceneMode.Single);
    }
}
