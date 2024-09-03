using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell
{
    private int x; 
    private int y;
    private bool visited;
    List<GameObject> entities;


    public Cell(int x, int y)
    {
        this.x = x;
        this.y = y;
        entities = new List<GameObject>();
        visited = false;
    }

    public void SpawnEntity(float x, float y) {
        //todo
    }

    public void SpawnCreature(float x, float y) {
        //todo
    }

    public int X() => x;
    public int Y() => y;
    public bool Visited() => visited;
    public void SetVisited(bool newVisited) { visited = newVisited; }

}
