using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCubo_Switch : MonoBehaviour
{
    
    

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        string[] Palabras_Color_Cubo = { "Azul", "Blanco", "Rojo", "Verde", "Negro" };

        int Valor = Random.Range(0, Palabras_Color_Cubo.Length);

        switch (Valor)
        {
            case 0: GetComponent<MeshRenderer>().material.color = Color.blue; break;
            case 1: GetComponent<MeshRenderer>().material.color = Color.white; break;
            case 2: GetComponent<MeshRenderer>().material.color = Color.red; break;
            case 3: GetComponent<MeshRenderer>().material.color = Color.green; break;
            case 4: GetComponent<MeshRenderer>().material.color = Color.black; break;
            default: Debug.Log("No es posible"); break;
        }
    }
}
