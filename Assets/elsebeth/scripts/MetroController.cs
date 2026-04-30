using UnityEngine;

public class MetroController : MonoBehaviour
{
    public Sprite metroAben;    // træk MetroAben-sprite ind her
    public Sprite metroLukket;  // træk MetroLukket-sprite ind her

    public float abenTid = 1f;  // hvor længe den er åben

    SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void AbnMetro()
    {
        sr.sprite = metroAben;
        Invoke("LukMetro", abenTid);
    }

    void LukMetro()
    {
        sr.sprite = metroLukket;
    }
}