using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_2 : MonoBehaviour
{
    public GameObject Color;

    public Cubo_0 a;
    public Cubo_1 b;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(a && b == true)
        //{
        //    Color.GetComponent<MeshRenderer>().material.color = UnityEngine.Color.white;
        //}
        //if(a && b == false)
        //{
        //    Color.GetComponent<MeshRenderer>().material.color = UnityEngine.Color.black;
        //}
    }

    private void FixedUpdate()
    {
        if (a && b == true)
        {
            Color.GetComponent<MeshRenderer>().material.color = UnityEngine.Color.white;
        }
        else
        {
            Color.GetComponent<MeshRenderer>().material.color = UnityEngine.Color.black;
        }
    }
}
