using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MariosPizzaShop.Models
{
    public class MockPizzaRepository : IPizzaRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pizza> Pizzas
        {
            get
            {
                return new List<Pizza>
                {
                    new Pizza
                    {
                        PizzaId = 1,
                        Name ="Pepperoni Pizza",
                        Price =15.95M,
                        ShortDescription ="Lorem Ipsum",
                        LongDescription ="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                        Category = _categoryRepository.Categories.ToList()[0],
                        ImageUrl ="https://imagesvc.timeincapp.com/v3/mm/image?url=http%3A%2F%2Fcdn-image.myrecipes.com%2Fsites%2Fdefault%2Ffiles%2Fstyles%2Fmedium_2x%2Fpublic%2Fimage%2Frecipes%2Fck%2Fgluten-free-cookbook%2Fpepperoni-pizza-ck-x.jpg%3Fitok%3DbQsFo3PZ&w=700&q=85",
                        InStock =true,
                        IsPizzaOfTheWeek =false,
                        ImageThumbnailUrl ="https://imagesvc.timeincapp.com/v3/mm/image?url=http%3A%2F%2Fcdn-image.myrecipes.com%2Fsites%2Fdefault%2Ffiles%2Fstyles%2Fmedium_2x%2Fpublic%2Fimage%2Frecipes%2Fck%2Fgluten-free-cookbook%2Fpepperoni-pizza-ck-x.jpg%3Fitok%3DbQsFo3PZ&w=700&q=85"
                    },
                    new Pizza
                    {
                        PizzaId = 2,
                        Name ="3 Meat Pizza",
                        Price =17.50M,
                        ShortDescription ="Lorem Ipsum",
                        LongDescription ="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                        Category = _categoryRepository.Categories.ToList()[0],
                        ImageUrl ="https://imagesvc.timeincapp.com/v3/mm/image?url=http%3A%2F%2Fcdn-image.myrecipes.com%2Fsites%2Fdefault%2Ffiles%2Fstyles%2Fmedium_2x%2Fpublic%2Fimage%2Frecipes%2Fay%2F11%2Fmeat-lovers-pizza-ay-x.jpg%3Fitok%3DxJor2Nvk&w=700&q=85",
                        InStock =true,
                        IsPizzaOfTheWeek =false,
                        ImageThumbnailUrl ="https://imagesvc.timeincapp.com/v3/mm/image?url=http%3A%2F%2Fcdn-image.myrecipes.com%2Fsites%2Fdefault%2Ffiles%2Fstyles%2Fmedium_2x%2Fpublic%2Fimage%2Frecipes%2Fay%2F11%2Fmeat-lovers-pizza-ay-x.jpg%3Fitok%3DxJor2Nvk&w=700&q=85"
                    },
                    new Pizza
                    {
                        PizzaId = 3,
                        Name ="Cheese Pizza",
                        Price =11.95M,
                        ShortDescription ="Lorem Ipsum",
                        LongDescription ="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                        Category = _categoryRepository.Categories.ToList()[1],
                        ImageUrl ="https://imagesvc.timeincapp.com/v3/mm/image?url=http%3A%2F%2Fcdn-image.myrecipes.com%2Fsites%2Fdefault%2Ffiles%2Fstyles%2Fmedium_2x%2Fpublic%2Fimage%2Frecipes%2Fultimate-cheese-pizza-x.jpg%3Fitok%3DMQM_e7aI&w=700&q=85",
                        InStock =true,
                        IsPizzaOfTheWeek =false,
                        ImageThumbnailUrl ="https://imagesvc.timeincapp.com/v3/mm/image?url=http%3A%2F%2Fcdn-image.myrecipes.com%2Fsites%2Fdefault%2Ffiles%2Fstyles%2Fmedium_2x%2Fpublic%2Fimage%2Frecipes%2Fultimate-cheese-pizza-x.jpg%3Fitok%3DMQM_e7aI&w=700&q=85"
                    },
                    new Pizza
                    {
                        PizzaId = 3,
                        Name ="Spinach and Shrimp Pizza",
                        Price =13.45M,
                        ShortDescription ="Lorem Ipsum",
                        LongDescription ="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                        Category = _categoryRepository.Categories.ToList()[2],
                        ImageUrl ="https://imagesvc.timeincapp.com/v3/mm/image?url=http%3A%2F%2Fcdn-image.myrecipes.com%2Fsites%2Fdefault%2Ffiles%2Fstyles%2Fmedium_2x%2Fpublic%2Fimage%2Frecipes%2Foh%2F12%2Fsalami-and-mushroom-pizza-oh-x.jpg%3Fitok%3DjMRSeHj8&w=700&q=85",
                        InStock =true,
                        IsPizzaOfTheWeek =false,
                        ImageThumbnailUrl ="https://imagesvc.timeincapp.com/v3/mm/image?url=http%3A%2F%2Fcdn-image.myrecipes.com%2Fsites%2Fdefault%2Ffiles%2Fstyles%2Fmedium_2x%2Fpublic%2Fimage%2Frecipes%2Foh%2F12%2Fsalami-and-mushroom-pizza-oh-x.jpg%3Fitok%3DjMRSeHj8&w=700&q=85"
                    },
                    
                };
            }
        }

        public IEnumerable<Pizza> PizzasOfTheWeek { get; }

        public Pizza GetPizzaId(int pizzaId)
        {
            throw new System.NotImplementedException();
        }
    }
}
