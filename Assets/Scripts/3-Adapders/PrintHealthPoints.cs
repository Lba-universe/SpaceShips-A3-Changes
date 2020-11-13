using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * This component is adapter between TextMeshPro object and other object component 
 * getting the current Health Points of the player and send it to TextMesh to be presented in the UI
 */
public class PrintHealthPoints : MonoBehaviour
{
    private healthDecreaseOnTrigger hpComponent;
    private TextField HealthFiled;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        if (player != null)
        {
            hpComponent = player.GetComponent<healthDecreaseOnTrigger>();
            HealthFiled = gameObject.GetComponent<TextField>();
        }

        else
            this.enabled = false; // didnt find GameObject player
    }

    // Update is called once per frame
    void Update()
    {
        // player still alive
        if (player != null)
            HealthFiled.SetText("Hp: " + hpComponent.getHealthPoints());

        // player is destoryed, stop game
        else
        {
            HealthFiled.SetText("Hp: 0");
            Time.timeScale = 0;
        }
        
    }
}
