using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_2 : MonoBehaviour
{

    public Cubo_0 Cubox;
    public Cubo_1 Cubox1;

    bool PrimerCubo;
    bool SegundoCubo;

    public bool ValorCubo3;

    Color ColorReal = Color.magenta;
    Color ColorNoReal = Color.black;

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
        PrimerCubo = Cubox.ValorDeCubo_0;
        SegundoCubo = Cubox1.Cubo_verdadero;

        if (PrimerCubo && SegundoCubo)
        {
            GetComponent<MeshRenderer>().material.color = ColorReal;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = ColorNoReal;

        }

    }
}
