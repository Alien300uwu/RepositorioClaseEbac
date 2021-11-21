using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Código_Cubo : MonoBehaviour
{
    public GameObject ColorCubo;
    private void Awake()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        ColorCubo.GetComponent<MeshRenderer>().material.color = c;
        Debug.LogError("Cambio de color");

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
