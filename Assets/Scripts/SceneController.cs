using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public const int gridRows = 2;
    public const int gridCols = 3;
    public const float offsetX = 2f;
    public const float offsetZ = 3f;

    [SerializeField] private CardMatch originalCard;
    [SerializeField] private Sprite[] images;

    public static SceneController instance;

    public int[] numbers = { 0, 0, 1, 1, 2, 2, 3, 3 };
    public int index;
    public int id;

    public int nextSceneLoad;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Vector3 startPos = originalCard.transform.position;

        if (SceneManager.GetActiveScene().name == "Episode1")
        {
            StartCoroutine("EndUi");
        }

        if (SceneManager.GetActiveScene().name == "Episode2")
        {
            StartCoroutine("EndUi2");
        }

        if (SceneManager.GetActiveScene().name == "Episode3")
        {
            StartCoroutine("EndUi3");
        }

        if (SceneManager.GetActiveScene().name == "Episode4")
        {
            StartCoroutine("EndUi4");
        }

        if (SceneManager.GetActiveScene().name == "Episode5")
        {
            StartCoroutine("EndUi5");
        }

        if (SceneManager.GetActiveScene().name == "Episode6")
        {
            StartCoroutine("EndUi6");
        }

        if (SceneManager.GetActiveScene().name == "Episode7")
        {
            StartCoroutine("EndUi7");
        }

        if (SceneManager.GetActiveScene().name == "Episode8")
        {
            StartCoroutine("EndUi8");
        }

        if (SceneManager.GetActiveScene().name == "Episode9")
        {
            StartCoroutine("EndUi9");
        }

        if (SceneManager.GetActiveScene().name == "Episode10")
        {
            StartCoroutine("EndUi10");
        }

        numbers = ShuffleArray(numbers);

        for (int i = 0; i < gridCols; i++)
        {
            for (int j = 0; j < gridRows; j++)
            {
                CardMatch card;
                if (i == 0 && j == 0)
                {
                    card = originalCard;
                }
                else
                {
                    card = Instantiate(originalCard) as CardMatch;
                }

                index = j * gridCols + i;
                id = numbers[index];
                card.ChangeSprite(id, images[id]);

                float posX = (offsetX * i) + startPos.x;
                float posZ = (offsetZ * j) + startPos.z;
                card.transform.position = new Vector3(posX, startPos.y, posZ);
            }
        }
    }

    IEnumerator EndUi()
    {
        GameEndWaiting.instance.enabled = false;
        CustomerMovement.instance.enabled = false;
        GameEndWaiting.instance.characters.SetActive(false);
        GameEndWaiting.instance.timer.SetActive(false);
        GameEndWaiting.instance.extraTime.SetActive(false);
        GameEndWaiting.instance.goldCoin.SetActive(false);
        Waypoints.instance.yourGoal.SetActive(true);
        yield return new WaitForSeconds(2);
        Waypoints.instance.yourGoal.SetActive(false);
        Waypoints.instance.episode1.SetActive(true);
        yield return new WaitForSeconds(2);
        Waypoints.instance.episode1.SetActive(false);
        GameEndWaiting.instance.enabled = true;
        GameEndWaiting.instance.timer.SetActive(true);
        GameEndWaiting.instance.goldCoin.SetActive(true);
        CustomerMovement.instance.enabled = true;
        GameEndWaiting.instance.characters.SetActive(true);
    }

    IEnumerator EndUi2()
    {
        GameEndWaiting.instance.enabled = false;
        CustomerMovement.instance.enabled = false;
        GameEndWaiting.instance.characters.SetActive(false);
        GameEndWaiting.instance.timer.SetActive(false);
        GameEndWaiting.instance.extraTime.SetActive(false);
        GameEndWaiting.instance.goldCoin.SetActive(false);
        Waypoints.instance.yourGoal.SetActive(true);
        yield return new WaitForSeconds(2);
        Waypoints.instance.yourGoal.SetActive(false);
        Waypoints.instance.episode2.SetActive(true);
        yield return new WaitForSeconds(2);
        Waypoints.instance.episode2.SetActive(false);
        GameEndWaiting.instance.enabled = true;
        GameEndWaiting.instance.timer.SetActive(true);
        GameEndWaiting.instance.goldCoin.SetActive(true);
        CustomerMovement.instance.enabled = true;
        GameEndWaiting.instance.characters.SetActive(true);
    }

    IEnumerator EndUi3()
    {
        GameEndWaiting.instance.enabled = false;
        CustomerMovement.instance.enabled = false;
        GameEndWaiting.instance.characters.SetActive(false);
        GameEndWaiting.instance.timer.SetActive(false);
        GameEndWaiting.instance.extraTime.SetActive(false);
        GameEndWaiting.instance.goldCoin.SetActive(false);
        Waypoints.instance.yourGoal.SetActive(true);
        yield return new WaitForSeconds(2);
        Waypoints.instance.yourGoal.SetActive(false);
        Waypoints.instance.episode3.SetActive(true);
        yield return new WaitForSeconds(2);
        Waypoints.instance.episode3.SetActive(false);
        GameEndWaiting.instance.enabled = true;
        GameEndWaiting.instance.timer.SetActive(true);
        GameEndWaiting.instance.goldCoin.SetActive(true);
        CustomerMovement.instance.enabled = true;
        GameEndWaiting.instance.characters.SetActive(true);
    }

    IEnumerator EndUi4()
    {
        GameEndWaiting.instance.enabled = false;
        CustomerMovement.instance.enabled = false;
        GameEndWaiting.instance.characters.SetActive(false);
        GameEndWaiting.instance.timer.SetActive(false);
        GameEndWaiting.instance.extraTime.SetActive(false);
        GameEndWaiting.instance.goldCoin.SetActive(false);
        Waypoints.instance.yourGoal.SetActive(true);
        yield return new WaitForSeconds(2);
        Waypoints.instance.yourGoal.SetActive(false);
        Waypoints.instance.episode4.SetActive(true);
        yield return new WaitForSeconds(2);
        Waypoints.instance.episode4.SetActive(false);
        GameEndWaiting.instance.enabled = true;
        GameEndWaiting.instance.timer.SetActive(true);
        GameEndWaiting.instance.goldCoin.SetActive(true);
        CustomerMovement.instance.enabled = true;
        GameEndWaiting.instance.characters.SetActive(true);
    }

    IEnumerator EndUi5()
    {
        GameEndWaiting.instance.enabled = false;
        CustomerMovement.instance.enabled = false;
        GameEndWaiting.instance.characters.SetActive(false);
        GameEndWaiting.instance.timer.SetActive(false);
        GameEndWaiting.instance.extraTime.SetActive(false);
        GameEndWaiting.instance.goldCoin.SetActive(false);
        Waypoints.instance.yourGoal.SetActive(true);
        yield return new WaitForSeconds(2);
        Waypoints.instance.yourGoal.SetActive(false);
        Waypoints.instance.episode5.SetActive(true);
        yield return new WaitForSeconds(2);
        Waypoints.instance.episode5.SetActive(false);
        GameEndWaiting.instance.enabled = true;
        GameEndWaiting.instance.timer.SetActive(true);
        GameEndWaiting.instance.goldCoin.SetActive(true);
        CustomerMovement.instance.enabled = true;
        GameEndWaiting.instance.characters.SetActive(true);
    }

    IEnumerator EndUi6()
    {
        GameEndWaiting.instance.enabled = false;
        CustomerMovement.instance.enabled = false;
        GameEndWaiting.instance.characters.SetActive(false);
        GameEndWaiting.instance.timer.SetActive(false);
        GameEndWaiting.instance.extraTime.SetActive(false);
        GameEndWaiting.instance.goldCoin.SetActive(false);
        Waypoints.instance.yourGoal.SetActive(true);
        yield return new WaitForSeconds(2);
        Waypoints.instance.yourGoal.SetActive(false);
        Waypoints.instance.episode6.SetActive(true);
        yield return new WaitForSeconds(2);
        Waypoints.instance.episode6.SetActive(false);
        GameEndWaiting.instance.enabled = true;
        GameEndWaiting.instance.timer.SetActive(true);
        GameEndWaiting.instance.goldCoin.SetActive(true);
        CustomerMovement.instance.enabled = true;
        GameEndWaiting.instance.characters.SetActive(true);
    }

    IEnumerator EndUi7()
    {
        GameEndWaiting.instance.enabled = false;
        CustomerMovement.instance.enabled = false;
        GameEndWaiting.instance.characters.SetActive(false);
        GameEndWaiting.instance.timer.SetActive(false);
        GameEndWaiting.instance.extraTime.SetActive(false);
        GameEndWaiting.instance.goldCoin.SetActive(false);
        Waypoints.instance.yourGoal.SetActive(true);
        yield return new WaitForSeconds(2);
        Waypoints.instance.yourGoal.SetActive(false);
        Waypoints.instance.episode7.SetActive(true);
        yield return new WaitForSeconds(2);
        Waypoints.instance.episode7.SetActive(false);
        GameEndWaiting.instance.enabled = true;
        GameEndWaiting.instance.timer.SetActive(true);
        GameEndWaiting.instance.goldCoin.SetActive(true);
        CustomerMovement.instance.enabled = true;
        GameEndWaiting.instance.characters.SetActive(true);
    }

    IEnumerator EndUi8()
    {
        GameEndWaiting.instance.enabled = false;
        CustomerMovement.instance.enabled = false;
        GameEndWaiting.instance.characters.SetActive(false);
        GameEndWaiting.instance.timer.SetActive(false);
        GameEndWaiting.instance.extraTime.SetActive(false);
        GameEndWaiting.instance.goldCoin.SetActive(false);
        Waypoints.instance.yourGoal.SetActive(true);
        yield return new WaitForSeconds(2);
        Waypoints.instance.yourGoal.SetActive(false);
        Waypoints.instance.episode8.SetActive(true);
        yield return new WaitForSeconds(2);
        Waypoints.instance.episode8.SetActive(false);
        GameEndWaiting.instance.enabled = true;
        GameEndWaiting.instance.timer.SetActive(true);
        GameEndWaiting.instance.goldCoin.SetActive(true);
        CustomerMovement.instance.enabled = true;
        GameEndWaiting.instance.characters.SetActive(true);
    }

    IEnumerator EndUi9()
    {
        GameEndWaiting.instance.enabled = false;
        CustomerMovement.instance.enabled = false;
        GameEndWaiting.instance.characters.SetActive(false);
        GameEndWaiting.instance.timer.SetActive(false);
        GameEndWaiting.instance.extraTime.SetActive(false);
        GameEndWaiting.instance.goldCoin.SetActive(false);
        Waypoints.instance.yourGoal.SetActive(true);
        yield return new WaitForSeconds(2);
        Waypoints.instance.yourGoal.SetActive(false);
        Waypoints.instance.episode9.SetActive(true);
        yield return new WaitForSeconds(2);
        Waypoints.instance.episode9.SetActive(false);
        GameEndWaiting.instance.enabled = true;
        GameEndWaiting.instance.timer.SetActive(true);
        GameEndWaiting.instance.goldCoin.SetActive(true);
        CustomerMovement.instance.enabled = true;
        GameEndWaiting.instance.characters.SetActive(true);
    }

    IEnumerator EndUi10()
    {
        GameEndWaiting.instance.enabled = false;
        CustomerMovement.instance.enabled = false;
        GameEndWaiting.instance.characters.SetActive(false);
        GameEndWaiting.instance.timer.SetActive(false);
        GameEndWaiting.instance.extraTime.SetActive(false);
        GameEndWaiting.instance.goldCoin.SetActive(false);
        Waypoints.instance.yourGoal.SetActive(true);
        yield return new WaitForSeconds(2);
        Waypoints.instance.yourGoal.SetActive(false);
        Waypoints.instance.episode10.SetActive(true);
        yield return new WaitForSeconds(2);
        Waypoints.instance.episode10.SetActive(false);
        GameEndWaiting.instance.enabled = true;
        GameEndWaiting.instance.timer.SetActive(true);
        GameEndWaiting.instance.goldCoin.SetActive(true);
        CustomerMovement.instance.enabled = true;
        GameEndWaiting.instance.characters.SetActive(true);
    }

    public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        if(SceneManager.GetActiveScene().name == "Episode1")
        {
            StartCoroutine("EndUi");
        } 
        
        if (SceneManager.GetActiveScene().name == "Episode2")
        {
            StartCoroutine("EndUi2");
        }

        if (SceneManager.GetActiveScene().name == "Episode3")
        {
            StartCoroutine("EndUi3");
        }

        if (SceneManager.GetActiveScene().name == "Episode4")
        {
            StartCoroutine("EndUi4");
        }

        if (SceneManager.GetActiveScene().name == "Episode5")
        {
            StartCoroutine("EndUi5");
        }

        if (SceneManager.GetActiveScene().name == "Episode6")
        {
            StartCoroutine("EndUi6");
        }

        if (SceneManager.GetActiveScene().name == "Episode7")
        {
            StartCoroutine("EndUi7");
        }

        if (SceneManager.GetActiveScene().name == "Episode8")
        {
            StartCoroutine("EndUi8");
        }

        if (SceneManager.GetActiveScene().name == "Episode9")
        {
            StartCoroutine("EndUi9");
        }

        if (SceneManager.GetActiveScene().name == "Episode10")
        {
            StartCoroutine("EndUi10");
        }
    }

    public void NextLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        if (SceneManager.GetActiveScene().name == "Episode1")
        {
            StartCoroutine("EndUi2");
        }

        if (SceneManager.GetActiveScene().name == "Episode2")
        {
            StartCoroutine("EndUi3");
        }

        if (SceneManager.GetActiveScene().name == "Episode3")
        {
            StartCoroutine("EndUi4");
        }

        if (SceneManager.GetActiveScene().name == "Episode4")
        {
            StartCoroutine("EndUi5");
        }

        if (SceneManager.GetActiveScene().name == "Episode5")
        {
            StartCoroutine("EndUi6");
        }

        if (SceneManager.GetActiveScene().name == "Episode6")
        {
            StartCoroutine("EndUi7");
        }

        if (SceneManager.GetActiveScene().name == "Episode7")
        {
            StartCoroutine("EndUi8");
        }

        if (SceneManager.GetActiveScene().name == "Episode8")
        {
            StartCoroutine("EndUi9");
        }

        if (SceneManager.GetActiveScene().name == "Episode9")
        {
            StartCoroutine("EndUi10");
        }
    }

    private int[] ShuffleArray(int[] numbers)
    {
        int[] newArray = numbers.Clone() as int[];
        for (int i = 0; i < newArray.Length; i++)
        {
            int tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;
    }

    private CardMatch _firstRevealed;
    private CardMatch _secondRevealed;

    public bool canReveal
    {
        get { return _secondRevealed == null; }
    }

    public void CardRevealed(CardMatch card)
    {
        if (_firstRevealed == null)
        {
            _firstRevealed = card;
        }
        else
        {
            _secondRevealed = card;
            StartCoroutine(CheckMatch());
        }
    }

    private IEnumerator CheckMatch()
    {
        if (_firstRevealed.id == _secondRevealed.id)
        {
            Debug.Log("Match Card");
            if (images[_firstRevealed.id].name == "AppleCard")
            {
                Debug.Log("apple");
                ProductApple.instance.CreateApple();
                yield return new WaitForSeconds(1f);

                _firstRevealed.UnReveal();
                _secondRevealed.UnReveal();

                numbers = ShuffleArray(numbers);

                for (int i = 0; i < gridCols; i++)
                {
                    for (int j = 0; j < gridRows; j++)
                    {
                        index = j * gridCols + i;
                        id = numbers[index];
                        _secondRevealed.ChangeSprite(id, images[id]);
                    }
                }

            }

            if (images[_firstRevealed.id].name == "CherryCard")
            {
                Debug.Log("cherry");
                ProductCherry.instance.CreateCherry();
                yield return new WaitForSeconds(1f);

                _firstRevealed.UnReveal();
                _secondRevealed.UnReveal();

                numbers = ShuffleArray(numbers);

                for (int i = 0; i < gridCols; i++)
                {
                    for (int j = 0; j < gridRows; j++)
                    {
                        index = j * gridCols + i;
                        id = numbers[index];
                        _secondRevealed.ChangeSprite(id, images[id]);
                    }
                }
            }

            if (images[_firstRevealed.id].name == "LemonCard")
            {
                Debug.Log("lemon");
                ProductLemon.instance.CreateLemon();
                yield return new WaitForSeconds(1f);

                _firstRevealed.UnReveal();
                _secondRevealed.UnReveal();

                numbers = ShuffleArray(numbers);

                for (int i = 0; i < gridCols; i++)
                {
                    for (int j = 0; j < gridRows; j++)
                    {
                        index = j * gridCols + i;
                        id = numbers[index];
                        _secondRevealed.ChangeSprite(id, images[id]);
                    }
                }
            }

            if (images[_firstRevealed.id].name == "OrangeCard")
            {
                Debug.Log("orange");
                ProductOrange.instance.CreateOrange();
                yield return new WaitForSeconds(1f);

                _firstRevealed.UnReveal();
                _secondRevealed.UnReveal();

                numbers = ShuffleArray(numbers);

                for (int i = 0; i < gridCols; i++)
                {
                    for (int j = 0; j < gridRows; j++)
                    {
                        index = j * gridCols + i;
                        id = numbers[index];
                        _secondRevealed.ChangeSprite(id, images[id]);
                    }
                }
            }

            if (images[_firstRevealed.id].name == "PearCard")
            {
                Debug.Log("pear");
                ProductPear.instance.CreatePear();
                yield return new WaitForSeconds(1f);

                _firstRevealed.UnReveal();
                _secondRevealed.UnReveal();

                numbers = ShuffleArray(numbers);

                for (int i = 0; i < gridCols; i++)
                {
                    for (int j = 0; j < gridRows; j++)
                    {
                        index = j * gridCols + i;
                        id = numbers[index];
                        _secondRevealed.ChangeSprite(id, images[id]);
                    }
                }
            }
        }
        else
        {
            yield return new WaitForSeconds(0.5f);

            _firstRevealed.UnReveal();
            _secondRevealed.UnReveal();
        }

        _firstRevealed = null;
        _secondRevealed = null;
    }
}
