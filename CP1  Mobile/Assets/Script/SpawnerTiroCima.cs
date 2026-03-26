using System.Collections;
using UnityEngine;

public class SpawnerTiro : MonoBehaviour
{

    [SerializeField] GameObject tiroBaixo;
    [SerializeField] GameObject tiroEsquerda;
    [SerializeField] GameObject tiroCima;
    [SerializeField] GameObject tiroDireita;
    [SerializeField] GameObject[] ancora;

    void Start()
    {
        StartCoroutine(TimerSpawn());
    }

    void Update()
    {
        
    }

    void Spawnar()
    {
        int spawn = Random.Range(0, ancora.Length);
        if (spawn == 0)
        {
            Instantiate(tiroBaixo, ancora[0].transform);
        }
        else if (spawn == 1)
        {
            Instantiate(tiroBaixo, ancora[1].transform);
        }
        else if (spawn == 2)
        {
            Instantiate(tiroBaixo, ancora[2].transform);
        }
        else if (spawn == 3)
        {
            Instantiate(tiroEsquerda, ancora[3].transform);
        }
        else if (spawn == 4)
        {
            Instantiate(tiroEsquerda, ancora[4].transform);
        }
        else if (spawn == 5)
        {
            Instantiate(tiroEsquerda, ancora[5].transform);
        }
        else if (spawn == 6)
        {
            Instantiate(tiroCima, ancora[6].transform);
        }
        else if (spawn == 7)
        {
            Instantiate(tiroCima, ancora[7].transform);
        }
        else if (spawn == 8)
        {
            Instantiate(tiroCima, ancora[8].transform);
        }
        else if (spawn == 9)
        {
            Instantiate(tiroDireita, ancora[9].transform);
        }
        else if (spawn == 10)
        {
            Instantiate(tiroDireita, ancora[10].transform);
        }
        else if (spawn == 11)
        {
            Instantiate(tiroDireita, ancora[11].transform);
        }
    }

    IEnumerator TimerSpawn()
    {
        Spawnar();
        yield return new WaitForSeconds(1);
        StartCoroutine(TimerSpawn());
    }


}
