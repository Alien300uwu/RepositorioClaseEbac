using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Código_Esfera : MonoBehaviour
{
    public GameObject ColorEsfera;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        ColorEsfera.GetComponent<MeshRenderer>().material.color = c;
        Debug.LogWarning("Cambio de Color");
    }
}
