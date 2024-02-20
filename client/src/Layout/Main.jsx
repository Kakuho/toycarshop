import { Outlet } from "react-router-dom";
import Header from "./../Components/Navigation/Header.jsx";
import Footer from "./../Components/Navigation/Footer.jsx";
import "./Main.css";

export default function Main(){
  return(
    <div className="main">
      <Header />
      <div className="content">
        <Outlet />
      </div>
      <Footer />
    </div>
  )
}
