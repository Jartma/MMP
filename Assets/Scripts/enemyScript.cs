using System;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    private Rigidbody2D rBCircle;

    [HideInInspector]
    public bool mustPatrol;
    private bool mustTurn;
    
    public Transform groundCheckPos;
    public LayerMask groundLayer;

    private void Awake()
    {
        rBCircle = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //get component here to make it more performant
        //rBCircle = GetComponent<Rigidbody2D>();
        
        mustPatrol = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        Vector2 movementVec = new Vector2(horizontalMovement, 0.0f);
        rBCircle.AddForce(movementVec * speed);
        
        if (mustPatrol)
        {
            Patrol();
        }
        
    }

    private void FixedUpdate()
    {
        if (mustPatrol)
        {
            mustTurn = !Physics2D.OverlapCircle(groundCheckPos.position, 0.1f, groundLayer);
        }
    }
    void Patrol()
    {
        rBCircle.velocity = new Vector2(speed * Time.fixedDeltaTime, rBCircle.velocity.y);
    }

    void Flip()
    {
        mustPatrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        speed *= -1;
        mustPatrol = true;
    }
}
