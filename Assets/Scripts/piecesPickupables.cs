using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class piecesPickupables : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(gameObject.tag);
        Debug.Log(other.gameObject.tag);
        if (gameObject.CompareTag("Piece") && other.CompareTag("Player"))
        {
            GameManager.Instance.ObjectFind();
            Destroy(this.gameObject);
        }
    }

}
