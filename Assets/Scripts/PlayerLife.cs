using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{

    private void Update()
    {
        if (transform.position.y < -3f)
        {
            Die(gameObject);
            FindObjectOfType<AudioManager>().Play("Respawn");
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy Body"))
        {
            Die(gameObject);
            FindObjectOfType<AudioManager>().Play("Respawn");
        }
    }

    void Die(GameObject obj)
    {
        FindObjectOfType<AudioManager>().Play("PlayerDie");
        obj.SetActive(false);
        Invoke(nameof(ReloadLevel), 1.3f);
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
