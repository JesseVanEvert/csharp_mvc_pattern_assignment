using Model;
using View;

namespace Controller
{
    public class ProductController
    {
        private ProductView _view;
        private ProductModel _model;

        public ProductController(ProductModel productModel, ProductView productView)
        {
            _view = productView;
            _model = productModel;
        }

        public void AddProductToModel(Product product)
        {
            _model.AddProduct(product);
        }

        public void RemoveProduct(Guid id)
        {
            _model.RemoveProduct(id);
        }

        public void DisplayAllProducts()
        {
            _view.ShowProducts(
                _model.GetProducts()
            );
        }

        public void ProcessUserInput(int choice)
        {
            switch (choice)
            {
                case 1:
                    _view.ShowProducts(
                            _model.GetProducts()
                        );
                    _view.ShowMenu();
                    break;
                case 2:
                    AddProductToModel(
                            _view.GetProductDetails()
                    );
                    _view.ShowMenu();
                    break;
                case 3:
                    _model.RemoveProduct(
                            _view.GetProductIDForRemoval()
                    );
                    _view.ShowMenu();
                    break;
                default:
                    Console.WriteLine("1, 2 or 3");
                    break;
            }
        }
    }
}
