using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo_Awake : MonoBehaviour
{
    public GameObject CuboAwake;
    public int NuevoCubo1 = 0;

    private void Awake()
    {
        NuevoCubo1++;
        GameObject tempGameObject = Instantiate<GameObject>(CuboAwake);
        tempGameObject.name = ("CuboNuevo") + NuevoCubo1;
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
