using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{
public GameObject spherego,cubego;
VirtualButtonBehaviour vrb;

void start(){
vrb = GetComponentInChildren<VirtualButtonBheaviour>();
vrb.RegisterEventHandler(this);
cubego.SetActive(true);
spherego.SetActive(false);
}


void update(){
}

public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
{
  cubego.SetActive(false);
  spherego.SetActive(true);
}


public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
{
  
  cubego.SetActive(true);
  spherego.SetActive(false);
}


}
