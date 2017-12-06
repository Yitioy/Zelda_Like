using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
	private bool InCombat = false;
	public float Speed;
	private Rigidbody2D Body;
	private SpriteRenderer SpriteRend;
	public Transform FirePoint;
	public GameObject Laser;
	public float Health = 3f;

    public GameObject Target;
    float xShoot;
    float yShoot;
    private float AngleShoot;
    public GameObject PlayerMainShoot;

    void Start()
	{
		Body = GetComponent<Rigidbody2D>();
		SpriteRend = GetComponent<SpriteRenderer> ();
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Enemy") 
		{
			Health -= 1f;
		}
	}
	void FixedUpdate()
	{
		InCombat = enterCombat.InCombat;
		if (InCombat = false);
		{
			float horizontal = Input.GetAxis("Horizontal");
			float vertical = Input.GetAxis("Vertical");
			Body.velocity = new Vector2 (horizontal * Speed, vertical * Speed);
			// le sprite regarde dans la direction ou il va
			if (horizontal > 0f) {
				SpriteRend.flipX = true;
			}
			else if (horizontal <0f) {
				SpriteRend.flipX = false;
			}
		}
		//if (InCombat = true)

	}
    // c'est ce qui fait que le laser tire du point de tir "firePoint"
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Laser = Instantiate(PlayerMainShoot, transform.position, Quaternion.Euler(0, 0, AngleShoot));
            //Destroy(Laser, 7);

        }

		if (Target != null)
		{ 
			// le laser tire sur les ennemis
			xShoot = Target.transform.position.x;
			yShoot = Target.transform.position.y;
			if (xShoot != 0.0f || yShoot != 0.0f)
			{
				AngleShoot = Mathf.Atan2 (yShoot, xShoot) * Mathf.Rad2Deg;
				AngleShoot = AngleShoot / 2;
				if (AngleShoot < 0f)
					AngleShoot = 360 + AngleShoot;
			}
		}
		if (Health <= 0) 
		{
			Destroy (this.gameObject);
		}
        /*    GameObject clone = (GameObject)Instantiate(PlayerMainShoot, transform.position, Quaternion.Euler(0, 0, angleShoot));
            timeSpent = 0;
        */
    }
}