using System;

namespace THOK.MCP.Service.DevelopOPC.Config
{
	/// <summary>
	/// Item ��ժҪ˵����
	/// </summary>
	public class ItemInfo
	{
		private string itemName;

		private string opcItemName;

		private int clientHandler;

		private bool isActive;

		public string ItemName
		{
			get
			{
				return itemName;
			}
		}

		public string OpcItemName
		{
			get
			{
				return opcItemName;
			}
		}

		public int ClientHandler
		{
			get
			{
				return clientHandler;
			}
		}

		public bool IsActive
		{
			get
			{
				return isActive;
			}
		}

		public ItemInfo(string itemName, string opcItemName, int clientHandler, string itemType)
		{
			this.itemName = itemName;
			this.opcItemName = opcItemName;
			this.clientHandler = clientHandler;
			this.isActive = itemType.ToUpper() == "READ";
		}
	}
}
