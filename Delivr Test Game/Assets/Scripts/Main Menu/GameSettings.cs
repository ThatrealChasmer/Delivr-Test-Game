using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Settings", menuName ="Game Settings")]
public class GameSettings : ScriptableObject
{
    [Header("Amount of lives")]
    public int lives;

    [Header("Max speed of our ship")]
    public float maxSpeed;

    [Header("Max acceleration of our ship determining how fast we reach max speed")]
    public float maxAcc;

    [Header("Max turning speed")]
    public float maxTurnSpeed;

    [Header("Turning acceleration determining how fast we get to max turning speed")]
    public float turnAcc;

    [Header("Speed of the bullets our ship shoots")]
    public float bulletSpeed;

    [Header("Delay between shots")]
    public float shotDelay;

    [Header("Delay before game starts")]
    public float delay;

    [Header("Hit points of big asteroid")]
    public int bigHP;

    [Header("Hit points of medium asteroid")]
    public int mediumHP;

    [Header("Hit points of small asteroid")]
    public int smallHP;

    [Header("Points for destroying big asteroid")]
    public int bigScore;

    [Header("Points for destroying medium asteroid")]
    public int mediumScore;

    [Header("Points for destroying small asteroid")]
    public int smallScore;

    [Header("Amount of smaller asteroids spawn after destroying bigger one")]
    public int toSpawn;

    [Header("Max amount of asteroids in game at the same time")]
    public int maxAsteroids;

    [Header("Time between asteroid spawn")]
    public float asteroidDelay;

    [Header("Distance from player in which asteroids can spawn")]
    public float spawnDistance;
}
