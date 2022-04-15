using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CamSwitcher : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    // Start is called before the first frame update
    void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("c")) {
            cam1.SetActive(!cam1.activeSelf);
            cam2.SetActive(!cam2.activeSelf);
        }
    }
}
