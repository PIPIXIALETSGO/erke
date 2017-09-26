using UnityEngine;
using System.Collections;

public class bgm : MonoBehaviour {

    static bgm instance = null;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
}