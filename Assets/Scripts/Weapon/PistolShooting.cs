using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolShooting : MonoBehaviour, IUsable 
{
    [SerializeField] private int damage;

    public void Use(){

        Shoot();

    }

    private void Shoot()
    {
        GameObject targetRaycaster = GetComponentInParent<PlayerRaycaster>().RaycastFromCamera("Target");
        
        if (targetRaycaster != null && targetRaycaster.GetComponent<Target>() != null)
        {
            targetRaycaster.GetComponent<Target>().TakeDamage(damage);
        }
    }
}
