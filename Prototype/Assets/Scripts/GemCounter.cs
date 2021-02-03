//This is for counting gameobject then destroying gameobject
//Derek Buckley - 2021.02.03

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCounter : MonoBehaviour
{

    public static int gemCount = 0;
    // Start is called before the first frame update
    void Start()
    {
       //Best command for troubleshooting

        Debug.Log("Look ma, it works");

        print("Test");

        //++GemCounter.gemCount;
    }

    private void OnTriggerEnter(Collider other) {

        Debug.Log("You've collected" + " a total of " + ++gemCount + "!");

        Destroy(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
