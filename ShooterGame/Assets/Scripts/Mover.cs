/**** 
 * Created by : Stu Dent
 * Date Created: Sept 20, 2021
 * 
 * Last Edited by: 
 * Last Updated: Sept 20, 2021
 * 
 * Description: Continuously moves gameobject
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    /**** Varibales****/
    public float MaxSpeed = 10f; 

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * MaxSpeed * Time.deltaTime; 
    }//end Update()
}
