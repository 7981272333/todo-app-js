body {
    font-family: "Roboto", sans-serif;
    font-size: 32px;
    font-weight: 100;
    
  }
  
  .container {
    position: relative;
    margin: 20px 200px;
  }
  
  .flex-row,
  .flex-row-list {
    display: flex;
    justify-content: space-between;
    align-items: center;
    flex-wrap: wrap;
  }
  
  .heading-bold {
    font-size: 1.5em;
    font-weight: bold;
  }
  
  .heading-thin {
    font-size: 1em;
    font-weight: 100;
  }
  
  .fa-plus-circle {
    color: #4b8ce8;
    cursor: pointer;
  }
  
  .fa-check {
    font-size: 14px;
    color: rgb(160, 0, 0);
    cursor: pointer;
  }
  
  .card {
    min-height: 355px;
    min-width: 229px;
    border: 1px solid #e74c3c;
    background: #ffffff 0% 0% no-repeat padding-box;
    box-shadow: 10px 10px 10px #00000029;
    border-radius: 10px;
    text-align: center;
    margin: 10px;
    padding-bottom: 0px;
    display: flex;
    flex-direction: column;
    justify-content: space-between;
  }
  
  .card-2 {
    min-height: 355px;
    min-width: 229px;
    border: 1px solid #e74c3c;
    background: #ffffff 0% 0% no-repeat padding-box;
    box-shadow: 10px 10px 10px #00000029;
    border-radius: 10px;
    text-align: center;
    margin: 10px;
    padding-bottom: 0px;
    display: flex;
    flex-direction: column;
    justify-content: space-between;
  }
  
  .markDone {
    font-size: 10px;
    height: 20px;
    width: auto;
    background-color: #4b8ce8;
  }
  
  .card-heading {
    font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
    font-size: 0.7em;
    color: #e74c3c;
    margin-bottom: 0px;
    position: relative;
  }
  
  .card-heading::after {
    content: "";
    position: absolute;
    margin-top: 11px;
    border-top-left-radius: 10px;
    border-bottom-left-radius: 10px;
    background-color: #000000;
    position: absolute;
    height: 1px;
    width: 100%;
    top: 30px;
    left: 2%;
    margin-left: -5px;
  }
  
  .card-item {
    font-size: 0.6em;
    font-weight: 400;
    margin-bottom: 7px;
    color: #34343b;
  }
  
  .card-item-2 {
    font-size: 0.6em;
    font-weight: 400;
    margin-bottom: 7px;
    color: #34343b;
  }
  
  .back {
    cursor: pointer;
  }
  
  .card-item-checked {
    color: #ff0000;
    text-decoration: line-through;
  }
  
  ul {
    padding-left: 0;
  }
  
  .flex-row-center {
    display: flex;
    justify-content: center;
    flex-wrap: wrap;
  }
  
  .list-card {
    height: 355px;
    width: 400px;
    min-width: 250px;
    border: 1px solid #e74c3c;
    background: #ffffff 0% 0% no-repeat padding-box;
    box-shadow: 10px 10px 10px #00000029;
    border-radius: 10px;
    text-align: center;
  }
  
  .container#blur.active {
    filter: blur(20px);
    pointer-events: none;
    user-select: none;
  }
  
  .container#blur-2.active {
    filter: blur(20px);
    pointer-events: none;
    user-select: none;
  }
  
  .popup {
    position: fixed;
    top: 40%;
    left: 35%;
    width: 445px;
    height: 226px;
    background: #ffffff 0% 0% no-repeat padding-box;
    box-shadow: 10px 10px 10px #00000029;
    border: 1px solid #e74c3c;
    border-radius: 10px;
    opacity: 0;
    visibility: hidden;
    transition: 0.5s;
  }
  
  .flex-column {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
  }
  
  .popup-text {
    font-size: 23px;
    font-weight: 400;
    color: #ff0000;
    margin: 10px;
  }
  
  input {
    width: 320px;
    height: 43px;
    background: #ffffff 0% 0% no-repeat padding-box;
    box-shadow: 3px 3px 3px #00000029;
    border: 1px solid #e74c3c;
    border-radius: 5px;
    opacity: 1;
    text-align: center;
  }
  
  button {
    width: 101px;
    height: 43px;
    background: #e74c3c;
    border-radius: 20px;
    opacity: 1;
    border: none;
    font-size: 0.8em;
    color: white;
    font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
    margin: 10px;
    cursor: pointer;
  }
  
  .btn {
    cursor: pointer;
  }
  
  .footer {
    display: flex;
    justify-content: flex-end;
    align-items: center;
    align-self: flex-end;
  }
  
  .footer-2 {
    display: flex;
    justify-content: flex-end;
    align-items: center;
    align-self: flex-end;
  }
  
  .btn-completed {
    font-size: 15px;
    width: 32px;
    height: 32px;
    background-color: #e74c3c;
    cursor: pointer;
  }
  
  .btn-add {
    text-align: right;
    padding-right: 10px;
    cursor: pointer;
  }
  
  #pop.active {
    top: 30%;
    opacity: 1;
    visibility: visible;
    transition: 0.5s;
  }
  
  #popAddItem.active {
    top: 30%;
    opacity: 1;
    visibility: visible;
    transition: 0.5s;
  }
  
  button:focus {
    outline: none;
  }
  
  @media only screen and (max-width: 600px) {
    body {
      font-size: 26px;
    }
    .container {
      position: relative;
      margin: 10px 20px;
    }
    #content {
      content: none;
    }
    .card {
      min-height: 40px;
      width: 100%;
      border: 1px solid #ccc9c9;
    }
    .card-item {
      display: none;
    }
    .card-heading {
      font-size: 25px;
      height: 10px;
      cursor: pointer;
      color: #6a6a72;
      justify-content: flex-start;
      text-align: center;
    }
    .card-heading::after {
      width: 0;
    }
    .footer {
      display: none;
    }
    .addItem {
      display: none;
    }
  
    .popup {
      position: fixed;
      top: 40%;
      left: 10%;
      width: 300px;
      height: 200px;
    }
    .popup-text {
      font-size: 20px;
      font-weight: 400;
      color: #ff0000;
      margin: 10px;
    }
  
    button {
      width: 60px;
      height: 33px;
      font-size: 0.5em;
    }
    input {
      width: 220px;
      height: 35px;
    }
    #currentHeading {
      font-size: 28px;
    }
  }
  