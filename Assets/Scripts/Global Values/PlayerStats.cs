using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PSTATS
{
    static uint STRENGTH;
    static WEIGHT_CLASS WEIGHT_CLASS;
    static uint AGILITY;
    static double ENERGY;
    static double MENTAL;
    static uint PERCEPTION;
    static uint ADRENALINE;

    static double WEIGHT;
    static double MAX_WEIGHT;
}

enum WEIGHT_CLASS
{
    LIGHT,
    MEDIUM,
    HEAVY,
    OVER,
}