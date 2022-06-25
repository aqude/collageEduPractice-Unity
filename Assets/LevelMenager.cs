using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using CinemachinePixelPerfect = UnityEngine.U2D.CinemachinePixelPerfect;

public class LevelMenager : MonoBehaviour
{
    public static LevelMenager instance;
    public CinemachineVirtualCameraBase cam;
    public Transform respawnPoint;
    public GameObject player;

    private void Awake()
    {
        instance = this;
    }

    public void Respawn()
    {
        GameObject playr = Instantiate(player, respawnPoint.position, Quaternion.identity);
        cam.Follow = playr.transform;

    }
}
