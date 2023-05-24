import 'product.dart';
class cart {
  List<product> products;

  cart() : products = [];

  void addProduct(product product) {
    products.add(product);
  }

  void displayProducts() {
    if (products.isEmpty) {
      print("No products in the cart.");
    } else {
      for (var product in products) {
        print(
            "Product Name: ${product.ProductName}, Product Price: ${product.ProductPrice}");
      }
    }
  }

  void calcTotalPrice() {
    double totalPrice = 0.0;
    for (var product in products) {
      totalPrice += product.ProductPrice!;
    }
    print("Total Price = $totalPrice");
  }
}
