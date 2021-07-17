using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectPython : MonoBehaviour
{
    [SerializeField] private Text P;
    [SerializeField] private Text Y;
    [SerializeField] private Text T;
    [SerializeField] private Text H;
    [SerializeField] private Text O;
    [SerializeField] private Text N;
    private BoxCollider2D boxCol;
    
    public AudioSource soundCoin;

    // Start is called before the first frame update
    void Start()
    {
        boxCol = gameObject.GetComponent<BoxCollider2D>();
        P.enabled = false;
        Y.enabled = false;
        T.enabled = false;
        H.enabled = false;
        O.enabled = false;
        N.enabled = false;
        
        soundCoin = GameObject.FindWithTag("SoundCoin").GetComponent<AudioSource>();

    
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if edgeCollider2d was Hit
        if(collision.gameObject.name == "P(Clone)" && P.enabled == false){

                //write letter on canvas
                P.enabled = true;
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
        if(collision.gameObject.name == "T(Clone)" && T.enabled == false){

                //write letter on canvas
                T.enabled = true;
                //soundCoin started
                soundCoin.Play();
                //Element destroyed
                Destroy(collision.gameObject);
        }
        //check if edgeCollider2d was Hit
        if(collision.gameObject.name == "H(Clone)" && H.enabled == false){

                //write letter on canvas
                H.enabled = true;
                //soundCoin started
                soundCoin.Play();
                //Element destroyed
                Destroy(collision.gameObject);
        }
        if(collision.gameObject.name == "O(Clone)" && O.enabled == false){

                //write letter on canvas
                O.enabled = true;
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
        
    }
}
