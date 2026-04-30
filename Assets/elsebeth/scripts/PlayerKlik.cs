using UnityEngine;

public class BoldKlik : MonoBehaviour
{
    public Transform metroBox;
    public float bevægelsesHastighed = 10f;
    public GameObject popupPrefab;

    bool klikket = false;
    Vector3 originalScale;
    bool scalesat = false;

    void Start()
    {
        if (!scalesat)
            originalScale = transform.localScale;
    }

    public void SætOriginalScale(Vector3 scale)
    {
        originalScale = scale;
        scalesat = true;
    }

    void Update()
    {
        if (klikket && metroBox != null)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                metroBox.position,
                bevægelsesHastighed * Time.deltaTime
            );

            transform.localScale = Vector3.MoveTowards(
                transform.localScale,
                originalScale * 0.05f, // 5% af DENNE dudes egen original størrelse
                Time.deltaTime * 2f
            );

            if (Vector3.Distance(transform.position, metroBox.position) < 0.1f)
            {
                ScoreManager.instance.TilføjPoint();

                if (popupPrefab != null)
                {
                    Instantiate(popupPrefab, metroBox.position + new Vector3(0, 1f, 0), Quaternion.identity);
                }

                MetroController mc = metroBox.GetComponent<MetroController>();
                if (mc != null) mc.AbnMetro();

                Destroy(gameObject);
            }
        }
    }

    void OnMouseDown()
    {
        klikket = true;
        GetComponent<Rigidbody2D>().simulated = false;
    }
}