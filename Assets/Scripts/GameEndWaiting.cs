using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEndWaiting : MonoBehaviour
{
    public Image loading;
    public Text timeText;

    public GameObject gameOver, nextLevel;

    public static GameEndWaiting instance;

    public GameObject characters, timer, goldCoin, extraTime;

    public int minutes;
    public int sec;

    int totalSeconds = 0;
    int TOTAL_SECONDS = 0;
    float fillamount;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;

        timeText.text = "" + sec;

        if (minutes > 0)
        {
            totalSeconds += minutes * 60;
        }

        if (sec > 0)
        {
            totalSeconds += sec;
        }

        TOTAL_SECONDS = totalSeconds;

        StartCoroutine(second());
    }

    // Update is called once per frame
    void Update()
    {
        if (sec == 0 && minutes == 0)
        {
            if (SceneManager.GetActiveScene().name == "Episode1")
            {
                if (Products.instance.customerCount >= 3 && Products.instance.goldCoin >= 9)
                {
                    Time.timeScale = 0f;
                    nextLevel.SetActive(true);
                    StopCoroutine(second());
                }

                if (Products.instance.customerCount < 3 || Products.instance.goldCoin < 9)
                {
                    Time.timeScale = 0f;
                    gameOver.SetActive(true);
                    StopCoroutine(second());
                }
            }

            if (SceneManager.GetActiveScene().name == "Episode2")
            {
                if (Products.instance.customerCount >= 4 && Products.instance.goldCoin >= 20)
                {
                    Time.timeScale = 0f;
                    nextLevel.SetActive(true);
                    StopCoroutine(second());
                }

                if (Products.instance.customerCount < 4 || Products.instance.goldCoin < 20)
                {
                    Time.timeScale = 0f;
                    gameOver.SetActive(true);
                    StopCoroutine(second());
                }
            }

            if (SceneManager.GetActiveScene().name == "Episode3")
            {
                if (Products.instance.customerCount >= 5 && Products.instance.goldCoin >= 35)
                {
                    Time.timeScale = 0f;
                    nextLevel.SetActive(true);
                    StopCoroutine(second());
                }
                
                if (Products.instance.customerCount < 5 && Products.instance.goldCoin < 35)
                {
                    Time.timeScale = 0f;
                    gameOver.SetActive(true);
                    StopCoroutine(second());
                }
            }

            if (SceneManager.GetActiveScene().name == "Episode4")
            {
                if (Products.instance.customerCount >= 6 && Products.instance.goldCoin >= 54)
                {
                    Time.timeScale = 0f;
                    nextLevel.SetActive(true);
                    StopCoroutine(second());
                }

                if (Products.instance.customerCount < 6 && Products.instance.goldCoin < 54)
                {
                    Time.timeScale = 0f;
                    gameOver.SetActive(true);
                    StopCoroutine(second());
                }
            }

            if (SceneManager.GetActiveScene().name == "Episode5")
            {
                if (Products.instance.customerCount >= 7 && Products.instance.goldCoin >= 77)
                {
                    Time.timeScale = 0f;
                    nextLevel.SetActive(true);
                    StopCoroutine(second());
                }

                if (Products.instance.customerCount < 7 && Products.instance.goldCoin < 77)
                {
                    Time.timeScale = 0f;
                    gameOver.SetActive(true);
                    StopCoroutine(second());
                }
            }

            if (SceneManager.GetActiveScene().name == "Episode6")
            {
                if (Products.instance.customerCount >= 5 && Products.instance.goldCoin >= 30)
                {
                    Time.timeScale = 0f;
                    nextLevel.SetActive(true);
                    StopCoroutine(second());
                }

                if (Products.instance.customerCount < 5 && Products.instance.goldCoin < 30)
                {
                    Time.timeScale = 0f;
                    gameOver.SetActive(true);
                    StopCoroutine(second());
                }
            }

            if (SceneManager.GetActiveScene().name == "Episode7")
            {
                if (Products.instance.customerCount >= 7 && Products.instance.goldCoin >= 63)
                {
                    Time.timeScale = 0f;
                    nextLevel.SetActive(true);
                    StopCoroutine(second());
                }

                if (Products.instance.customerCount < 7 && Products.instance.goldCoin < 63)
                {
                    Time.timeScale = 0f;
                    gameOver.SetActive(true);
                    StopCoroutine(second());
                }
            }

            if (SceneManager.GetActiveScene().name == "Episode8")
            {
                if (Products.instance.customerCount >= 9 && Products.instance.goldCoin >= 108)
                {
                    Time.timeScale = 0f;
                    nextLevel.SetActive(true);
                    StopCoroutine(second());
                }

                if (Products.instance.customerCount < 9 && Products.instance.goldCoin < 108)
                {
                    Time.timeScale = 0f;
                    gameOver.SetActive(true);
                    StopCoroutine(second());
                }
            }

            if (SceneManager.GetActiveScene().name == "Episode9")
            {
                if (Products.instance.customerCount >= 11 && Products.instance.goldCoin >= 165)
                {
                    Time.timeScale = 0f;
                    nextLevel.SetActive(true);
                    StopCoroutine(second());
                }

                if (Products.instance.customerCount < 11 && Products.instance.goldCoin < 165)
                {
                    Time.timeScale = 0f;
                    gameOver.SetActive(true);
                    StopCoroutine(second());
                }
            }

            if (SceneManager.GetActiveScene().name == "Episode10")
            {
                if (Products.instance.customerCount >= 13 && Products.instance.goldCoin >= 234)
                {
                    Time.timeScale = 0f;
                    nextLevel.SetActive(true);
                    StopCoroutine(second());
                }

                if (Products.instance.customerCount < 13 && Products.instance.goldCoin < 234)
                {
                    Time.timeScale = 0f;
                    gameOver.SetActive(true);
                    StopCoroutine(second());
                }
            }
        }
    }

    IEnumerator second()
    {
        yield return new WaitForSeconds(1f);

        if (sec > 0)
        {
            sec--;
        }

        if (sec == 0 && minutes != 0)
        {
            sec = 60;
            minutes--;
        }

        if (sec <= 10)
        {
            GameEndWaiting.instance.extraTime.SetActive(true);
        }

        timeText.text = "" + sec;

        fillLoading();

        StartCoroutine(second());
    }

    void fillLoading()
    {
        totalSeconds--;
        float fill = (float)totalSeconds / TOTAL_SECONDS;
        loading.fillAmount = fill;
    }

    public void ExtraTime()
    {
        if (Products.instance.goldCoin >= 5)
        {
            sec += 11;
            totalSeconds += sec;
            GameEndWaiting.instance.extraTime.SetActive(false);
            Products.instance.goldCoin -= 5;
            Products.instance.coinText.text = Products.instance.goldCoin.ToString();

            if (GameEndWaiting.instance.gameOver)
            {
                Products.instance.goldCount.text = Products.instance.goldCoin.ToString();
            }

            if (GameEndWaiting.instance.nextLevel)
            {
                Products.instance.goldCountNext.text = Products.instance.goldCoin.ToString();
            }
        }
        
    }
}
