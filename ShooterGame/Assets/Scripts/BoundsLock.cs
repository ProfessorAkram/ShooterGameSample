/**** 
 * Created by : Stu Dent
 * Date Created: Sept 15, 2021
 * 
 * Last Edited by: 
 * Last Updated: Sept 15, 2021
 * 
 * Description: Boundary of the game 
 ****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsLock : MonoBehaviour
{
    public Rect leveBounds; // the x,y and w,h of the bounding rectangle

    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, leveBounds.xMin, leveBounds.xMax), transform.position.y, Mathf.Clamp(transform.position.z, leveBounds.yMin, leveBounds.yMax));

    }//end LateUpdate()

    private void OnDrawGizmosSelected()
    {
        const int cubeDepth = 1;
        Vector3 boundsCenter = new Vector3(leveBounds.xMin + leveBounds.width * 0.5f, 0, leveBounds.yMin + leveBounds.height * 0.5f);
        Vector3 boundsHeight = new Vector3(leveBounds.width, cubeDepth, leveBounds.height);


        Gizmos.DrawWireCube(boundsCenter, boundsHeight); 
        

    }//end OnDrawGizmosSelected()



}
