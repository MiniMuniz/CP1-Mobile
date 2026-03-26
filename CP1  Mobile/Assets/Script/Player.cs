using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Player : MonoBehaviour
{
    [Header("Player Settings")]
    [SerializeField] private float speed;
    [SerializeField] private float stepSpeed;
    [SerializeField] private float currentLaneX = 0;
    [SerializeField] private float currentLaneY = 0;
    [SerializeField] private float laneLimit = 1;

    [SerializeField] int vida = 3;
    [SerializeField] Text textoVida;
    [SerializeField] Text textoTempo;
    [SerializeField] int tempo = 60;

    [SerializeField] Button start;
    [SerializeField] Button reiniciar;

    [SerializeField] GameObject startPanel;
    [SerializeField] GameObject reiniciarPanel;

    private Vector2 currentPosition;

    private void Start()
    {
        StartCoroutine(Timer());
        currentPosition = transform.position;
        start.onClick.AddListener(StartGame);
        reiniciar.onClick.AddListener(TryAgain);
        Time.timeScale = 0.0f;
        reiniciarPanel.SetActive(false);
    }

    private void TryAgain()
    {
        SceneManager.LoadScene("Game"); 
    }

    private void StartGame()
    {
        Time.timeScale = 1.0f;
        startPanel.SetActive(false);
    }

    private void Update()
    {
        currentPosition = new Vector2(currentLaneX, currentLaneY);
        transform.position = Vector2.MoveTowards(transform.position, currentPosition, stepSpeed * Time.deltaTime);

        textoTempo.text = tempo.ToString();
        textoVida.text = vida.ToString();

        if(vida <= 0 || tempo <= 0)
        {
            Time.timeScale = 0.0f;
            reiniciarPanel.SetActive(true);
        }
    }

    public void ChangeLane(int direction)
    {
        if (direction < 0)
        {
            if (currentLaneX > -laneLimit)
            {
                currentLaneX += direction;
            }
        }
        else if (direction > 0)
        {
            if (currentLaneX < laneLimit)
            {
                currentLaneX += direction;
            }
        }
    }

    public void ChangeLaneY(int directionY)
    {
        if (directionY < 0)
        {
            if (currentLaneY > -laneLimit)
            {
                currentLaneY += directionY;
            }
        }
        else if (directionY > 0)
        {
            if (currentLaneY < laneLimit)
            {
                currentLaneY += directionY;
            }
        }
    }

    IEnumerator Timer()
    {
        tempo--;
        yield return new WaitForSeconds(1);
        StartCoroutine(Timer());
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Parede"))
        {
            vida--;
            tempo = tempo - 20;
        }
        if (collision.gameObject.CompareTag("Vida"))
        {
            vida++;
            tempo = tempo + 15;
            Destroy(collision.gameObject);
        }

    }



}
