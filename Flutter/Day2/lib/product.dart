class product {
  String? ProductName;
  double? ProductPrice;
  @override
  String toString() {
    return "Product Name: $ProductName, Product Price: $ProductPrice";
  }

  product({this.ProductName, this.ProductPrice});
}
