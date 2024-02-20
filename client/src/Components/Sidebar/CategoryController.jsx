import "./SideController.css";
import "./CategoryController.css";

export default function CategoryController(){
  return(
    <div id="category-controller" className="side-controller">
      <fieldset>
        <legend>Categories</legend>

        <div>
          <input type="checkbox" id="basic" name="basic"/>
          <label htmlFor="basic">Basic</label>
        </div>

        <div>
          <input type="checkbox" id="fruit" name="fruit"/>
          <label htmlFor="fruit">Fruit</label>
        </div>

        <div>
          <input type="checkbox" id="metal" name="metal"/>
          <label htmlFor="metal">Metal</label>
        </div>

        <div>
          <input type="checkbox" id="special" name="special"/>
          <label htmlFor="special">Special</label>
        </div>

      </fieldset>
    </div>
  )
}
