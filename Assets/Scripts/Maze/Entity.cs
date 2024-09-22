using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

public class Entity
{
    public string name;
    public double xPosToSpawnAtLocal;
    public double yPosToSpawnAtLocal;
    public double rotationToSpawnWith;

    public Entity(string name, double x, double y, double rotation)
    {
        this.name = name;
        xPosToSpawnAtLocal = x;
        yPosToSpawnAtLocal = y;
        rotationToSpawnWith = rotation;
    }

    [JsonConstructor]
    public Entity() { }
}
