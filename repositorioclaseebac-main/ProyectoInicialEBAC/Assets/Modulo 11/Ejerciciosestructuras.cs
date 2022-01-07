using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejerciciosestructuras : MonoBehaviour
{
    List<int> ListadeNumeros = new List<int>();
    List<int> ListaParaEje2 = new List<int>();
    List<string> ListaDelEje3 = new List<string>();
    HashSet<string> HashSetDelEje3 = new HashSet<string>();
    Stack<string> PilaParaEje4 = new Stack<string>();
    Queue<string> ColadelEje4 = new Queue<string>();
    // Start is called before the first frame update
    void Start()
    {
        Ejercicio1();
        Ejercicio2();
        Ejercicio3();
        Ejercicio4();
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
        int[] Arreglo1 = new int[5] { 1, 7, 10, 5, 8 };


        foreach (var numero in Arreglo1)
        {
            ListaParaEje2.Add(numero);
        }
        ListaParaEje2.Sort();
        ListaParaEje2.Reverse();
        foreach (var numero in ListaParaEje2)
        {
            //Debug.Log($"{numero}");
        }

   ;

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

        
        for(int i = 0; i < ListaDelEje3.Count; i++)
        {
            if (ListaDelEje3.Contains("Andre"))
            {
                ListaDelEje3.Remove("Andre");
                //Debug.Log("Elemento eliminado");
            }
            if (ListaDelEje3.Contains("Raul"))
            {
                ListaDelEje3.Remove("Raul");
                //Debug.Log("Elemento eliminado");
            }
            if (ListaDelEje3.Contains("Paco"))
            {
                ListaDelEje3.Remove("Paco");
                //Debug.Log("Elemento eliminado");
            }
        }
        

        foreach (var name in ListaDelEje3)
        {
                HashSetDelEje3.Add(name);
                Debug.Log(name);
        }
        foreach (var item in HashSetDelEje3)
        {
            Debug.LogWarning($"{item}");
        }


    }

    public void Ejercicio4()
    {
        PilaParaEje4.Push("Peso");
        PilaParaEje4.Push("Euro");
        PilaParaEje4.Push("Yen");
        PilaParaEje4.Push("libra");
        PilaParaEje4.Push("Rublo");
        PilaParaEje4.Push("Dolar");
        //Debug.Log(PilaParaEje4.Peek());
        //PilaParaEje4.Pop();
        //Debug.Log(PilaParaEje4.Peek());
        //PilaParaEje4.Pop();
        //Debug.Log(PilaParaEje4.Peek());
        //PilaParaEje4.Pop();
        //Debug.Log(PilaParaEje4.Peek());
        //PilaParaEje4.Pop();
        //Debug.Log(PilaParaEje4.Peek());
        //PilaParaEje4.Pop();
        //Debug.Log(PilaParaEje4.Peek());
        //PilaParaEje4.Pop();

        foreach(var pila in PilaParaEje4)
        {
            ColadelEje4.Enqueue(pila);
            //Debug.Log(pila);
            //Esto ya me imprime los datos de la cola si uso esto me puedo ahorrar todos los debugs no? tanto con la pila con otro foreach como con la cola no?
        }

        //Debug.Log(ColadelEje4.Peek());
        //ColadelEje4.Dequeue();
        //Debug.Log(ColadelEje4.Peek());
        //ColadelEje4.Dequeue();
        //Debug.Log(ColadelEje4.Peek());
        //ColadelEje4.Dequeue();
        //Debug.Log(ColadelEje4.Peek());
        //ColadelEje4.Dequeue();
        //Debug.Log(ColadelEje4.Peek());
        //ColadelEje4.Dequeue();
        //Debug.Log(ColadelEje4.Peek());
        //ColadelEje4.Dequeue();

    }


}
