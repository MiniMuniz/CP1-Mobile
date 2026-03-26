using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Tiro : MonoBehaviour
{
    [SerializeField] int speedX;
    [SerializeField] int speedY;

    
    


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Translate(new Vector2 (speedX * Time.deltaTime, speedY * Time.deltaTime));
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Parede"))
        {
            Destroy(gameObject);
        }
    }
}
