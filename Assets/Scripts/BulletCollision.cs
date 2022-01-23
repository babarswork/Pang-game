using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
	void OnTriggerEnter2D(Collider2D col)
	{
		//Debug.Log("anything hit");
		ChainBullet.IsFired = false;
		// col means the ball collider
		if (col.tag == "Ball")
		{
			col.GetComponent<Ball>().Split();
			//Debug.Log("split ball");
		}
	}
}
