import {useState, useEffect} from "react";
import ProductCard from "./ProductCard.jsx";
import "./ProductGrid.css";

export default function ProductGrid(){
  const [products, SetProducts] = useState([]);
  const [information, setInformation] = useState({});
  const [page, setPage] = useState(1);
  const [loadingState, setLoadingState] = useState({
    products: true,
    pageInformation: true
  });

  useEffect( () => {
    async function FetchProducts(){
      await fetch(`http://localhost:5116/api/PaginatedProduct/ProductPage?page=${page}`)
        .then( response => {
          return response.json();
        })
      .then( data => {
        SetProducts(data);
      });
      setLoadingState({
        ...loadingState,
        products: true
      });
    }

    async function FetchInformation(){
      await fetch(`http://localhost:5116/api/PaginatedProduct/Information`)
      .then( response => {
        return response.json();
      })
      .then( data => {
        setInformation(data);
      });
      setLoadingState({
        ...loadingState,
        pageInformation: true
      });
    }
    FetchProducts();
    FetchInformation();
  }, [page]);

  let productList = products.map( (productItem, index) => {
    return(
      <ProductCard key={index} product={productItem} pageNumber={page}/>
    )
  })

  function FinishedLoading(loadingState){
    let informationFinished = loadingState.pageInformation === false;
    let pageFinished = loadingState.products === false;
    return (informationFinished && pageFinished) ? true: false;
  }

  if(FinishedLoading(loadingState)){
    return (
      <h1> Ayo you loading </h1>
    )
  }

  else{
    return(
      <div className="product-content">
        <div className ="product-grid">
          {productList}
        </div>
        <div className="page-controller">
          <button type="button" onClick={ () => {
              if(page !== 1){
                setPage(page - 1);
              }
            }
          }> -1 </button>
          <p>Page Number: {page}</p>
          <button type="button" onClick={ () => {
              if(page !== information.totalPages){
                setPage(page + 1);
              }
            }
          }> +1 </button>
        </div>
      </div>
    )
  }
}
