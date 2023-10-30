using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NuevoNivel : MonoBehaviour
{

    public string cambiarEscena;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision) //Metodo propio de unity
    {
        if (collision.CompareTag("Player")) //Voy a comparar la colisión con alguien que se llama player
        {
            //Ejecutar una acción
            Debug.Log("Ya estoy listo para pasar de nivel");

            SceneManager.LoadScene(cambiarEscena);


        }
    }
}