using UnityEngine;

public class PointSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject item;

    [SerializeField]
    private float spawnRate;

    private float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        int coinCount = GameObject.FindGameObjectsWithTag("Coin").Length;

        if (timer > spawnRate && coinCount < 5)
        {
            SpawnObject();
            timer = 0;
        }
    }

    private void SpawnObject()
    {
        float x = Random.Range(-13f, 13f);
        float y = Random.Range(-4.5f, 4.5f);

        Vector3 spawnPos = new Vector3(x, y, 0f);

        Instantiate(item, spawnPos, Quaternion.identity);
    }
}
