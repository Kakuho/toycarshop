import {Link} from "react-router-dom";
import "./Header.css";

export default function Header(){
  return(
    <div className="header">
      <Link className="link" to={"/"}>Home</Link>
      <Link className="link" to={"/products/1"}>Products</Link>
      <Link className="link" to={"/about"}>About</Link>
      <Link className="link" to={"/sign-in"}>Sign In</Link>
      <Link className="link" to={"/car-creator"}>Car creator</Link>
    </div>
  )
}
