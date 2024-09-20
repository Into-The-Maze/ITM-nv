using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class Room
{
    public Cell[,] cells;
    public int width;
    public int height;
    public string name;
    

    [JsonConstructor]
    public Room() { }
}
