using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public GameObject[] pieces;
    public GameObject winUI;

    void Start()
    {
        // Desactivar los objetos en el array al inicio del juego
        foreach (GameObject piece in pieces)
        {
            piece.SetActive(false);
        }
    }
    
    public void RecollectPiece(int index)
    {
        if (pieces.Length == index + 1)
        {
            GameObject enemy = GameObject.FindWithTag("Enemy");
            Destroy(enemy);

            winUI.SetActive(true);
        }
        else {
            pieces[index].SetActive(true); 
        }
    }
}
