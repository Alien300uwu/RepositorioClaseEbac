using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstructurasDeDatos : MonoBehaviour
{
    List<int> listaNumeros = new List<int>();
    List<string> listaString = new List<string>();
    HashSet<int> hashSetInts = new HashSet<int>();
    Queue<string> colaString = new Queue<string>();
    Stack<string> pilaString = new Stack<string>();
    Dictionary<string, float> poderArmas = new Dictionary<string, float>();

    // Start is called before the first frame update
    void Start()
    {
        float temporal = 0;
        poderArmas.Add("rifle", 7.0f);
        poderArmas.Add("pistola", 3.0f);
        poderArmas.Add("escopeta", 5.0f); 
        poderArmas.Add("rifleFrancotorador", 10.0f); 
        poderArmas.Add("cuchillo", 2.0f);
        if (poderArmas.TryGetValue("escopeta", out temporal))
        {
            Debug.Log(poderArmas["escopeta"]); 
        }
        else
        {
            Debug.Log("Esa arma no existe");
        }
        





        //pila
        /// First in First Our => FIFO
        /// First in Last Out => FILO
        //pilaString.Push("As");
        //pilaString.Push("CindoEspadas");
        //pilaString.Push("TresCorazones");
        //pilaString.Push("CuatroTrebol");
        //pilaString.Push("ReyEspadas");
        //Debug.Log(pilaString.Peek());
        //pilaString.Pop();
        //Debug.Log(pilaString.Peek());
        //pilaString.Pop();
        //Debug.Log(pilaString.Peek());
        //pilaString.Pop();
        //Debug.Log(pilaString.Peek());
        //pilaString.Pop();







        /// First in First Our => FIFO
        /// First in Last Out => FILO
        //colaString.Enqueue("Proyectil 1");
        //colaString.Enqueue("Proyectil 2");
        //colaString.Enqueue("Proyectil 3");
        //colaString.Enqueue("Proyectil 4");
        //colaString.Enqueue("Proyectil 5");
        //Debug.Log(colaString.Peek());
        //colaString.Dequeue();
        //Debug.Log(colaString.Peek());
        //colaString.Dequeue();
        //Debug.Log(colaString.Peek());
        //colaString.Dequeue();
        //Debug.Log(colaString.Peek());








        //for (int i = 0; i < 20; i++)
        //{
        //    hashSetInts.Add(i);
        //}
        //if (hashSetInts.Contains(5))
        //{
        //    hashSetInts.Remove(5);
        //}
        //else
        //{
        //    Debug.Log("El HashSet no contiene este elemento");
        //}







        //for (int i = 0; i < 20; i++)
        //{
        //    listaNumeros.Add(Random.Range(0 , 20));
        //}
        //foreach (var numero in listaNumeros)
        //{
        //    Debug.Log(numero);
        //}
        //listaNumeros.Sort();
        //foreach (var numero in listaNumeros)
        //{
        //    Debug.Log(numero);
        //}

        //listaString.Add("Diego");
        //listaString.Add("Sofía");
        //listaString.Add("Daniel");
        //listaString.Add("Javier");
        //listaString.Add("Diana");
        //foreach (var nombre in listaString)
        //{
        //    Debug.Log(nombre);
        //}
        //listaString.RemoveAt(2);
        //foreach (var nombre in listaString)
        //{
        //    Debug.Log(nombre);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
