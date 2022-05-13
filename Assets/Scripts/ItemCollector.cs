using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public GameObject collectEffect;

    int coins = 0;

    [SerializeField] Text coinsText;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            if (collectEffect)
            {
                Instantiate(collectEffect, transform.position, Quaternion.identity);
            }
            FindObjectOfType<AudioManager>().Play("Coin");
            Destroy(other.gameObject);
            coins++;
            coinsText.text = "Coins: " + coins;
        }
    }

}
