public abstract class Item
{
	protected string itemName;
	protected int itemCost;
	protected bool stackable;
	protected int amount;

	public ItemType type;
}

public enum ItemType
{
	Consumable, Equipment, Clothing
}

//Consumivel
public class Consumable : Item
{
	public Consumable(string name, int cost)
	{
		itemName = name;
		itemCost = cost;
		stackable = true;

		type = ItemType.Consumable;
	}
}

//Equipamento
public class Equipment : Item
{
	public Equipment(string name, int cost)
	{
		itemName = name;
		itemCost = cost;
		stackable = false;

		type = ItemType.Equipment;
	}
}

//Vestuario
public class Clothing : Item
{
	public Clothing(string name, int cost)
	{
		itemName = name;
		itemCost = cost;
		stackable = false;

		type = ItemType.Clothing;
	}
}