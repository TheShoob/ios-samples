using System;
using System.Collections.Generic;

namespace Example_CoreAnimation.Code.NavigationTable
{
	 
	/// <summary>
	/// A group that contains table items
	/// </summary>
	public class NavItemGroup
	{
		public string Name { get; set; }

		public string Footer { get; set; }

		public List<NavItem> Items
		{
			get { return  items; }
			set {  items = value; }
		}
		protected List<NavItem> items = new List<NavItem> ();

		public NavItemGroup ()
		{
		}

		public NavItemGroup (string name)
		{
			this.Name = name;
		}

	}
	 
}
