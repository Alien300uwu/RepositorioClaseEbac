using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_Tarea_5 : MonoBehaviour
{
    Color Color_De_La_Verdad = Color.white;
    Color Color_De_La_Falsedad = Color.red;

    public Cubo_Tarea_3 A;
    public Cubo_Tarea_4 B;
    public Cubo_Tarea_2 C;

    bool Var_A;
    bool Var_B;
    bool Var_C;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Var_A);
        Debug.LogWarning(Var_B);
        Debug.LogError(Var_C);
    }

    private void FixedUpdate()
    {

        Var_A = A.Valor_del_cubo_3;
        Var_B = B.Valor_del_cubo_4;
        Var_C = C.falsa;

        if((Var_A || Var_B) && !Var_C)
        {
            GetComponent<MeshRenderer>().material.color = Color_De_La_Verdad;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color_De_La_Falsedad;
        }

    }
}
