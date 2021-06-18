using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shopping : MonoBehaviour
{
    #region Private Properties
    float ZPosition;
    Vector3 Offset;
    bool Dragging;
    #endregion

    #region Inspector Variables
    public Camera MainCamera;
    [Space]
    [SerializeField]
    public UnityEvent OnBeginDrag;
    [SerializeField]
    public UnityEvent OnEndDrag;
    #endregion

    public GameObject waypoints;

    float holdTime;

    #region Unity Functions
    void Start()
    {
        ZPosition = MainCamera.WorldToScreenPoint(transform.position).z;
    }

    void Update()
    {
        if (Dragging)
        {
            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, ZPosition);
            transform.position = MainCamera.ScreenToWorldPoint(position + new Vector3(Offset.x, Offset.y));
        }
    }

    void OnMouseDown()
    {
        if (!Dragging)
        {
            BeginDrag();
        }
    }

    void OnMouseUp()
    {
        EndDrag();
    }
    #endregion

    #region User Interface
    public void BeginDrag()
    {
        OnBeginDrag.Invoke();
        Dragging = true;
        Offset = MainCamera.WorldToScreenPoint(transform.position) - Input.mousePosition;
    }

    public void EndDrag()
    {
        OnEndDrag.Invoke();
        Dragging = false;
    }
    #endregion

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Character")
        {
            if (gameObject.tag == "Apple")
            {
                if (Products.instance.appleActive)
                {
                    Destroy(gameObject);

                    if (SceneManager.GetActiveScene().name == "Episode1")
                    {
                        Products.instance.goldCoin += 3;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode2")
                    {
                        Products.instance.goldCoin += 5;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode3")
                    {
                        Products.instance.goldCoin += 7;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode4")
                    {
                        Products.instance.goldCoin += 9;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode5")
                    {
                        Products.instance.goldCoin += 11;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode6")
                    {
                        Products.instance.goldCoin += 6;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode7")
                    {
                        Products.instance.goldCoin += 9;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode8")
                    {
                        Products.instance.goldCoin += 12;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode9")
                    {
                        Products.instance.goldCoin += 15;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode10")
                    {
                        Products.instance.goldCoin += 18;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    Products.instance.customerCount++;

                    if (GameEndWaiting.instance.gameOver)
                    {
                        Products.instance.customerCountText.text = Products.instance.customerCount.ToString();
                    }

                    if (GameEndWaiting.instance.nextLevel)
                    {
                        Products.instance.customerCountNext.text = Products.instance.customerCount.ToString();
                    }

                    CustomerMovement.instance.enabled = false;
                    CustomerMovement2.instance.enabled = true;
                    Products.instance.products.SetActive(false);
                }
            }

            if (gameObject.tag == "Cherry")
            {
                if (Products.instance.cherryActive)
                {
                    Destroy(gameObject);

                    if (SceneManager.GetActiveScene().name == "Episode1")
                    { 
                        Products.instance.goldCoin += 3;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode2")
                    {
                        Products.instance.goldCoin += 5;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode3")
                    {
                        Products.instance.goldCoin += 7;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode4")
                    {
                        Products.instance.goldCoin += 9;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode5")
                    {
                        Products.instance.goldCoin += 11;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode6")
                    {
                        Products.instance.goldCoin += 6;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode7")
                    {
                        Products.instance.goldCoin += 9;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode8")
                    {
                        Products.instance.goldCoin += 12;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode9")
                    {
                        Products.instance.goldCoin += 15;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode10")
                    {
                        Products.instance.goldCoin += 18;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    Products.instance.customerCount++;

                    if (GameEndWaiting.instance.gameOver)
                    {
                        Products.instance.customerCountText.text = Products.instance.customerCount.ToString();
                    }

                    if (GameEndWaiting.instance.nextLevel)
                    {
                        Products.instance.customerCountNext.text = Products.instance.customerCount.ToString();
                    }

                    CustomerMovement.instance.enabled = false;
                    CustomerMovement2.instance.enabled = true;
                    Products.instance.products.SetActive(false);
                }
            }

            if (gameObject.tag == "Lemon")
            {
                if (Products.instance.lemonActive)
                {
                    Destroy(gameObject);

                    if (SceneManager.GetActiveScene().name == "Episode1")
                    {
                        Products.instance.goldCoin += 3;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode2")
                    {
                        Products.instance.goldCoin += 5;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode3")
                    {
                        Products.instance.goldCoin += 7;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode4")
                    {
                        Products.instance.goldCoin += 9;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode5")
                    {
                        Products.instance.goldCoin += 11;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode6")
                    {
                        Products.instance.goldCoin += 6;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode7")
                    {
                        Products.instance.goldCoin += 9;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode8")
                    {
                        Products.instance.goldCoin += 12;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode9")
                    {
                        Products.instance.goldCoin += 15;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode10")
                    {
                        Products.instance.goldCoin += 18;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    Products.instance.customerCount++;

                    if (GameEndWaiting.instance.gameOver)
                    {
                        Products.instance.customerCountText.text = Products.instance.customerCount.ToString();
                    }

                    if (GameEndWaiting.instance.nextLevel)
                    {
                        Products.instance.customerCountNext.text = Products.instance.customerCount.ToString();
                    }

                    CustomerMovement.instance.enabled = false;
                    CustomerMovement2.instance.enabled = true;
                    Products.instance.products.SetActive(false);
                }
            }

            if (gameObject.tag == "Orange")
            {
                if (Products.instance.orangeActive)
                {
                    Destroy(gameObject);

                    if (SceneManager.GetActiveScene().name == "Episode1")
                    {
                        Products.instance.goldCoin += 3;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode2")
                    {
                        Products.instance.goldCoin += 5;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode3")
                    {
                        Products.instance.goldCoin += 7;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode4")
                    {
                        Products.instance.goldCoin += 9;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode5")
                    {
                        Products.instance.goldCoin += 11;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode6")
                    {
                        Products.instance.goldCoin += 6;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode7")
                    {
                        Products.instance.goldCoin += 9;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode8")
                    {
                        Products.instance.goldCoin += 12;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode9")
                    {
                        Products.instance.goldCoin += 15;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode10")
                    {
                        Products.instance.goldCoin += 18;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    Products.instance.customerCount++;

                    if (GameEndWaiting.instance.gameOver)
                    {
                        Products.instance.customerCountText.text = Products.instance.customerCount.ToString();
                    }

                    if (GameEndWaiting.instance.nextLevel)
                    {
                        Products.instance.customerCountNext.text = Products.instance.customerCount.ToString();
                    }

                    CustomerMovement.instance.enabled = false;
                    CustomerMovement2.instance.enabled = true;
                    Products.instance.products.SetActive(false);
                }
            }

            if (gameObject.tag == "Pear")
            {
                if (Products.instance.pearActive)
                {
                    Destroy(gameObject);

                    if (SceneManager.GetActiveScene().name == "Episode1")
                    {
                        Products.instance.goldCoin += 3;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode2")
                    {
                        Products.instance.goldCoin += 5;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode3")
                    {
                        Products.instance.goldCoin += 7;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode4")
                    {
                        Products.instance.goldCoin += 9;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode5")
                    {
                        Products.instance.goldCoin += 11;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode6")
                    {
                        Products.instance.goldCoin += 6;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode7")
                    {
                        Products.instance.goldCoin += 9;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode8")
                    {
                        Products.instance.goldCoin += 12;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode9")
                    {
                        Products.instance.goldCoin += 15;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    if (SceneManager.GetActiveScene().name == "Episode10")
                    {
                        Products.instance.goldCoin += 18;
                        Instantiate(Products.instance.goldEffect, CustomerMovement.instance.character.transform.position, Quaternion.identity);
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

                    Products.instance.customerCount++;

                    if (GameEndWaiting.instance.gameOver)
                    {
                        Products.instance.customerCountText.text = Products.instance.customerCount.ToString();
                    }

                    if (GameEndWaiting.instance.nextLevel)
                    {
                        Products.instance.customerCountNext.text = Products.instance.customerCount.ToString();
                    }

                    CustomerMovement.instance.enabled = false;
                    CustomerMovement2.instance.enabled = true;
                    Products.instance.products.SetActive(false);
                }
            }
        }
    }
}
