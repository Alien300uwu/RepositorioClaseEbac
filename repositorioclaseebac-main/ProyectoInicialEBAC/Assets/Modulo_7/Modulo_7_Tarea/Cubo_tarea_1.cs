using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_tarea_1 : MonoBehaviour
{
    

    Color colorverdadero = Color.white;
    Color colorfalso = Color.black;

    public bool verdadera;
    // Start is called before the first frame update
    
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.LogWarning(verdadera);
    }

    private void FixedUpdate()
    {
        if (verdadera == true)
        {

         
        GetComponent<MeshRenderer>().material.color = colorverdadero;
            verdadera = false;
        
        }
        else
        {

            GetComponent<MeshRenderer>().material.color = colorfalso;
            verdadera = true;
        }
    }
}
