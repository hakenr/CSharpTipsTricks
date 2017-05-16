using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havit.Demos.CSharpTipsTricks
{
    public class Initializers
    {
		public static void DoSomething() // often a unit-test
		{
			var order = new Order()
			{
				Id = 10,
				Customer = "HAVIT, s.r.o.",
				OrderDate = DateTime.Now,
				Items =	new List<OrderItem>			   // collection instance has to be created first
				{
					new OrderItem()
					{
						Quantity = 10,
						ProductNumber = "DHK2342"
					},
					new OrderItem()
					{
						Quantity = 3.4M,
						ProductNumber = "2839832D"
					}
				},
				Discounts =								// collection instance exists (getter-only prop)
				{										// collection initializer => .Add(item) calls
					new Discount()
					{
						Description = "DealerA",
						Value = 1
					},
					new Discount						// constructor parenthesis might be omitted
					{
						Description = "Individual",
						Value = 100,					// trailing comma is allowed (ignored)
					}
				}
			};
		}
    }

	public class Order
	{
		public int Id { get; set; }
		public string Customer { get; set; }
		public DateTime OrderDate { get; set; }
		public IList<OrderItem> Items { get; set; }
		public IList<Discount> Discounts { get; } = new List<Discount>();

	}

	public class Discount
	{
		public string Description { get; set; }
		public decimal Value { get; set; }
	}

	public class OrderItem
	{
		public decimal Quantity { get; set; }
		public string ProductNumber { get; set; }
	}
}
