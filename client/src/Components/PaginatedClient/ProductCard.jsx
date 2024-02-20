import {useEffect, useState, createElement} from "react";
import * as DOMPurify from "dompurify"; // needed to sanitise requested svg from the server - my own server
import {Normalise} from "./../../util.js";
import "./ProductCard.css";

export default function ProductCard({id}){
  const [product, setProduct] = useState({});

  useEffect( () => {
    async function FetchSetData(){
      await fetch(`http://localhost:5116/api/Product/${id}`)
        .then( (response) => {
          return response.json()
        })
        .then( car => {
          console.log(car);
          let productAfter = structuredClone(product);
          productAfter["name"] = car.name;
          productAfter["description"] = car.description;
          productAfter["price"] = car.price;
          // SANITIZE THE SVG FILE
          console.log(DOMPurify);
          /*
          productAfter["svgFile"] = DOMPurify.sanitize(Normalise(car.image), {
                USE_PROFILES: {
                  svg: true
                } 
              });
          WATTAFACK!!*/ 
          productAfter["svgFile"] = Normalise(car.image),
          setProduct(productAfter);
        });
    }
    FetchSetData();
  }, []);

  // why tf does wrapping my svg in object works, but not by itself?????????????????
  // <svg>
  //  <svg> </svg>
  // </svg> 
  // is syntax error?
  // while
  // <object>
  //  <svg> </svg>
  // </object>
  // is not?
  // wattafack browser


  return(
    <div className="product-card">
      {createElement(
        'div',
        {
          className: "svg-container",
          /*
          height: "50px",
          width: "50px",
          wattafack this works when you comment it out???*/
          dangerouslySetInnerHTML: {__html: product.svgFile} 
        },
      )}
      <div className="details" >
        <h2 className="name">{product.name}</h2>
        {/*<p>{product.description}</p> - i want view model to see this only*/}
        <h2 className="price">£{product.price}</h2>
      </div>
    </div>
  );
}

