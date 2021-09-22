/**** 
 * Created by : Stu Dent
 * Date Created: Sept 20, 2021
 * 
 * Last Edited by: 
 * Last Updated: Sept 20, 2021
 * 
 * Description: Gameobjects Health
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    /**** Variables****/
    public bool DestroyOnDeath = true;
    public GameObject DeathParticlesPrefab = null; 
    [SerializeField] private float _HealthPoints = 100f; 

    public float HealthPoints { 
        get { return _HealthPoints; }
        set { _HealthPoints = value;
            if (HealthPoints <= 0)
            {
                SendMessage("Die", SendMessageOptions.DontRequireReceiver);

                if (DeathParticlesPrefab != null)
                {
                    Instantiate(DeathParticlesPrefab, transform.position, transform.rotation);
                }

                if (DestroyOnDeath)
                {
                    Destroy(gameObject);
                }
            }
        }//end Set
    }//end public HealthPoints


    // Update is called once per frame
    void Update()
    {
        //Debug Health test
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HealthPoints = 0; 
        }//end debug
    }
}
