import "./SortController.css";
import "./Sidebar.css";

export default function SortController(){
  return(
    <div id="sort-controller" className="side-controller">
      <fieldset className="sort-fieldset">
      <legend> Sort By </legend>
        <div className="radio-field">
          <input type="radio" id="sort-price-ascending" 
              className="sort-option-radio" name="sort" value="price-ascending" />
          <label htmlFor="sort-price-ascending">Highest Price</label>
        </div>

        <div className="radio-field">
          <input type="radio" id="sort-price-descending" 
              className="sort-option-radio" name="sort" value="price-descending" />
          <label htmlFor="sort-price-descending">Lowest Price</label>
        </div>

        <div className="radio-field">
          <input type="radio" id="sort-name-ascending" 
              className="sort-option-radio" name="sort" value="name-ascending" />
          <label htmlFor="sort-name-ascending">Alphabet (A-Z)</label>
        </div>

        <div className="radio-field">
          <input type="radio" id="sort-name-descending" 
              className="sort-option-radio" name="sort" value="name-descending" />
          <label htmlFor="sort-name-descending">Aplhabet (Z-A)</label>
        </div>
      </fieldset>
    </div>
  )
}
