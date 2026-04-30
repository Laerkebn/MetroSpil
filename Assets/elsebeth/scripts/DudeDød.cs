using UnityEngine;

public class DudeDød : MonoBehaviour
{
    public Sprite dødSprite;  // træk dit andet billede ind her

    SpriteRenderer sr;
    Rigidbody2D rb;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void BlivInaktiv()
    {
        // Skift sprite
        if (dødSprite != null)
            sr.sprite = dødSprite;

        // Gør duden inaktiv
        rb.linearVelocity = Vector2.zero;
        rb.simulated = false;

        // Slå klik fra
        GetComponent<BoldKlik>().enabled = false;
    }
}