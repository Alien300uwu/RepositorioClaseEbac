using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_0 : MonoBehaviour
{
    public GameObject Color;

    bool verdadera;


    //int limitador = 1;
    //int limiteInferior = 10;
    //int limiteSuperior = -10;

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
        
            Color.GetComponent<MeshRenderer>().material.color = UnityEngine.Color.green;
            verdadera = false;
        }
        else
        {
        
            Color.GetComponent<MeshRenderer>().material.color = UnityEngine.Color.cyan;
            Debug.Log(verdadera);
            verdadera = true;
        }

        

       //if(limitador > 0)
       // {
       //     Color.GetComponent<MeshRenderer>().material.color = UnityEngine.Color.green;
       // }
       
       // else
       // {
       //     Color.GetComponent<MeshRenderer>().material.color = UnityEngine.Color.cyan;
       // }
       // Debug.Log(limitador);

       //limitador = Random.Range(limiteInferior, limiteSuperior);
    }

}
