using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] protected private GameObject targetSign;
    protected private void Start()
    {
        targetSign.SetActive(false);
    }
    protected private void SetTargetSign()
    {
        bool sign;
        if (targetSign.activeSelf)
        {
            sign = false;
        }
        else
        {
            sign = true;
        }
        targetSign.SetActive(sign);
    }
}