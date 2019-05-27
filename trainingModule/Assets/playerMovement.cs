using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    float mousePos;
    int count;
    int hit;
    bool paused;
    public Text number;
    public Text gameOver;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    //private RigidBody2D snowman;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, -4.05f, -0f);
        count = 0;
        paused = false;
        setScoreText();
        hit = 0;
    }
    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition.x;
        if (mousePos < -23.4f)
        {
            mousePos = -23.4f;
        }
        else if (mousePos > 23.4f)
        {
            mousePos = 23.4f;
        }
        transform.position = new Vector3(mousePos, -35.25f, -0f); 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("fire"))
        {
            collision.transform.position = new Vector3(Random.Range(-23f, 23f), 45f, -0f);
            hitFire();
        }
        else if (collision.gameObject.CompareTag("snow"))
        {
            collision.transform.position = new Vector3(Random.Range(-23f, 23f), 45f, -0f);
            if (paused == false) { count += 1; }
            setScoreText();
        }
    }
    void setScoreText()
    {
        number.text = count.ToString();
    }
    void hitFire()
    {
        hit += 1;
        if(hit == 3)
        {
            Heart1.SetActive(false);
            //stopGame
            paused = true;
            gameOver.text = "Game over! Good Job!";
            Invoke("FinishedGame",5f);
        }
        else if(hit == 1)
        {
            Heart3.SetActive(false);
        }
        else if(hit == 2)
        {
            Heart2.SetActive(false);
        }
    }
    void FinishedGame()
    {
        SceneManager.LoadScene("Game");
    }
}
