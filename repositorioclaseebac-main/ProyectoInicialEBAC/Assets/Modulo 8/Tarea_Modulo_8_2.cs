using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarea_Modulo_8_2 : MonoBehaviour
{




    // Start is called before the first frame update
    void Start()
    {
        char a = 'A'; 
        int Cambio_De_Color = 0;
        if (!int.TryParse(a.ToString(), out Cambio_De_Color))
        {
            Debug.LogError("Eso no funciona");
        }
            Debug.Log(a);


        float Alpha = 1;
        string Beta = "Beta";
        float cambio = 0;

        if (float.TryParse(Alpha.ToString(), out cambio)) ;
        {
            Debug.Log(Alpha);
        }

        string B = Beta.Substring(0, 4);
        Debug.Log(B);
    }

    // Update is called once per frame
    void Update()
    {
        


    }
    private void FixedUpdate()
    {

    }
}
