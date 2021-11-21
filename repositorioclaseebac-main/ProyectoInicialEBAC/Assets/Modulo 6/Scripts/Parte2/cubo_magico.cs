using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo_magico : MonoBehaviour
{
    public GameObject CuboMagico;
    public List<GameObject> ListaDeCubos;
    public int cantidad = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        cantidad++;
        GameObject tempGameObject = Instantiate<GameObject>(CuboMagico);
        tempGameObject.name = "CuboMagico" + cantidad;
        ListaDeCubos = new List<GameObject>();

        Debug.Log("Creacion de cubo en OnEnable");
    }
    private void OnDisable()
    {
        cantidad++;
        GameObject tempGameObject = Instantiate<GameObject>(CuboMagico);
        tempGameObject.name = "CuboMagico" + cantidad;
        ListaDeCubos = new List<GameObject>();

        Debug.Log("Creacion de Cubo en OnDisable");
    }
        
    
}
