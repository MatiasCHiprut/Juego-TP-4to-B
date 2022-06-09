using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text txtTime;
    public bool timer=false;

    public float MaxTime=0;
    int limite=45;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer == false)
        {
            timer = true;
            StartCoroutine(MaxTime());
        }
        if (MaxTime > limite)
        {
            SceneManager.LoadScene("You-Lost");
        }
    }

    IEnumerator timer()
    {

    }
}
