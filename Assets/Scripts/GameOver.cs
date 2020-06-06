using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverText;
    // Start is called before the first frame update
    void Start()
    {
       // gameOverText.SetActive(false);
    }

   /* public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Debug.Log("Done");
            panel.SetActive(true);
        }
    }*/
   /* public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            gameOverText.SetActive(true);
        }
    }*/
}
