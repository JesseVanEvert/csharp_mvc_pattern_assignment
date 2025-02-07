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

        public void RemoveProduct(int id)
        {
            _model.RemoveProduct(id);
        }

        public void DisplayAllProducts()
        {
            _view.ShowProducts(
                _model.GetProducts()
            );
        }
    }
}
