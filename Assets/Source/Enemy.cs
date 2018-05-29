
using UnityEngine;

class Enemy : MonoBehaviour
{
	public float movementSpeed = 0.0f;
	public GameObject king;
	public GameObject deathEffect;

	private void Update()
	{
		transform.position = Vector2.MoveTowards( new Vector2( transform.position.x , transform.position.y ) , king.transform.position , movementSpeed * Time.deltaTime );
	}

	private void OnCollisionEnter2D( Collision2D coll )
	{
		if( coll.gameObject.tag == "Player" ) Destroy( this.gameObject );
	}

	private void OnMouseDown()
	{
		Instantiate( deathEffect , transform.position , Quaternion.identity );
		Destroy( this.gameObject );
	}
}