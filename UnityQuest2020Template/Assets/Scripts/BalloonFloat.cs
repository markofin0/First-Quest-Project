using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonFloat : MonoBehaviour
{
    private bool letGo;

    // Start is called before the first frame update
    public void Start()
    {
        bool letGo = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(letGo == false)
        {
            Floater();
        }
    }

    void Floater()
    {
        
    }
}
