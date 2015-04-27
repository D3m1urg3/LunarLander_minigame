using UnityEngine;
using System.Collections;

public struct man
{
	public static SpaceShipManager shipManager;
	public static UILeftManager uiLeftManager;
	public static UIRightManager uiRightManager;
	public static CameraManager cameraManager;
	public static CollisionManager colManager;
	public static OverlayTextManager textManager;

}

public class Manager : MonoBehaviour {

	public SpaceShipManager ship;
	public UILeftManager uiLeft;
	public UIRightManager uiRight;
	public CameraManager theCamera;
	public CollisionManager colliders;
	public OverlayTextManager messages;

	void Awake () {
	
		man.shipManager = ship;
		man.uiLeftManager = uiLeft;
		man.uiRightManager = uiRight;
		man.cameraManager = theCamera;
		man.colManager = colliders;
		man.textManager = messages;
	}
	

}
