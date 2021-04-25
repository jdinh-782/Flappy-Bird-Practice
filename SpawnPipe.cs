using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
    public float timeToSpawn;
    private float _timer = 0;
    public float height;
    public GameObject pipe;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        //create a new pipe after a certain amount of time has passed (preferably 1 second)
        if (_timer > timeToSpawn)
        {
           GameObject newPipe = Instantiate(pipe);
           newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

           Destroy(newPipe, 15);
           _timer = 0; 
        }
        _timer += Time.deltaTime;
    }
    
}
