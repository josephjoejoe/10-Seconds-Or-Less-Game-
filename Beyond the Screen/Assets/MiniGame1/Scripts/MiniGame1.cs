using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGame1 : MonoBehaviour
{
    public bool addedScore;

    public GameObject coinGate;
    public GameManager gm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");

        if (coins.Length == 0 && addedScore == false)
        {
            gm.Score += 250;
            addedScore = true;
            SceneManager.LoadScene(1);
            FindFirstObjectByType<TimeBar>().ResetTimer();
        }

        if (coins.Length == 1)
        {
            Destroy(coinGate);
        }
    }
}
