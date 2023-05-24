import 'cart.dart';
import 'product.dart';

void main() {
  cart mycart = cart();
  product pro1 = product(ProductName: "Product1", ProductPrice: 100);
  product pro2 = product(ProductName: "Product2", ProductPrice: 100);
  product pro3 = product(ProductName: "Product3", ProductPrice: 100);
  mycart.addProduct(pro1);
  mycart.addProduct(pro2);
  mycart.addProduct(pro3);
  mycart.displayProducts();
  mycart.calcTotalPrice();
 }

