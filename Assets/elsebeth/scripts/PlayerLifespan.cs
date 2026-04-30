using UnityEngine;

public class BoldLifespan : MonoBehaviour
{
    public float lifespan = 2f;

    void Start()
    {
        Destroy(gameObject, lifespan);
    }
}
