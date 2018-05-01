using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace MariosPizzaShop.Models
{
	public static class DbInitializer
	{
		public static void Seed(AppDbContext context)
		{
		    if (!context.Categories.Any())
		    {
                DataTable dt = new DataTable("Categories");
		        dt.Columns["CategoryId"].AutoIncrement = true;
		        dt.Columns["CategoryId"].AutoIncrementStep = -1;
		        dt.Columns["CategoryId"].AutoIncrementSeed = -1;

		        dt.Columns["CategoryId"].AutoIncrementStep = 1;
		        dt.Columns["CategoryId"].AutoIncrementSeed = 1;
                context.Categories.AddRange(Categories.Select(c => c.Value));
		    }

            if (!context.Pizzas.Any())
			{
			    DataTable dt = new DataTable("Pizzas");
			    dt.Columns["PizzaId"].AutoIncrement = true;
			    dt.Columns["PizzaId"].AutoIncrementStep = -1;
			    dt.Columns["PizzaId"].AutoIncrementSeed = -1;

			    dt.Columns["PizzaId"].AutoIncrementStep = 1;
			    dt.Columns["PizzaId"].AutoIncrementSeed = 1;
                context.AddRange
				(
					new Pizza
					{
						Name = "Pepperoni Pizza", Price = 12.95M, ShortDescription = "The Original", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Carnivore Pizzas"], ImageUrl = "https://imagesvc.timeincapp.com/v3/mm/image?url=http%3A%2F%2Fcdn-image.myrecipes.com%2Fsites%2Fdefault%2Ffiles%2Fstyles%2Fmedium_2x%2Fpublic%2Fimage%2Frecipes%2Fck%2Fgluten-free-cookbook%2Fpepperoni-pizza-ck-x.jpg%3Fitok%3DbQsFo3PZ&w=700&q=85", InStock = true, IsPizzaOfTheWeek = true, ImageThumbnailUrl = "https://imagesvc.timeincapp.com/v3/mm/image?url=http%3A%2F%2Fcdn-image.myrecipes.com%2Fsites%2Fdefault%2Ffiles%2Fstyles%2Fmedium_2x%2Fpublic%2Fimage%2Frecipes%2Fck%2Fgluten-free-cookbook%2Fpepperoni-pizza-ck-x.jpg%3Fitok%3DbQsFo3PZ&w=700&q=85", AllergyInformation = ""
					},
					new Pizza
					{
                        Name = "Three Meat Pizza", Price = 18.95M, ShortDescription = "Mo Meat Mo Problems", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Carnivore Pizzas"], ImageUrl = "http://static.wixstatic.com/media/bb97fc_2900f16ff52649a3a1a52988016ddd9e.jpg/v1/fill/w_420,h_315,al_c,lg_1,q_80/bb97fc_2900f16ff52649a3a1a52988016ddd9e.webp", InStock = true, IsPizzaOfTheWeek = false, ImageThumbnailUrl = "http://static.wixstatic.com/media/bb97fc_2900f16ff52649a3a1a52988016ddd9e.jpg/v1/fill/w_420,h_315,al_c,lg_1,q_80/bb97fc_2900f16ff52649a3a1a52988016ddd9e.webp", AllergyInformation = ""
					},
					new Pizza
					{
					    Name = "Cowboy Pizza", Price = 18.95M, ShortDescription = "Get your western on", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Carnivore Pizzas"], ImageUrl = "https://imagesvc.timeincapp.com/v3/mm/image?url=http%3A%2F%2Fcdn-image.myrecipes.com%2Fsites%2Fdefault%2Ffiles%2Fstyles%2Fmedium_2x%2Fpublic%2Fimage%2Frecipes%2Foh%2F12%2Fsalami-and-mushroom-pizza-oh-x.jpg%3Fitok%3DjMRSeHj8&w=700&q=85", InStock = true, IsPizzaOfTheWeek = false, ImageThumbnailUrl = "https://imagesvc.timeincapp.com/v3/mm/image?url=http%3A%2F%2Fcdn-image.myrecipes.com%2Fsites%2Fdefault%2Ffiles%2Fstyles%2Fmedium_2x%2Fpublic%2Fimage%2Frecipes%2Foh%2F12%2Fsalami-and-mushroom-pizza-oh-x.jpg%3Fitok%3DjMRSeHj8&w=700&q=85", AllergyInformation = ""
					},
					new Pizza
					{
					    Name = "Vegetarian Pizza", Price = 15.95M, ShortDescription = "Healthy Veggies", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Herbivore Pizzas"], ImageUrl = "http://cdn-image.myrecipes.com/sites/default/files/styles/medium_2x/public/image/recipes/ck/veggie-pizza-ck-1011287-x.jpg?itok=BTWz3vyH", InStock = true, IsPizzaOfTheWeek = false, ImageThumbnailUrl = "http://cdn-image.myrecipes.com/sites/default/files/styles/medium_2x/public/image/recipes/ck/veggie-pizza-ck-1011287-x.jpg?itok=BTWz3vyH", AllergyInformation = ""
					},
					new Pizza
					{
					    Name = "Cheese Pizza", Price = 13.95M, ShortDescription = "For when you need that queso", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Herbivore Pizzas"], ImageUrl = "http://cdn-image.myrecipes.com/sites/default/files/styles/medium_2x/public/image/recipes/oh/12/mozzarella-and-basil-pizza-oh-x.jpg?itok=kes_i5k4", InStock = true, IsPizzaOfTheWeek = false, ImageThumbnailUrl = "http://cdn-image.myrecipes.com/sites/default/files/styles/medium_2x/public/image/recipes/oh/12/mozzarella-and-basil-pizza-oh-x.jpg?itok=kes_i5k4", AllergyInformation = ""
					},
					new Pizza
					{
					    Name = "Shrimp Pizza", Price = 17.95M, ShortDescription = "So Fancy!", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Herbivore Pizzas"], ImageUrl = "https://img.sunset02.com/sites/default/files/styles/medium_2x/public/image/recipes/su/14/09/capricciosa-pizza-su-x.jpg?itok=F1XDKJo7", InStock = true, IsPizzaOfTheWeek = false, ImageThumbnailUrl = "https://img.sunset02.com/sites/default/files/styles/medium_2x/public/image/recipes/su/14/09/capricciosa-pizza-su-x.jpg?itok=F1XDKJo7", AllergyInformation = ""
					},
					new Pizza
					{
					    Name = "Cheese Overload Pizza", Price = 15.95M, ShortDescription = "NEED MORE QUESO", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Herbivore Pizzas"], ImageUrl = "https://img.sunset02.com/sites/default/files/styles/medium_2x/public/image/recipes/su/10/02/pizzetta-margherita-pizza-su-x.jpg?itok=0oZzpSXx", InStock = false, IsPizzaOfTheWeek = false, ImageThumbnailUrl = "https://img.sunset02.com/sites/default/files/styles/medium_2x/public/image/recipes/su/10/02/pizzetta-margherita-pizza-su-x.jpg?itok=0oZzpSXx", AllergyInformation = ""
					},
					new Pizza
					{
					    Name = "Hawaiian Pizza", Price = 12.95M, ShortDescription = "Free Complementary Lay with every purchase", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Specialty Pizzas"], ImageUrl = "https://img.sunset02.com/sites/default/files/styles/medium_2x/public/image/recipes/su/14/09/capricciosa-pizza-su-x.jpg?itok=F1XDKJo7", InStock = true, IsPizzaOfTheWeek = true, ImageThumbnailUrl = "https://img.sunset02.com/sites/default/files/styles/medium_2x/public/image/recipes/su/14/09/capricciosa-pizza-su-x.jpg?itok=F1XDKJo7", AllergyInformation = ""
					},
					new Pizza
					{
					    Name = "Artichoke and Liver Pizza", Price = 15.95M, ShortDescription = "Gross pizza", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Specialty Pizzas"], ImageUrl = "http://cdn-image.myrecipes.com/sites/default/files/styles/medium_2x/public/image/recipes/oh/13/oh-double-mushroom-pizza-x.jpg?itok=BpuTtdvm", InStock = true, IsPizzaOfTheWeek = true, ImageThumbnailUrl = "http://cdn-image.myrecipes.com/sites/default/files/styles/medium_2x/public/image/recipes/oh/13/oh-double-mushroom-pizza-x.jpg?itok=BpuTtdvm", AllergyInformation = ""
					},
					new Pizza
					{
					    Name = "Cardboard Pizza", Price = 15.95M, ShortDescription = "Budget Pizza", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Specialty Pizzas"], ImageUrl = "https://www.thegrocer.co.uk/Pictures/420xAny/7/4/9/76749_Chilled-Pizza-The-Co-operative-Kashmiri-Pizza.jpg", InStock = true, IsPizzaOfTheWeek = false, ImageThumbnailUrl = "https://www.thegrocer.co.uk/Pictures/420xAny/7/4/9/76749_Chilled-Pizza-The-Co-operative-Kashmiri-Pizza.jpg", AllergyInformation = ""
					},
					new Pizza
					{
					    Name = "Fancy Pizza", Price = 18.95M, ShortDescription = "When you gots to impress your date DISCLAIMER: It's Digorno", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Specialty Pizzas"], ImageUrl = "https://imagesvc.timeincapp.com/v3/mm/image?url=http%3A%2F%2Fcdn-image.myrecipes.com%2Fsites%2Fdefault%2Ffiles%2Fstyles%2Fmedium_2x%2Fpublic%2Fimage%2Frecipes%2Fck%2F14%2F09%2Fcaprese-pizza-ck-x.jpg%3Fitok%3DcRuKRtpA&w=700&q=85", InStock = false, IsPizzaOfTheWeek = false, ImageThumbnailUrl = "https://imagesvc.timeincapp.com/v3/mm/image?url=http%3A%2F%2Fcdn-image.myrecipes.com%2Fsites%2Fdefault%2Ffiles%2Fstyles%2Fmedium_2x%2Fpublic%2Fimage%2Frecipes%2Fck%2F14%2F09%2Fcaprese-pizza-ck-x.jpg%3Fitok%3DcRuKRtpA&w=700&q=85", AllergyInformation = ""
					}
				);
			}

            
			context.SaveChanges();
		}

		private static Dictionary<string, Category> categories;
		public static Dictionary<string, Category> Categories
		{
			get
			{
				if (categories == null)
				{
					var genresList = new Category[]
					{
						new Category { CategoryName = "Carnivore Pizzas" },
						new Category { CategoryName = "Herbivore Pizzas" },
						new Category { CategoryName = "Specialty Pizzas" }
					};

					categories = new Dictionary<string, Category>();

					foreach (Category genre in genresList)
					{
						categories.Add(genre.CategoryName, genre);
					}
				}

				return categories;
			}
		}
	}
}
