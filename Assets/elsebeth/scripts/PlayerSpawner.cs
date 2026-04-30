using UnityEngine;

public class BoldSpawner : MonoBehaviour
{
    public GameObject boldPrefab;
    public GameObject hektiskPrefab;
    public GameObject popupPrefab;
    public float spawnInterval = 2f;
    public Transform metroBox;

    [Header("Spawn position")]
    public float spawnXAfstand = 5f;
    public float spawnYMin = -1f;
    public float spawnYMax = 3f;

    [Header("Hastighed")]
    public float forceXMin = 3f;
    public float forceXMax = 8f;
    public float forceYMin = 1f;
    public float forceYMax = 5f;

    void Start()
    {
        InvokeRepeating("SpawnBold", 1f, spawnInterval);
    }

    void SpawnBold()
    {
        bool fraVenstre = Random.Range(0, 2) == 0;

        float xPos = fraVenstre ? -spawnXAfstand : spawnXAfstand;
        float yPos = Random.Range(spawnYMin, spawnYMax);

        float xKraft = Random.Range(forceXMin, forceXMax);
        float yKraft = Random.Range(forceYMin, forceYMax);

        if (!fraVenstre) xKraft = -xKraft;

        // Vælg tilfældig type - 30% chance for hektisk
        GameObject valgtPrefab = (hektiskPrefab != null && Random.value < 0.3f) 
            ? hektiskPrefab 
            : boldPrefab;

        // Giv hektisk dude højere kraft
        if (valgtPrefab == hektiskPrefab)
        {
            xKraft *= 2f;
            yKraft *= 2f;
        }

        Vector3 spawnPos = new Vector3(xPos, yPos, 0);
        GameObject bold = Instantiate(valgtPrefab, spawnPos, Quaternion.identity);
        bold.transform.localScale = valgtPrefab.transform.localScale;
        bold.GetComponent<BoldKlik>().SætOriginalScale(valgtPrefab.transform.localScale);

        bold.layer = LayerMask.NameToLayer("DudeIgnore");

        bold.GetComponent<BoldKlik>().metroBox = metroBox;
        bold.GetComponent<BoldKlik>().popupPrefab = popupPrefab;

        Rigidbody2D rb = bold.GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(xKraft, yKraft);
    }
}