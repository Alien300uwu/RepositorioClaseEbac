using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_tarea_1 : MonoBehaviour
{

    public GameObject Color;

    bool verdadera;
    // Start is called before the first frame update
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (verdadera == true)
        {

            Color.GetComponent<MeshRenderer>().material.color = UnityEngine.Color.white;
            verdadera = false;
        }
        else
        {

            Color.GetComponent<MeshRenderer>().material.color = UnityEngine.Color.black;
            verdadera = true;
        }
    }
}
