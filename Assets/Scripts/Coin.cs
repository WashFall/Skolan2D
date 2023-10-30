using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public TextManager textManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        textManager.AddCoins();
        Destroy(gameObject);
    }
}
