using UnityEngine;
public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        float speed = 4.0f;
        rb.linearVelocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed;
    }
    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("xspeed", rb.linearVelocity.x);
        anim.SetFloat("yspeed", rb.linearVelocity.y);
        if (rb.linearVelocity.magnitude < 0.01)
            anim.speed = 0.0f;
        else
            anim.speed = 1.0f;

    }
}