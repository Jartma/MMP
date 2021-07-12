using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead; 

    private EdgeCollider2D edgeCol;

    private string lastColName;


    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        edgeCol = gameObject.GetComponent<EdgeCollider2D>();
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            anim.SetTrigger("hurt");
        }
        else
        {
            if (!dead)
            {
                anim.SetTrigger("die");
                GetComponent<PlayerMovement>().enabled = false;
                dead = true;
                SceneManager.LoadScene("Menu Screen/GameOverMenu");
            }
        }
    }

    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(1);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            AddHealth(1);
        }
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if edgeCollder2d was hit
        if(edgeCol.IsTouching(collision.collider)){
            if(collision.gameObject.tag=="Letter" && lastColName != collision.collider.name)
                {
                    //only take damage if lastColName is not the same as last collision,
                    //otherwise takedamage will repeat as long as letterbox is touching the edgeCollider2d
                    TakeDamage(1);
                    lastColName = collision.collider.name;
                }

            if (collision.gameObject.tag == "Heart" && currentHealth == startingHealth)
            {
                ScoreScript.scoreValue += 10;
            } 
            
            if (collision.gameObject.tag == "Heart")
            {
                AddHealth(1);
            }
        }
    }
}
