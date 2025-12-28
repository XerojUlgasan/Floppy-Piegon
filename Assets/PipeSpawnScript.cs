using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public Camera cam;
    public int pipeRate = 2;
    public int minMaxPipeHeight = 2;
    private float timer = 0;
    private float highestPipe;
    private float lowestPipe;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float camSize = cam.orthographicSize;
        highestPipe = (transform.position.y + camSize) - minMaxPipeHeight;
        lowestPipe = (transform.position.y - camSize) + minMaxPipeHeight;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnPipe();
    }

    void SpawnPipe()
    {
        if (timer < pipeRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPipe, highestPipe), 0), transform.rotation);
            timer = 0;
        }
    }
}