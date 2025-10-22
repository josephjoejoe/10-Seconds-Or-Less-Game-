using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeBar : MonoBehaviour
{
    public Image timeBar;

    public float totalTime = 10;
    public float timeLeft;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeLeft = totalTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;

            float fillAmount = Mathf.Clamp01(timeLeft / totalTime);
            timeBar.fillAmount = fillAmount;
        }
        else
        {
            timeBar.fillAmount = 0;
            Debug.Log("I lose oh no");
            SceneManager.LoadScene(2);
        }
    }
}
