using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private Transform player;
    public GameObject[] chunks;
    public GameObject platform;
    // public GameObject terrain;
    private int spawn_position = -450;
    private int range = 20;
    private int p_spawn_position = 1000;
    private int p_range = 100;
    private int coll = 10;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < coll; i++)
        {
            Gen(Random.Range(0,chunks.Length));
        }
        GenRace();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.z > spawn_position - (coll * range))
        {
            Gen(Random.Range(0,chunks.Length));
        }
    }
    private void GenRace()
    {
        // Instantiate(terrain, transform.forward * p_spawn_position, transform.rotation);
        Instantiate(platform, transform.forward * p_spawn_position, transform.rotation);
        p_spawn_position += p_range;
    }
    private void Gen(int chunksIndex)
    {
        Instantiate(chunks[chunksIndex], transform.forward * spawn_position, transform.rotation);
        spawn_position += range;
    }
}
