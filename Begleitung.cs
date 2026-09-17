using UnityEngine;

public class Begleitung : MonoBehaviour
{
    public Transform Player;
    public float XMinimal = -10;
    public float XMaximal = 10;
    public float YMinimal = -5;
    public float YMaximal = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.position.x < transform.position.x + XMinimal)
            transform.position = new Vector3(Player.position.x - XMinimal, transform.position.y, transform.position.z);
        if (Player.position.x > transform.position.x + XMaximal)
            transform.position = new Vector3(Player.position.x - XMaximal, transform.position.y, transform.position.z);
        if (Player.position.y < transform.position.y + YMinimal)
            transform.position = new Vector3(transform.position.x, Player.position.y - YMinimal, transform.position.z);
        if (Player.position.y > transform.position.y + YMaximal)
            transform.position = new Vector3(transform.position.x, Player.position.y - YMaximal, transform.position.z);
    }
}
