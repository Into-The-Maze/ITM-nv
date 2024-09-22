using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

public class Cell
{
    public int x;
    public int y;
    public int width;
    public bool visited;
    public bool wall;
    public List<Entity> EntitiesToSpawn;
    public string tilesetName;

    public Cell(int x, int y)
    {
        this.x = x;
        this.y = y;
        visited = false;
        width = 1;
        wall = false;
        EntitiesToSpawn = new();
        tilesetName = string.Empty;
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
