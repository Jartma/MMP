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
    // Start is called before the first frame update
    void Start()
    {
        boxCol = gameObject.GetComponent<BoxCollider2D>();
        U.enabled = false;
        N.enabled = false;
        I.enabled = false;
        T.enabled = false;
        Y.enabled = false;
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if edgeCollider2d was Hit
        if(collision.gameObject.name == "U(Clone)"){

                //write letter on canvas
                U.enabled = true;
                Destroy(collision.gameObject);
        }
        if(collision.gameObject.name == "N(Clone)"){

                //write letter on canvas
                N.enabled = true;
                Destroy(collision.gameObject);
        }
        if(collision.gameObject.name == "I(Clone)"){

                //write letter on canvas
                I.enabled = true;
                Destroy(collision.gameObject);
        }
        //check if edgeCollider2d was Hit
        if(collision.gameObject.name == "T(Clone)"){

                //write letter on canvas
                T.enabled = true;
                Destroy(collision.gameObject);
        }
        if(collision.gameObject.name == "Y(Clone)"){

                //write letter on canvas
                Y.enabled = true;
                Destroy(collision.gameObject);
        }
        
    }
}
