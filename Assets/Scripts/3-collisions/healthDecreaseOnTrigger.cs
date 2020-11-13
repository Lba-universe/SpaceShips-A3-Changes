using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * This component set start hp to an GameObject,
 * on collision decrease until you get to 1,
 * if hp is 1 - enable DestoryScript
 * else hp > 1 - disable DestoryScript
 * 
 * The Destory Script must has a string named triggeringTag
 * Every object tagged with this tag will trigger the Decrease the health points of this object
 */
[RequireComponent(typeof(DestroyOnTrigger2D))]
public class healthDecreaseOnTrigger : MonoBehaviour
{
    [Tooltip("Limit Health Points to 10")]
    [SerializeField]
    [Range(1, 10)]
    private int HealthPoints = 3; // default to 3 health points
    private DestroyOnTrigger2D DestoryScript;


    public int getHealthPoints() {
        return HealthPoints;
    }

    // Start is called before the first frame update
    void Start()
    {
        DestoryScript = gameObject.GetComponent<DestroyOnTrigger2D>();
        DestoryScript.enabled = false; // Pause script
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == DestoryScript.getTag() && enabled)
            if (HealthPoints > 2)
                HealthPoints--;
            else
            {
                HealthPoints--; // last health point
                DestoryScript.enabled = true;
            }
    }
}
