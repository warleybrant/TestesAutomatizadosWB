//If you are interested in scripting, this is the SimpleTest_Sample test written in Javascript.

function Main() {
  OpenWebStore("http://services.smartbear.com/samples/TestComplete12/smartstore");
  
  FindProduct("Solar");
  AddToCart();
  VerifyProductPrice("969.0");
  RemoveFromCart();
  
  CloseBrowser();
}

function OpenWebStore(url) {
  //Launch the Internet Explorer and navigate to a webpage
  Browsers.Item(btIExplorer).Run(url); 
}

function FindProduct(productName) {
  Aliases.Browser.FrontPage.FrontPageSearchBox.SetText(productName);
  Aliases.Browser.FrontPage.SearchButton.ClickButton();
  Aliases.Browser.SearchPage.FoundProduct.Click();
}

function AddToCart() {
  //Wait until the web page is loaded completely to ensure the next click will be processed correctly by the web page
  Aliases.Browser.ProductPage.Wait();
  Aliases.Browser.ProductPage.AddToCartButton.ClickButton();
}

function VerifyProductPrice(price) {
  //Check that contentText property value contains the expected price
  aqObject.CheckProperty(Aliases.Browser.ProductPage.Cart.Subtotal, "contentText", cmpContains, price);
}

function RemoveFromCart() {
  Aliases.Browser.ProductPage.Cart.RemoveFromCartLink.ClickButton(); 
}

function CloseBrowser() {
  Aliases.Browser.Close();
}
