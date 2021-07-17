using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectUnity : MonoBehaviour
{
    [SerializeField] private Text U;
    [SerializeField] private Text N;
    [SerializeField] private Text I;
    [SerializeField] private Text T;
    [SerializeField] private Text Y;
    private BoxCollider2D boxCol;

    public AudioSource soundCoin;
    // Start is called before the first frame update
    void Start()
    {
        boxCol = gameObject.GetComponent<BoxCollider2D>();
        U.enabled = false;
        N.enabled = false;
        I.enabled = false;
        T.enabled = false;
        Y.enabled = false;
        
        soundCoin = GameObject.FindWithTag("SoundCoin").GetComponent<AudioSource>();
  
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if edgeCollider2d was Hit
        if(collision.gameObject.name == "U(Clone)" && U.enabled == false){

                //write letter on canvas
                U.enabled = true;
                //soundCoin started
                soundCoin.Play();
                //Element destroyed
                Destroy(collision.gameObject);
        }
        if(collision.gameObject.name == "N(Clone)" && N.enabled == false){

                //write letter on canvas
                N.enabled = true;
                //soundCoin started
                soundCoin.Play();
                //Element destroyed
                Destroy(collision.gameObject);
        }
        if(collision.gameObject.name == "I(Clone)" && I.enabled == false){

                //write letter on canvas
                I.enabled = true;
                //soundCoin started
                soundCoin.Play();
                //Element destroyed
                Destroy(collision.gameObject);
        }
        //check if edgeCollider2d was Hit
        if(collision.gameObject.name == "T(Clone)" && T.enabled == false){

                //write letter on canvas
                T.enabled = true;
                //soundCoin started
                soundCoin.Play();
                //Element destroyed
                Destroy(collision.gameObject);
        }
        if(collision.gameObject.name == "Y(Clone)" && Y.enabled == false){

                //write letter on canvas
                Y.enabled = true;
                //soundCoin started
                soundCoin.Play();
                //Element destroyed
                Destroy(collision.gameObject);
        }
        
    }
}
