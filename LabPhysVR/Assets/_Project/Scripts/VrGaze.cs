using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VrGaze : MonoBehaviour {

	public Image imgGaze;
	public float totalTime = 2;
	bool gvrStatus;
	float gvrTimer;
	public int distanceOfRay = 25;
	private RaycastHit _hit;

	public Rigidbody Car;

	// Use this for initialization
	void Start () {

		 GVROff();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gvrStatus){
			gvrTimer += Time.deltaTime;
			imgGaze.fillAmount = gvrTimer / totalTime;
		}

			

		Ray ray = Camera.main.ViewportPointToRay (new Vector3(0.5f, 0.5f, 0f));

		// PARA DAR TP
		if(Physics.Raycast(ray, out _hit, distanceOfRay)){
			Debug.Log("não entrou na chamada do tp");

			if(imgGaze.fillAmount==1 && _hit.transform.CompareTag("Teleport")){
				Debug.Log("CHAMOU O TELEPORT??");
				_hit.transform.gameObject.GetComponent<Teleport>().TeleportPlayer();
						
			}
		}
		
	}

	public void  GVROn (){
		gvrStatus = true;
				Debug.Log("GVR VERDADE");
	}

	public void GVROff (){
		gvrStatus = false;
		gvrTimer = 0;
		imgGaze.fillAmount = 0;
				Debug.Log("GVR FALSO??");

	}
}	
