using UnityEngine;

public class PlayerLaunch : MonoBehaviour
{
    bool kollisionAktiv = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Ramt trigger: " + other.tag);
        if (other.CompareTag("SpilZone") && !kollisionAktiv)
        {
            Debug.Log(other.name);
            kollisionAktiv = true;
            gameObject.layer = LayerMask.NameToLayer("Dude");
            Debug.Log("Layer skiftet til Dude!");
        }
    }
}