using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGame1HintTimer : MonoBehaviour
{
    public float timerLeft;
    public float totalTime = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerLeft = totalTime;
    }

    // Update is called once per frame
    void Update()
    {
        timerLeft -= Time.deltaTime;

        if (timerLeft < 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
