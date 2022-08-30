using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject pipe;

    private GameObject SpawnedPipe;

    [SerializeField]
    private Transform spawn;

    public bool stop = false;

    private float random;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PipeSpawner());
    }

    IEnumerator PipeSpawner()
    {
        while (stop != true)
        {
            yield return new WaitForSeconds(2);
            SpawnedPipe = Instantiate(pipe);

            SpawnedPipe.transform.position = spawn.position;

            random = Random.Range(-1.8f, 3.32f);
            transform.position = new Vector2(15f, random);
        }
    }
}
