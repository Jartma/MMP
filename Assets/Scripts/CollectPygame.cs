using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectPygame : MonoBehaviour
{
    [SerializeField] private Text P;
    [SerializeField] private Text Y;
    [SerializeField] private Text G;
    [SerializeField] private Text A;
    [SerializeField] private Text M;
    [SerializeField] private Text E;
    private BoxCollider2D boxCol;
    public AudioSource soundCoin;
    
    // Start is called before the first frame update
    void Start()
    {
        boxCol = gameObject.GetComponent<BoxCollider2D>();
        P.enabled = false;
        Y.enabled = false;
        G.enabled = false;
        A.enabled = false;
        M.enabled = false;
        E.enabled = false;
        
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
        if(collision.gameObject.name == "G(Clone)" && G.enabled == false){

                //write letter on canvas
                G.enabled = true;
                //soundCoin started
                soundCoin.Play();
                //Element destroyed
                Destroy(collision.gameObject);
        }
        //check if edgeCollider2d was Hit
        if(collision.gameObject.name == "A(Clone)" && A.enabled == false){

                //write letter on canvas
                A.enabled = true;
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
        if(collision.gameObject.name == "E(Clone)" && E.enabled == false){

                //write letter on canvas
                E.enabled = true;
                //soundCoin started
                soundCoin.Play();
                //Element destroyed
                Destroy(collision.gameObject);
        }
        if (P.enabled && Y.enabled && G.enabled && A.enabled && M.enabled && E.enabled ) {
            SceneManager.LoadScene("Menu Screen/Start Menu");
            ScoreScript.scoreValue += ScoreScript.scoreL4;
        }
        
    }
}
