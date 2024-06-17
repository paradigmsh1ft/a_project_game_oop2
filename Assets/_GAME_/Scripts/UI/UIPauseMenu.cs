using System.Collections;
    using System.Collections.Generic;
    using UnityEditor.ShaderGraph;
    using UnityEngine;
    using UnityEngine.UI;

    public class UIPauseMenu : MonoBehaviour
    {
        [SerializeField] Canvas menu;

        private PlayerControls playerControls;
    
        private void Awake()
        {
            playerControls = new PlayerControls();    
            menu = GetComponent<Canvas>();
         }

        private void OnEnable()
        {
            playerControls.Enable();
       
         }

        private void Start()
        {
            playerControls.UI.OpenMenu.performed += _ => OpenMenu();
            playerControls.UI.CloseMenu.performed += _ => CloseMenu();
        }

        private void OpenMenu()
        {
            menu.gameObject.SetActive(true);
            
        }

        private void CloseMenu()
        { 
         menu.gameObject.SetActive(false);
        }
    }
