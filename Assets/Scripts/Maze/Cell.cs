using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell
{
    public int x;
    public int y;
    public int width;
    public bool visited;
    public List<Entity> EntitiesToSpawn;

    public Cell(int x, int y)
    {
        this.x = x;
        this.y = y;
        visited = false;
        width = 1;
    }

    [JsonConstructor]
    public Cell()
    {
            
    }

    public void SpawnEntity(float x, float y) {
        //todo
    }

    public void SpawnCreature(float x, float y) {
        //todo
    }
}
