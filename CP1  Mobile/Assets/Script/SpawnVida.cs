using System.Collections;
using UnityEngine;

public class SpawnVida : MonoBehaviour
{
    [SerializeField] GameObject[] ancoraVida;
    [SerializeField] GameObject vida;

    void Start()
    {
        StartCoroutine(VidaSpawn());
    }

    
    void Update()
    {
        
    }


    

    void Spawn()
    {
        int spawn = Random.Range(0, ancoraVida.Length);
        if (spawn == 0)
        {
            Instantiate(vida, ancoraVida[0].transform);
        }
        else if (spawn == 1)
        {
            Instantiate(vida, ancoraVida[1].transform);
        }
        else if (spawn == 2)
        {
            Instantiate(vida, ancoraVida[2].transform);
        }
        else if (spawn == 3)
        {
            Instantiate(vida, ancoraVida[3].transform);
        }
        else if (spawn == 4)
        {
            Instantiate(vida, ancoraVida[4].transform);
        }
        else if (spawn == 5)
        {
            Instantiate(vida, ancoraVida[5].transform);
        }
        else if (spawn == 6)
        {
            Instantiate(vida, ancoraVida[6].transform);
        }
        else if (spawn == 7)
        {
            Instantiate(vida, ancoraVida[7].transform);
        }
        else if (spawn == 8)
        {
            Instantiate(vida, ancoraVida[8].transform);
        }
    }

    IEnumerator VidaSpawn()
    {
        Spawn();
        yield return new WaitForSeconds(15);
        StartCoroutine(VidaSpawn());
    }


}
