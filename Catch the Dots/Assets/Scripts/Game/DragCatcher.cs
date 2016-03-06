 using UnityEngine;
 using System.Collections;
 
 [RequireComponent(typeof(MeshCollider))]
 
 public class DragCatcher : MonoBehaviour 
 {
 
	 private Vector3 screenPoint;
	 private Vector3 offset;
	 private Vector3 curPosition;

	 
	 void OnMouseDown()
	 {
	     screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
	 
	     offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	 
	 }
 
	 void OnMouseDrag()
	 {

			GameObject limiter = GameObject.Find ("Catcher Height Limiter");

	     if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y < limiter.transform.position.y && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > GameObject.Find("Floor").transform.position.y)
	     {
	         Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

	         curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
	         transform.position = curPosition;
	     }
		 else if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y >= limiter.transform.position.y)
	     {
				Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Camera.main.WorldToScreenPoint(limiter.transform.position).y, screenPoint.z);
				print(Camera.main.WorldToScreenPoint(limiter.transform.position).y);

	         curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
	         transform.position = curPosition;
	     }
	     else
	     {
	         Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Camera.main.WorldToScreenPoint(GameObject.Find("Bottom").transform.position).y, screenPoint.z);
	         print(Camera.main.WorldToScreenPoint(GameObject.Find("Bottom").transform.position).y);

	         curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
	         transform.position = curPosition;
	     }


	 }

  
 
 }