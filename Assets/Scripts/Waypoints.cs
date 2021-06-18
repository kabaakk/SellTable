using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public static Transform[] points;
    public GameObject waypoints, episode1, episode2, episode3, episode4, episode5, episode6, 
        episode7, episode8, episode9, episode10, yourGoal;
    public static Waypoints instance;

    private void Awake()
    {
        instance = this;
        points = new Transform[transform.childCount];
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }
}
