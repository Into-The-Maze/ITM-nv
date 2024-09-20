using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Maze
{
    Cell[,] cells;
    int width;
    int height;

    //may need parameters changing to ensure a good interface
    //like adding a parameter for engine to AddPathsToMaze
    public abstract void InitMaze();
    public abstract void AddRoomsToMaze();
    public abstract void AddRoomsToMaze(string roomJSON);
    public abstract void AddPathsToMaze();
    public abstract void RemoveWallsFromMaze(int count);
    public virtual void ResetVisitedCells() {
        foreach (var cell in cells) {
            cell.visited = false;
        }
    }
}
