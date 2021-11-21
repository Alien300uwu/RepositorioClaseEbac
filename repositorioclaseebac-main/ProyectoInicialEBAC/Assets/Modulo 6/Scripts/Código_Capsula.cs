using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Código_Capsula : MonoBehaviour
{
    public GameObject ColorCapsula;
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
        Color c = new Color(Random.value, Random.value, Random.value);
        ColorCapsula.GetComponent<MeshRenderer>().material.color = c;
        Debug.Log("Cambio de Color");
    }
}
