using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
	public float Speed;
	public Controller Player;
    public Transform PlayerPosition;
    public Transform TargetPosition;
//	public GameObject enemyDeathEffect;




	void Start () 
	{
		Player = FindObjectOfType<Controller> ();
        GetComponent<Rigidbody2D>().velocity = new Vector2(TargetPosition.position.x - PlayerPosition.position.x, TargetPosition.position.y - PlayerPosition.position.y);
        if (Player.transform.localScale.x <0)
			Speed = -Speed;

	}

	void Update () 
	{
		//GetComponent<Rigidbody2D>().velocity = new Vector2 (TargetPosition.position.x - PlayerPosition.position.x, TargetPosition.position.y - PlayerPosition.position.y);
        // 2 - Destruction programmée
        //Destroy(gameObject, 5); // 20sec
        //GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
    }

//	void OnTriggerEnter2D(Collider2D other)
//	{
//		if (other.tag != "Text" && other.tag!="Player" && other.tag !="Coin")
//			Destroy (gameObject);
//		if (other.tag == "Drone")
//		{
//			Instantiate (enemyDeathEffect, other.transform.position, other.transform.rotation);
//			Destroy (other.gameObject);
//		}

//	}
}