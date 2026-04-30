using UnityEngine;

public class HektiskBevægelse : MonoBehaviour
{
    public float zigzagInterval = 0.3f;  // hvor tit den skifter retning
    public float zigzagKraft = 5f;       // hvor kraftigt den skifter

    Rigidbody2D rb;
    float timer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= zigzagInterval)
        {
            timer = 0f;

            // Behold X-hastighed men vend Y
            Vector2 nuværendeHastighed = rb.linearVelocity;
            rb.linearVelocity = new Vector2(nuværendeHastighed.x, zigzagKraft * Mathf.Sign(-nuværendeHastighed.y));
        }
    }
}