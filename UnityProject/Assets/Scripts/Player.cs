﻿using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("速度")] [Range(0f, 100f)]
    public float speed = 3.5f;
    [Header("跳躍")] [Range(100, 2000)]
    public int jump = 300;
    [Header("是否在地上"),Tooltip("用來判斷角色是否在地上。")]
    public bool isGround = false;
    [Header("角色名稱")]
    public string Name = "zero";
}