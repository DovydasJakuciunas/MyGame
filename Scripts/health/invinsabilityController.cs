using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invinsabilityController : MonoBehaviour
{
    private healthController _healthController;

    private void Awake()
    {
        _healthController = GetComponent<healthController>();
    }

    public void StartInvincibility(float invincibilityDurtaion)
    {
        StartCoroutine(InvincibilityCoroutine(invincibilityDurtaion));
    }

    private IEnumerator InvincibilityCoroutine(float invincibilityDurtaion)
    {
        _healthController.IsInvincible = true;
        yield return new WaitForSeconds(invincibilityDurtaion);
        _healthController.IsInvincible = false;

    }
}
