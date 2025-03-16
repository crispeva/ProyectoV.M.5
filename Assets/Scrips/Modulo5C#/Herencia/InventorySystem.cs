using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
namespace Inventario
{
    public class InventorySystem : MonoBehaviour
    {
        #region Properties

        #endregion

        #region Fields
        [Header("UI Reffs")]
        private UIControl _uicontrol;
        [Header("Items")]
        [SerializeField] private Weapon[] _weapons;
        [SerializeField] private Food[] _food;
        [SerializeField] private Others[] _others;

        [Header("Inventario")]
        [SerializeField] private List<Item> _items = new List<Item>();

        [Header("Item Selected")]
        [SerializeField] private  ItemButton _currentItemSelected;
        #endregion

        #region Unity Callbacks
        void Awake()
        {
            _uicontrol=GetComponent<UIControl>();
        }
        void Start()
        {
            //Inicializar los items en la lista
            InitializeItems();
            //Inicializar la UI con los items
            InitializeUi();
            //Asignar las funciones a los botones de la UI
            _uicontrol.UseButton.onClick.AddListener(() => _uicontrol.UseCurrentItem(_currentItemSelected));
            _uicontrol.SellButton.onClick.AddListener(() => _uicontrol.SellCurrentItem(_currentItemSelected));

        }

        // Update is called once per frame
        void Update()
        {

        }
        #endregion

        #region Public Methods
        public void AddItem(ItemButton itemToAdd)
        {
            //Instanciar un nuevo item en el inventario con el item seleccionado
            ItemButton newButtonItem = Instantiate(itemToAdd, _uicontrol.InventoryPanel);
            newButtonItem.Current_Item = itemToAdd.Current_Item;
            //Con el nuevo boton instanciado se le asigna la funcion de seleccionar item al clickear
            newButtonItem.OnClick += () => SelectItem(newButtonItem);
        }
        #endregion

        #region Private Methods
        private void InitializeUi()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                //Instaciamos un nuevo boton con el prefab de boton de item en el panel de inventario
                ItemButton newButton = Instantiate(_currentItemSelected, _currentItemSelected.transform.parent);
                newButton.Current_Item = _items[i];
                //Si se hace click en el boton se llama a la funcion AddItem
                newButton.OnClick += () => AddItem(newButton);
            }
            //Desactivar el prefab
            _currentItemSelected.gameObject.SetActive(false);
        }

        

        private void InitializeItems()
        {
            for (int i = 0; i < _weapons.Length; i++)
            {
                _items.Add(_weapons[i]);
            }

            for (int i = 0; i < _food.Length; i++)
            {
                _items.Add(_food[i]);
            }
            for (int i = 0; i < _others.Length; i++)
            {
                _items.Add(_others[i]);
            }
        }

        //Funciones de acciones de botones
        public void SelectItem(ItemButton current_Item)
        {
            _currentItemSelected = current_Item;
            //Logica control de botones de acciones
            if (_currentItemSelected.Current_Item is IUsable)
            {
                _uicontrol.UseButton.gameObject.SetActive(true);

            }
            else
            {
                _uicontrol.UseButton.gameObject.SetActive(false);
            }

            if (_currentItemSelected.Current_Item is ISeable)
            {
                _uicontrol.SellButton.gameObject.SetActive(true);

            }
            else
            {
                _uicontrol.SellButton.gameObject.SetActive(false);
            }
        }


        #endregion

    }
}