import "./PriceController.css";
import "./SideController.css";

export default function PriceController(){
  return(
    <div id="price-controller" className="side-controller">
      <label> Price - Range </label>
      <div className="settings" >
        <p> £ </p>

        <input type="text" id="price-low" name="price-low"
          placeholder="0" size="8">
        </input>


        <p> - </p>

        <input type="text" id="price-high" name="price-high"
          placeholder="1000" size="8">
        </input>
      </div>
    </div>
  )
}
