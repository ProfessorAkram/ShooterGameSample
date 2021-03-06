/**** 
 * Created by : Stu Dent
 * Date Created: Sept 20, 2021
 * 
 * Last Edited by: 
 * Last Updated: Sept 20, 2021
 * 
 * Description: Deal damage to any coliding object with health component. 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProxyDamage : MonoBehaviour
{
    /****VARAIBLES****/
    public float DamageRate = 10f; // damage per second

    private void OnTriggerStay(Collider other)
    {
        Health H = other.gameObject.GetComponent<Health>(); 

        if(H == null) { return; }

        H.HealthPoints -= DamageRate * Time.deltaTime; 
    }


}
