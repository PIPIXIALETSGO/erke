using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {
    public GameObject bullet;
    public GameObject bulletSpawn;


    float countdown = -1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        countdown = countdown - Time.deltaTime;

        if (countdown < 0)
        {
            countdown = 1.5f;

            GameObject obj = (GameObject)Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
            obj.GetComponent<Rigidbody>().velocity = Vector3.back * 10;
            Destroy(obj, 7.0f);

        }

    }
}