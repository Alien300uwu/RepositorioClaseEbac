using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_Tarea_3 : MonoBehaviour
{
    
    public Cubo_tarea_1 Cubo_x;
    public Cubo_Tarea_2 Cubo_y;
    public bool Valor_del_cubo_3;
    bool Valor1;
    bool Valor2;
    Color Mastercolor = Color.green;
    Color Badcolor = Color.cyan;
    // Start is called before the first frame update
    void Start()
    {
        Valor_del_cubo_3 = true; //Esto es para que cambie el valor en el cubo 4 y no se quede en falso
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(Valor1);
        //Debug.Log(Valor2);
        

    }

    private void FixedUpdate()
    {

        Valor1 = Cubo_x.verdadera;
        Valor2 = Cubo_y.falsa;

        if (Valor1 || Valor2)
        {
            GetComponent<MeshRenderer>().material.color = Mastercolor;
            Valor_del_cubo_3 = false;
        }
        else 
        {
            GetComponent<MeshRenderer>().material.color = Badcolor;
            Valor_del_cubo_3 = true;

        }
    }
}
