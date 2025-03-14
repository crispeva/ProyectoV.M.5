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
        //TODO:Refactor move this to UIController
        [Header("UI Reffs")]
        [SerializeField] private ItemButton _prefabsButton;
        [SerializeField] private Transform _inventoryPanel;
        [SerializeField] private Button _useButton;
        [SerializeField] private Button _sellButton;

        [Header("Items")]
        [SerializeField] private Weapon[] _weapons;
        [SerializeField] private Food[] _food;

        [Header("Inventario")]
        [SerializeField] private List<Item> _items = new List<Item>();

        [Header("Item Selected")]
        [SerializeField] private  ItemButton _currentItemSelected;
        #endregion

        #region Unity Callbacks
        void Start()
        {
            //Inicializar los items en la lista
            InitializeItems();
            //Inicializar la UI con los items
            InitializeUi();

            //TODO:Refactor
            _useButton.onClick.AddListener(UseCurrentItem);
            _sellButton.onClick.AddListener(SellCurrentItem);
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
            ItemButton newButtonItem = Instantiate(itemToAdd, _inventoryPanel);
            newButtonItem.Current_Item = itemToAdd.Current_Item;
            //Con el nuevo boton instanciado se le asigna la funcion de seleccionar item al clickear
            newButtonItem.OnClick += () => SelectItem(newButtonItem);
        }
        //Funcion dependiedo del item seleccionado se activan o desactivan los botones de acciones
        public void SelectItem(ItemButton current_Item)
        {
            _currentItemSelected = current_Item;
            //Logica control de botones de acciones
            if(_currentItemSelected.Current_Item is IUsable)
            {
                _useButton.gameObject.SetActive(true);
                
            }
            else
            {
                _useButton.gameObject.SetActive(false);
            }

            if (_currentItemSelected.Current_Item is ISeable)
            {
                _sellButton.gameObject.SetActive(true);
                
            }
            else
            {
                _sellButton.gameObject.SetActive(false);
            }
        }

        #endregion

        #region Private Methods
        private void InitializeUi()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                //Instaciamos un nuevo boton con el prefab de boton de item en el panel de inventario
                ItemButton newButton = Instantiate(_prefabsButton, _prefabsButton.transform.parent);
                newButton.Current_Item = _items[i];
                //Si se hace click en el boton se llama a la funcion AddItem
                newButton.OnClick += () => AddItem(newButton);
            }
            //Desactivar el prefab
            _prefabsButton.gameObject.SetActive(false);
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
        }

        //Funciones de acciones de botones

        //Refactor
        private void SellCurrentItem()
        {
            //Se llama a la funcion de vender del item seleccionado
            (_currentItemSelected.Current_Item as ISeable).Sell();
            ConsumeItem();
        }
        //Refactor
        private void UseCurrentItem()
        {
            (_currentItemSelected.Current_Item as IUsable).Use();
            if(_currentItemSelected.Current_Item is IConsumable)
            {
                ConsumeItem();
            }

        }
        private void ConsumeItem()
        {
            Destroy(_currentItemSelected.gameObject);
            _currentItemSelected = null;
        }
        #endregion

    }
}