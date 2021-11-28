using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
 
	public static BuildManager instance;
	public GameObject standartTurretPrefab;
	private GameObject turretToBuild;

	void Awake()
	{
		if (instance != null)
		{
			Debug.LogError("More than one BuildManager in scene!");
			return;
		}
		instance = this;
	}
	
	void Start()
    {
		turretToBuild = standartTurretPrefab;
    }


	public GameObject GetTurretToBuild()
    {
		return turretToBuild;
    }
}
