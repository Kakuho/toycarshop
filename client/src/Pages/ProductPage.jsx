// this probably needs to be thought out better tbh with you the product page controller changes the url to page=1, page=2 ect.
import "./ProductPage.css";

// components
import Sidebar from "./../Components/Sidebar/Sidebar.jsx";
import ProductGrid from "./../Components/PaginatedServer/ProductGrid.jsx";

export default function ProductPage(){
  return(
    <div className="product-page">
      <Sidebar />
      <ProductGrid />
    </div>
  )
}
