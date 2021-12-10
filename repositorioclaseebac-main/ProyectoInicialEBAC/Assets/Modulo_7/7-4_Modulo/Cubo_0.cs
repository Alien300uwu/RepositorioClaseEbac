using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_0 : MonoBehaviour
{
    Color colorverdadero = Color.yellow;
    Color colorfalso = Color.red;

    public bool ValorDeCubo_0;
    // Start is called before the first frame update


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning(ValorDeCubo_0);
    }

    private void FixedUpdate()
    {
        if (ValorDeCubo_0 == true)
        {


            GetComponent<MeshRenderer>().material.color = colorverdadero;
            ValorDeCubo_0 = false;

        }
        else
        {

            GetComponent<MeshRenderer>().material.color = colorfalso;
            ValorDeCubo_0 = true;
        }
    }

}
