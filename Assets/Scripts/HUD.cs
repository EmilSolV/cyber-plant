using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public GameObject[] piezas;

    void Start()
    {
        // Desactivar los objetos en el array al inicio del juego
        foreach (GameObject pieza in piezas)
        {
            pieza.SetActive(false);
        }
    }
    
    public void ActivarPiezas(int indice)
    {
        // foreach (GameObject pieza in piezas)
        // {
        //     pieza.SetActive(true);
        //     
        // }
        
        piezas[indice].SetActive(true);
        Debug.Log("dentro de activar piezas");
    }
}
