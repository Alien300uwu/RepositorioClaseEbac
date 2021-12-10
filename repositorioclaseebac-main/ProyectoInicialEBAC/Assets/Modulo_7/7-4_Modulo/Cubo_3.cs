using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_3 : MonoBehaviour
{

    public Cubo_0 x;
    bool Valor_del_primer_cubo;
    public bool variable_publica_para_el_4;

    Color Cambiaformas = Color.blue;
    Color Origenformas = Color.magenta;
    
    // Start is called before the first frame update
    void Start()
    {
     

        
    }

    // Update is called once per frame
    void Update()
    {

        Valor_del_primer_cubo = x.ValorDeCubo_0;

        if (Valor_del_primer_cubo)
        {
            GetComponent<MeshRenderer>().material.color = Cambiaformas;
        }
        else if(!Valor_del_primer_cubo)
        {
            GetComponent<MeshRenderer>().material.color = Origenformas;

        }
    }
}
