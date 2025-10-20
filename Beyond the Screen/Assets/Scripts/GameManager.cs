using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text ScoreText;
    public int Score;

    public bool addedScore;

    public GameObject coinGate;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score:" + Score;

        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");

        if(coins.Length == 0 && addedScore == false)
        {
            Score += 250;
            addedScore = true;
            SceneManager.LoadScene(1);
        }

        if (coins.Length == 1)
        {
            Destroy(coinGate); 
        }
    }
}
