using UnityEngine;

public class SkiftGruppe : MonoBehaviour
{
    [Header("Grupper der forsvinder")]
    public GameObject gruppe1;
    public GameObject gruppe2;
    public GameObject gruppe3;
    public GameObject gruppe4;
    public GameObject gruppe5;

    [Header("Gruppe der kommer frem")]
    public GameObject gruppeFarve;

    void Start()
    {
        gruppe1.SetActive(false);
        gruppe2.SetActive(false);
        gruppe3.SetActive(false);
        gruppe4.SetActive(false);
        gruppe5.SetActive(false);
        gruppeFarve.SetActive(false);
    }

    void OnMouseDown()
    {
        gruppe1.SetActive(false);
        gruppe2.SetActive(false);
        gruppe3.SetActive(false);
        gruppe4.SetActive(false);
        gruppe5.SetActive(false);
        gruppeFarve.SetActive(true);
    }
}