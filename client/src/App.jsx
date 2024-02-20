// config options
import React from "react";
import ReactDOM from "react-dom/client";
import {createBrowserRouter, RouterProvider} from "react-router-dom";
import "./index.css";

// pages / layouts
import Main from "./Layout/Main.jsx";
import Home from "./Pages/Home.jsx";
import ProductsPage from "./Pages/ProductPage.jsx";
import About from "./Pages/AboutPage.jsx";

const router = createBrowserRouter([
  {
    path: "/",
    element: <Main />,
    children: [
      {
        path: "/",
        element: <Home />
      },
      {
        path: "products/:productPage",
        element: <ProductsPage />
      },

      {
        path: "about",
        element: <About />
      },
      {
        path: "sign-in",
        element: <p> Sign in to your mummy </p>
      },
      {
        path: "car-creator",
        element: <p> I will let you build a car later :D</p>
      }
    ]
  },
]);

ReactDOM.createRoot(document.getElementById("root")).render(
  <React.StrictMode>
    <RouterProvider router={router} />
  </React.StrictMode>
);
