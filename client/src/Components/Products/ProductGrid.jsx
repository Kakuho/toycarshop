import {useState} from "react";
import ProductCard from "./ProductCard.jsx";
import "./ProductGrid.css";

export default function ProductGrid(){
  // ProductGrid should fetch the products from the page.
  // actually I wonder if you can do pagination here?
  const [page, setPage] = useState(0);

  return(
    <div className="product-grid">
      <ProductCard id={1} />
      <ProductCard id={2} />
      <ProductCard id={3} />
      <ProductCard id={4} />
      <ProductCard id={5} />
      <ProductCard id={6} />
      <ProductCard id={7} />
      <ProductCard id={8} />
    </div>
  )
}
