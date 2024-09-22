using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

public class Room
{
    public Cell[,] cells;
    public int width;
    public int height;
    public string name;

    public Room(int width, int height, string name)
    {
        this.width = width;
        this.height = height;
        this.name = name;
        cells = new Cell[height, width];
    }
    [JsonConstructor]
    public Room() { }
}
