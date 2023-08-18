using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //singleton, para poder acceder al GM desde cualquier objeto o clase
    public static GameManager Instance { get; private set; }

    public HUD hud;
    private int piezasRecolectadas = 4;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("Mas de un Game Manager en escena");
        }
    }

    
    public void ObjectFind()
    {
        // if (piezasRecolectadas == 4)
        // {
        //     return false;
        // }
        Debug.Log("antes del hud");
        hud.ActivarPiezas(piezasRecolectadas);
        piezasRecolectadas += 1;
        Debug.Log("despues del hud");

        // return true;
    }
}
