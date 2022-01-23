using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 4f;
    public Rigidbody2D rigid;
    private float movement = 0f;
    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal")*speed;
    }
    private void FixedUpdate()
    {
        //rigid.MovePosition(rigid.position + Vector2.right*movement);
        rigid.MovePosition(rigid.position + new Vector2(movement * Time.fixedDeltaTime,0f));
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Ball")
        {
            Debug.Log("Game Over My Friend !..");
        }
    }

}
