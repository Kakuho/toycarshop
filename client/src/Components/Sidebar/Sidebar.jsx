import SortController from "./SortController.jsx";
import PriceController from "./PriceController.jsx";
import CategoryController from "./CategoryController.jsx";
import "./Sidebar.css";

export default function Sidebar(){
  return(
    <div id="sidebar">
      <SortController />
      <PriceController />
      <CategoryController />
    </div>
  )
}
