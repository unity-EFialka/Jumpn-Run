using TMPro;
using UnityEditor.U2D.Aseprite;
using UnityEngine;

public class WinAndDie : MonoBehaviour
{
    public Collider2D Destination;
    public TextMeshProUGUI guiText;
    public string Gewonnen = "Gewonnen";
    public string Verloren = "Verloren";
    int trigger = 0;
    bool trigg = false;
    public Rigidbody2D Player;
    public LayerMask Zone;
    bool Wined = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider == Destination)
        {
            guiText.text = Gewonnen;
            Wined = true;
            Player.bodyType = RigidbodyType2D.Static;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if ((Zone.value & (1 << collision.gameObject.layer)) != 0)
        {
            trigger--;
            if (trigger == 0 && trigg) Die();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((Zone.value & (1 << collision.gameObject.layer)) != 0)
        {
            trigger++;
            trigg = true;
        }
    }
    void Die()
    {
        if (Wined) return;
        Debug.Log("DIE");
        guiText.text = Verloren;
        Player.bodyType = RigidbodyType2D.Static;
    }
}
