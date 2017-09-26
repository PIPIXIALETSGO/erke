using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class next2 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {

        SceneManager.LoadScene("scene3", LoadSceneMode.Single);
    }
}

