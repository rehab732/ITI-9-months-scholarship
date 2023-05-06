import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import {
  createBrowserRouter,
  RouterProvider,
} from "react-router-dom";

import Home from './Pages/Home';
import Page1 from './Pages/page1';
import Page2 from './Pages/page2';
import Page3 from './Pages/page3';
const router = createBrowserRouter([
  {
    path: "/",
    element:<Home/>,
    errorElement:<h1>Sorry this page Not Found 404</h1>
  },
  {
    path: "/page1",
    element:<Page1/>,
  },  {
    path: "/page2",
    element:<Page2/>,
  },  {
    path: "/page3",
    element:<Page3/>,
  },
    
]);
const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <RouterProvider router={router} />
  </React.StrictMode>
);
