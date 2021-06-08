using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkyBoxChanger : MonoBehaviour
{
    public Material[] Skyboxes;
    private Dropdown _dropdown;
    private float rotateSpeed = 8.0f;
    public void Awake()
    {
        _dropdown = GetComponent<Dropdown>();
        //var options = Skyboxes.Select(skybox => skybox.name).ToList();
        //_dropdown.AddOptions(options);
    }
    private void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotateSpeed);
    }
    public void ChangeSkybox()
    {
        RenderSettings.skybox = Skyboxes[_dropdown.value];
    }
}
