import {createElement} from "react";
import * as DOMPurify from "dompurify"; // needed to sanitise requested svg from the server - my own server
import PropTypes from "prop-types";
import "./ProductCard.css";
import {Normalise2} from "./../../util.js";

export default function ProductCard({product, pageNumber}){

  return(
    <div className="product-card">
      {createElement(
        'div',
        {
          className: "svg-container",
          dangerouslySetInnerHTML: {__html: Normalise2(product.image)} 
        },
      )}
      <div className="details" >
        <h2 className="name">{product.name}</h2>
        <h2 className="price">£{product.price}</h2>
      </div>
    </div>
  );
}

/*
ProductCard.propTypes = {
  product: PropTypes.objectOf(
    PropTypes.number, // id
    PropTypes.string, // name 
    PropTypes.string, // description
    PropTypes.string, // image
    PropTypes.number, // price
  ),
  pageNumber: PropTypes.number
}
*/
