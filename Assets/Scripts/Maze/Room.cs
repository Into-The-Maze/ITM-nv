using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class Room
{
    List<Cell> cells;

    [JsonConstructor]
    public Room() { }
}
