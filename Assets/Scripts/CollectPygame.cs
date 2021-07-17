using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectPygame : MonoBehaviour
{
    [SerializeField] private Text P;
    [SerializeField] private Text Y;
    [SerializeField] private Text G;
    [SerializeField] private Text A;
    [SerializeField] private Text M;
    [SerializeField] private Text E;
    private BoxCollider2D boxCol;
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
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if edgeCollider2d was Hit
        if(collision.gameObject.name == "P(Clone)"){

                //write letter on canvas
                P.enabled = true;
                Destroy(collision.gameObject);
        }
        if(collision.gameObject.name == "Y(Clone)"){

                //write letter on canvas
                Y.enabled = true;
                Destroy(collision.gameObject);
        }
        if(collision.gameObject.name == "G(Clone)"){

                //write letter on canvas
                G.enabled = true;
                Destroy(collision.gameObject);
        }
        //check if edgeCollider2d was Hit
        if(collision.gameObject.name == "A(Clone)"){

                //write letter on canvas
                A.enabled = true;
                Destroy(collision.gameObject);
        }
        if(collision.gameObject.name == "M(Clone)"){

                //write letter on canvas
                M.enabled = true;
                Destroy(collision.gameObject);
        }
        if(collision.gameObject.name == "E(Clone)"){

                //write letter on canvas
                E.enabled = true;
                Destroy(collision.gameObject);
        }
        
    }
}
