using UnityEngine;

public class GulvKollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.NulstilPoint();
            collision.gameObject.GetComponent<DudeDød>().BlivInaktiv();
        }
    }
}