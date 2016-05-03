using UnityEngine;
using System.Collections;

public class playerControls : MonoBehaviour {

	public float walkSpeed;
	public float lookSpeed;
	public Camera cam;
	public float jumpForce;

	private bool grounded;
	private Rigidbody rb;
	private float h;
	private float v;
	private float mh;
	private float mv;

	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		jumpForce = 6;
	}
	
	// Update is called once per frame
	void Update () 
	{
		h = Input.GetAxisRaw ("Horizontal") * walkSpeed * Time.deltaTime;
		v = Input.GetAxisRaw ("Vertical") * walkSpeed * Time.deltaTime;
		mh = Input.GetAxis ("Mouse X") * lookSpeed;
		mv = Input.GetAxis ("Mouse Y") * lookSpeed;
	}

	void FixedUpdate ()
	{
		/*GroundCheck ();

		if (grounded && Input.GetButtonDown ("Jump")) 
		{
			rb.AddForce (Vector3.up * jumpForce, ForceMode.Impulse);
		}*/
		rb.transform.Translate (new Vector3 (h, 0, v));

		transform.Rotate (new Vector3 (0, mh, 0));
		cam.transform.Rotate (new Vector3 (-mv, 0, 0));

		if (Input.GetButtonDown ("Jump")) {
			Jump ();
		
		}
	}

	void Jump()
	{
		rb.AddForce (0, jumpForce, 0, ForceMode.Impulse);
	}

	/*void GroundCheck ()
	{
		RaycastHit hit;
		if (Physics.Raycast (transform.position, Vector3.down, out hit, 0.75f)) {
			grounded = true;
		} else {
			grounded = false;
		}
	}*/
}
