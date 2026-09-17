using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb2d = new Rigidbody2D();
    public Key MoveRight = Key.D;
    public Key MoveLeft = Key.A;
    public Key Jump = Key.Space;
    public float MovementForce = 10;
    public float JumpForce = 500;
    int colls = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[MoveRight].isPressed)
        {
            rb2d.linearVelocity = new Vector2(MovementForce, rb2d.linearVelocityY);
        }
        else if (Keyboard.current[MoveLeft].isPressed)
        {
            rb2d.linearVelocity = new Vector2(-MovementForce, rb2d.linearVelocityY);
        }
        else rb2d.linearVelocity = new Vector2(0, rb2d.linearVelocityY);
        if (Keyboard.current[Jump].wasPressedThisFrame && colls > 0)
        {
            rb2d.AddForce(new Vector2(0, JumpForce));
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        colls++;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        colls--;
    }
}
