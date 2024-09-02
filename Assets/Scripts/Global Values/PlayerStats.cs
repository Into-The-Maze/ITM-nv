using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PSTATS
{
    public static uint STRENGTH;
    public static WEIGHT_CLASS WEIGHT_CLASS;
    public static uint AGILITY;
    public static double ENERGY;
    public static double MENTAL;
    public static uint PERCEPTION;
    public static uint ADRENALINE;

    public static double WEIGHT;
    public static double MAX_WEIGHT;

    public static float PLAYER_SPEED = 1f;
    public static float PLAYER_ACCELERATION = 5f;
    public static float PLAYER_DECELERATION = 4f;
    public static float PLAYER_SPRINT_SPEED_MULTIPLIER = 1.5f;
    public static float PLAYER_TURN_SPEED = 200f;
}

public enum WEIGHT_CLASS
{
    LIGHT,
    MEDIUM,
    HEAVY,
    OVER,
}