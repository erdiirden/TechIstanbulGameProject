using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour
{
    public AudioSource gameOverSound;
    public GameObject Screen;
    public static bool isGame = false;


    private void Awake()
    {
        isGame = this;
    }
    void Start()
    {
        isGame = false;
        Screen.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "fruits")
        {
            gameOverSound.Play();
            Invoke("gameOverScreen", 1.4f);
            isGame = true;
        }
    }

    void gameOverScreen()
    {
        Time.timeScale = 0;
        Screen.SetActive(true);
    }
}
