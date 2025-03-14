using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Create Item")]
public class ScriptableItem : ScriptableObject
{
    public string itemName;  // Nombre del item
    public Sprite itemIcon;  // Icono del item (para mostrar en UI)
    public int itemID;       // ID �nico para el item
    public string description;  // Descripci�n del item
    public bool isStackable;  // Si el item es apilable (ej. pociones, recursos)
}
