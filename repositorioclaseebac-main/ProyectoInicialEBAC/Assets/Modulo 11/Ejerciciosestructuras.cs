using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejerciciosestructuras : MonoBehaviour
{
    List<int> ListadeNumeros = new List<int>();
    List<string> ListaDelEje3 = new List<string>();
    HashSet<string> HashSetDelEje3 = new HashSet<string>();


    // Start is called before the first frame update
    void Start()
    {
        Ejercicio1();
        Ejercicio2();
        Ejercicio3();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void Ejercicio1(int tamaño = 10, int rangoInf = 0, int rangoSup = 10)
    {

        for (int a = 0; a < tamaño; a++)
        {
            ListadeNumeros.Add(Random.Range(rangoInf, rangoSup));
        }
        foreach (var numero in ListadeNumeros)
        {
            //Debug.Log(numero);
        }

    }

    public void Ejercicio2()
    {
        int[] Arreglo1 = new int[5] { 1, 4, 3, 2, 0 };
        int[] Arreglo2 = new int[] { Arreglo1[1], Arreglo1[2], Arreglo1[3], Arreglo1[0], Arreglo1[4] };
        foreach(var numero in Arreglo2)
        {
            //Debug.Log($"{numero}");
        }
        
    }

    public void Ejercicio3()
    {
        ListaDelEje3.Add("Andre");
        ListaDelEje3.Add("Paco");
        ListaDelEje3.Add("Capi");
        ListaDelEje3.Add("Raul");
        ListaDelEje3.Add("Saimon");
        ListaDelEje3.Add("Paco");   //repe
        ListaDelEje3.Add("Andre");  //repe
        ListaDelEje3.Add("Raul");   //repe
        ListaDelEje3.Add("Jorge");

        foreach (var name in ListaDelEje3)
        {
            HashSetDelEje3.Add(name);
            if (ListaDelEje3.Contains(name))
            {
                HashSetDelEje3.Remove(name);
                Debug.Log(name);
            }
            
        }
    }



}
