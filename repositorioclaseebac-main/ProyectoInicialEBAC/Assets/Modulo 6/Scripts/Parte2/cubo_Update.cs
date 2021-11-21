using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo_Update : MonoBehaviour
{
    public GameObject CuboMagico;
    public List<GameObject> ListaDeCubos;
    public float FactorDeEscalamiento;
    public int cantidad = 0;
    // Start is called before the first frame update
    void Start()
    {
        ListaDeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        cantidad++;
        GameObject tempGameObject = Instantiate<GameObject>(CuboMagico);
        tempGameObject.name = "CuboNuevo" + cantidad;
        tempGameObject.transform.position = Random.insideUnitSphere;


        ListaDeCubos.Add(tempGameObject);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in ListaDeCubos)
        {
            float scale = go.transform.localScale.x;
            scale *= FactorDeEscalamiento;
            go.transform.localScale = Vector3.one * scale;



            if (scale <= 0.1)
            {
                objetosParaEliminar.Add(go);
            }
        }

        foreach (GameObject go in objetosParaEliminar)
        {
            ListaDeCubos.Remove(go);
            Destroy(go);
        }
        Debug.Log("Creacion De cubo");
    }
}
