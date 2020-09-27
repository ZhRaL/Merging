using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private int gold;
    private int diamants;
    private int level;
    // Bastis Text ist hier, der ist aber unwichtig im Vergleich zu Schatzis :D
    private int getGold() { return gold; }

    private int getDiamants() { return diamants; }

    private int getLevel() { return level; }

    private void raiseLevel() { level++; }

    private void setLevel(int i) { level = i;}

    private void setGold(int i) { gold = i; }
    private void setDiamants(int i) { diamants = i; }

    //Hi Babe :)
}
