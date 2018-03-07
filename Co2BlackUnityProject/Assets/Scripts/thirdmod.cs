using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.iOS;
using UnityEngine.EventSystems;

public class thirdmod : MonoBehaviour {

	public GameObject fire;
	public GameObject coal;
	public GameObject gas;
	public GameObject clean;

	public GameObject woodEnergy;
	public GameObject coalEnergy;
	public GameObject gasEnergy;
	public GameObject allEnergy;

	public GameObject getClean;

	public GameObject laptopFirstStep;
	public GameObject laptop;
	public GameObject table;
	public GameObject screen1;
	public GameObject screen2;
	public GameObject screen3;

//	show coal model
	public void turnOnCoal() {
		coal.SetActive (true);
		coalEnergy.SetActive (true);
		woodEnergy.SetActive (false);
	}

//	show gas model
	public void turnOnGas(){
		gas.SetActive (true);
		gasEnergy.SetActive (true);
		coalEnergy.SetActive (false);
	}

//	show clean models
	public void turnOnAll(){
		clean.SetActive (true);
		allEnergy.SetActive (true);
		gasEnergy.SetActive (false);
	}

//	show "its simple" text
	public void turnOnCleanText() {
		allEnergy.SetActive (false);
		getClean.SetActive (true);
	}

//	hide all the models, show laptop first screen ui
	public void hideAllModels() {
		getClean.SetActive (false);
		fire.SetActive (false);
		coal.SetActive (false);
		gas.SetActive (false);
		clean.SetActive (false);
		laptop.SetActive (true);
		table.SetActive (true);
		screen1.SetActive (true);
		Debug.Log("boiiiii");
	}

	void laptopHit () {
		Debug.Log ("I was hit by a Ray!!!!!!!!!!");

		if (Input.touchCount > 0) {

			Touch touch = Input.GetTouch (0);
			if (touch.phase == TouchPhase.Began  && !EventSystem.current.IsPointerOverGameObject(0)) {

				Ray ray = Camera.main.ScreenPointToRay (touch.position);
				RaycastHit hit;

				if (Physics.Raycast (ray, out hit, 100)) {

					if (hit.transform.gameObject.tag == "screen1"){
						Debug.Log ("plz");

						screen1 = hit.transform.gameObject;
						screen1.SetActive (false);
						screen2.SetActive (true);

					}


					else if (hit.transform.gameObject.tag == "screen2"){
						Debug.Log ("popp");

						screen2 = hit.transform.gameObject;
						screen2.SetActive (false);
						screen3.SetActive (true);
					}

				}
			}
		}
//		if (screen1.activeInHierarchy) {
//			screen1.SetActive (false);
//			screen2.SetActive (true);
//		}
//		if (screen2.activeInHierarchy) {
//			screen2.SetActive (false);
//			screen3.SetActive (true);
//		}

	}


}
