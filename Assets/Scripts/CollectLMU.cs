using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectLMU : MonoBehaviour
{
    [SerializeField] private Text L;
    [SerializeField] private Text M;
    [SerializeField] private Text U;
    private BoxCollider2D boxCol;

    public AudioSource soundCoin;
    
    
    // Start is called before the first frame update
    void Start()
    {
        boxCol = gameObject.GetComponent<BoxCollider2D>();
        L.enabled = false;
        M.enabled = false;
        U.enabled = false;

        soundCoin = GameObject.FindWithTag("SoundCoin").GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if edgeCollider2d was Hit
        if(collision.gameObject.name == "L(Clone)" && L.enabled == false){

                //write letter on canvas
                L.enabled = true;
                //soundCoin started
                soundCoin.Play();
                //Element destroyed
                Destroy(collision.gameObject);
                
        }
        if(collision.gameObject.name == "M(Clone)" && M.enabled == false){

                //write letter on canvas
                M.enabled = true;
                //soundCoin started
                soundCoin.Play();
                //Element destroyed
                Destroy(collision.gameObject);
                
        }
        if(collision.gameObject.name == "U(Clone)" && U.enabled == false){

                //write letter on canvas
                U.enabled = true;
                //soundCoin started
                soundCoin.Play();
                //Element destroyed
                Destroy(collision.gameObject);

        }
        if (L.enabled && M.enabled && U.enabled) {
            SceneManager.LoadScene("Level 2");
        }
        
    }
}
