using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawn : MonoBehaviour
{
    public GameObject columnprefab;
    public float minY,maxY;
    float time;
    public float maxTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= maxTime)
        {
            Spawn();
            time = 0;
        }
    }
    void Spawn()
    {
        float randomY = Random.Range(minY, maxY);
        GameObject tempColumn = Instantiate(columnprefab);
        tempColumn.transform.position = new Vector2(transform.position.x, randomY);

    }
}
