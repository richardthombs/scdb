using System.Xml.Serialization;

namespace Loader.SCDb.Xml.Shops
{
	// This is a node in the the RetailProductPrices XML file
	public class Node
	{
		[XmlAttribute]
		public string ID;

		[XmlAttribute]
		public int Index;

		[XmlAttribute]
		public string Name;

		[XmlAttribute]
		public double BasePrice;

		[XmlAttribute]
		public double MaxDiscountPercentage;

		[XmlAttribute]
		public double MaxPremiumPercentage;

		[XmlAttribute]
		public double ManHours;

		[XmlAttribute]
		public double OutputSPUPerProduction;

		[XmlAttribute]
		public string Directory;

		[XmlAttribute]
		public string Filename;

		public Node[] RetailProducts;
	}

	public class ShopLayoutNode
	{
		[XmlAttribute]

		public string ID;

		[XmlAttribute]
		public int Index;

		[XmlAttribute]
		public string Name;

		[XmlAttribute]
		public string Renamable;

		[XmlAttribute]
		public string Deletable;

		[XmlAttribute]
		public string ReadOnly;

		[XmlAttribute]
		public string Static;

		[XmlAttribute]
		public string AutoGenerated;

		[XmlAttribute]
		public string SiblingLinkage;

		[XmlAttribute]
		public double ProfitMargin;

		[XmlAttribute]
		public string Global;

		[XmlAttribute]
		public string AcceptsStolenGoods;

		public ShopLayoutNode[] ShopLayoutNodes;

		public ShopInventoryNode[] ShopInventoryNodes;
	}

	public class ShopInventoryNode
	{
		[XmlAttribute]
		public string ID;

		[XmlAttribute]
		public int Index;

		[XmlAttribute]
		public string Name;

		[XmlAttribute]
		public string Renamable;

		[XmlAttribute]
		public string Deletable;

		[XmlAttribute]
		public string ReadOnly;

		[XmlAttribute]
		public string Static;

		[XmlAttribute]
		public string AutoGenerated;

		[XmlAttribute]
		public string SiblingLinkage;

		[XmlAttribute]
		public string InventoryID;

		[XmlAttribute]
		public string TransactionType;

		[XmlAttribute]
		public double BasePriceOffsetPercentage;
		[XmlAttribute]
		public double MaxDiscountPercentage;

		[XmlAttribute]
		public double MaxPremiumPercentage;

		[XmlAttribute]
		public double Inventory;

		[XmlAttribute]
		public double OptimalInventoryLevel;

		[XmlAttribute]
		public string AutoRestock;

		[XmlAttribute]
		public string AutoConsume;

		[XmlAttribute]
		public double MaxInventory;

		[XmlAttribute]
		public double RefreshRatePercentagePerMinute;

		public TransactionType[] TransactionTypes;
	}

	public class TransactionType
	{
		[XmlText]
		public string Data;
	}
}
