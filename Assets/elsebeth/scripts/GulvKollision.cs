using UnityEngine;

public class BoldGulv : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.NulstilPoint();
        }
    }
}
