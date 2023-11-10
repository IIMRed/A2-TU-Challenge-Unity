using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MonAttribut : Attribute
{

}


public class tmp : MonoBehaviour
{


    // Start is called before the first frame update
#if UNITY_EDITOR
    [MonAttribut]
#endif
    void Start()
    {
        TextMeshProUGUI t;

        //// Pas bien
        //if(tag == "Playerr")
        //{

        //}

        // Mieux
        if (CompareTag("Playerr"))
        {

        }



        //vkar t = transform;

        //var g = gameObject;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
