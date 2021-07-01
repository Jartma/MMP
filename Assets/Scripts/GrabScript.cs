using UnityEngine;
using System.Collections;

public class GrabScript : MonoBehaviour {

	public bool grabbed;
	RaycastHit2D hit;
	public float distance=2f;
	public Transform Holdpoint;
	public float throwforce;
	public LayerMask notgrabbed;
	private Animator anim;

	// Use this for initialization
	void Start () {
	}

	private void Awake()
    {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.G))
		{

			if(!grabbed) //grab
			{
				
				Physics2D.queriesStartInColliders=false;
				hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y-1),Vector2.right*transform.localScale.x,distance); //direction where objects will be grabbed

				if(hit.collider!=null && hit.collider.tag=="Letter") 
				{
					anim.SetBool("carry", true);
					grabbed=true;
				}

			}else if(!Physics2D.OverlapPoint(Holdpoint.position,notgrabbed)) //throw 
			{
				anim.SetBool("carry", false);
				grabbed=false;

				if(hit.collider.gameObject.GetComponent<Rigidbody2D>()!=null)
				{
					hit.collider.gameObject.GetComponent<Rigidbody2D>().velocity= new Vector2(transform.localScale.x,1)*throwforce;
		
				}

			}
		}else if (Input.GetKeyUp(KeyCode.G))
            {
				if (grabbed)
				{
					anim.SetBool("carry", false);
					transform.SetParent(null);
					grabbed = false;
				}
            }

		if (grabbed)
			hit.collider.gameObject.transform.position = Holdpoint.position; //move grabbed object to holdpoint
	}

}