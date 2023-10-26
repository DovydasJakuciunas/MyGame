using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBarUI : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Image healthBarForegroundImage;

    public void UpdateHealthBar(healthController _healthController)
    {
        healthBarForegroundImage.fillAmount = _healthController.RemainingHealthPercentage;
    }
}
