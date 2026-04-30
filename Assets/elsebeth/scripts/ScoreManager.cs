using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Image meterFill;
    public int maxPoint = 10;

    int currentPoint = 0;

    void Awake()
    {
        instance = this;
    }

    public void TilføjPoint()
    {
        currentPoint++;
        meterFill.fillAmount = (float)currentPoint / maxPoint;

        if (currentPoint >= maxPoint)
        {
            SceneManager.LoadScene("WinScene");
        }

    }

    public void NulstilPoint()
    {
        currentPoint = 0;
        meterFill.fillAmount = 0;
    }
}


