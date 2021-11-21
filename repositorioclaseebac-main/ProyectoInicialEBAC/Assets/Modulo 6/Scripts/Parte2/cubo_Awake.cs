using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo_Awake : MonoBehaviour
{
    public GameObject CuboAwake;
    public List<GameObject> ListaDeCubos;
    public int cantidad = 0;

    private void Awake()
    {
        cantidad++;
        GameObject tempGameObject = Instantiate<GameObject>(CuboAwake);
        tempGameObject.name = "CuboNuevo" + cantidad;
        ListaDeCubos = new List<GameObject>();
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
