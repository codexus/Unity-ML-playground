using MLAgents;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinAcademy : MonoBehaviour
{
    private void Start()
    {
        FishSpeed = 1f;
        FeedRadius = 1f;

        // Set up code to be called every time the fish_speed parameter changes 
        // during curriculum learning
        Academy.Instance.FloatProperties.RegisterCallback("fish_speed", f =>
        {
            FishSpeed = f;
        });

        // Set up code to be called every time the feed_radius parameter changes 
        // during curriculum learning
        Academy.Instance.FloatProperties.RegisterCallback("feed_radius", f =>
        {
            FeedRadius = f;
        });
    }


    /// <summary>
    /// Gets/sets the current fish speed
    /// </summary>
    public float FishSpeed { get; private set; }

    /// <summary>
    /// Gets/sets the current acceptable feed radius
    /// </summary>
    public float FeedRadius { get; private set; }

}
