using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_Tarea_2 : MonoBehaviour
{

    Color colorverdadero = Color.white;
    Color colorfalso = Color.black;

    public Cubo_tarea_1 Cubot1; //nombre de variable Cubo1

    public bool CuboA;
    public bool falsa;
    // Start is called before the first frame update


    void Start()
    {
        falsa = false;
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(CuboA);
        //Debug.Log(falsa);
    }

    private void FixedUpdate()
    {

        CuboA = Cubot1.verdadera;

        if (CuboA && falsa)
        {


            GetComponent<MeshRenderer>().material.color = colorverdadero;
            falsa = false;

        }
        else
        {

            GetComponent<MeshRenderer>().material.color = colorfalso;
            falsa = true;
        }
    }
}
