using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDamageInvinsability : MonoBehaviour
{
    [SerializeField]
    private float invincibilityDurtaion;

    private invinsabilityController _invinsabilityController;

    public void Awake()
    {
        _invinsabilityController = GetComponent<invinsabilityController>();
    }

    public void StartInvincibility()
    {
        _invinsabilityController.StartInvincibility(invincibilityDurtaion);
    }
}
