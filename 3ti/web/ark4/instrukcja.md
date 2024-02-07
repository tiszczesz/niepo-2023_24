## Praca z ciasteczkami w Asp.core

https://www.codeguru.com/dotnet/asp-net-cookies/

The term cookie refers to a piece of data that is saved on the computer of a user and is generally used to record information about the user. Most browsers store each cookie as a small file, but Firefox stores them all in a single file. Cookies are made up of two parts: a key and a value.

ASP.NET 6 Core uses cookies to maintain user session state and for authentication purposes. ASP.NET Core uses the Microsoft.AspNetCore.Http.Cookie middleware to work with cookies. This middleware can be used to set, get, and delete cookies.

In this programming tutorial, we will be discussing cookies in ASP.NET 6 Core. We will cover what a cookie is, how to create and manipulate a cookie, and some of the security implications to keep in mind when working with cookies in ASP.NET.

Read: Best Online Courses to Learn .NET
What is a Cookie in ASP.NET?

In basic terms, a cookie is a smaller piece of information stored on a computer, usually as a text file. It keeps the information about you and your activities, like your preferred language or country. Cookies can also help web developers track user behaviour to improve our services and web sites.

To better understand this, consider the following example. If you have been performing searches for one particular type of product or service, but then start searching for something different, as a webmaster we might need to show more relevant search results to help get you closer to finding what you want.

Additionally, if you visit a website and add items to your shopping cart, but do not complete the purchase, the website will “remember” what you added to your cart so that when you come back later, your shopping cart will still contain those items.

Cookies allow web developers to customize content based on how people use our site — for example, by recognizing when they return after logging out of their account. This customization allows us to make better decisions and understand how visitors interact with our content to optimize future experiences accordingly.
What are the Different Types of Cookies?

Basically, cookies can be divided into two types, namely session cookies and persistent cookies. When you visit a website, session cookies are stored on your computer only for the duration of your visit. A session cookie is destroyed when you leave your browser or move away from a web page.

As the name suggests, persistent cookies dwell on your computer even after you have closed your web browser. Persistent cookies can store information accessible across multiple sessions. Generally, these cookies store login information or preferences.
How to Create a Cookie in ASP.NET

Creating a cookie in ASP.NET Core is simple. First, create a new CookieOptions object as shown in the code example given below:

var cookieOptions = new CookieOptions(); 

Next, set the expiration date and path of the cookie, as shown below:

```cs
cookieOptions.Expires = DateTime.Now.AddDays(1);
cookieOptions.Path = "/"; 
```

Lastly, add the cookie to the response object, as shown below:
```cs
Response.Cookies.Append("SomeCookie", "SomeValue", cookieOptions);
```
You can view your web browser’s cookie cache to determine whether a cookie has been written correctly.

Read: The Top Task Management Software for Developers
How to Read a Cookie in ASP.NET

In ASP.NET 6 Core, you can take advantage of the Request object’s Cookies collection to read a cookie. This collection is an instance of the HttpCookieCollection class. To read a cookie, use the indexer of this class to retrieve the HttpCookie object for a given cookie name:
```cs
var cookie = Request.Cookies["cookieName"]; 
```
If the cookie does not exist, the indexer returns null. You can also use the Cookies collection’s Get method to retrieve a cookie:
```cs
var cookie = Request.Cookies.Get("cookieName"); 
```
If the cookie does not exist, this method returns null as well.
How to Update a Cookie in ASP.NET

To update a cookie in ASP.NET 6 Core, you will need to retrieve the cookie from the Request object using the following piece of code:

var cookie = Request.GetCookies("cookieName"); 

You can then modify the cookie value as desired. Lastly, you can write the updated cookie back to the Response object using the SetCookie method, as shown below:

Response.SetCookie(cookie);

Delete a Cookie in ASP.NET

When using ASP.NET Core 6, there are two ways to delete a cookie. The first way is to use the Delete method of the Cookie object as shown below:

Response.Cookies.Delete(somekey); 

The second way is to use the Response object and set the Expires property of the cookie to a date in the past as shown in the ASP.NET code example below:
```cs
Response.Cookies["cookieName"].Expires = DateTime.Now.AddDays(-1);
```
You can use the Clear method to clear all cookies as shown here:

Response.Cookies.Clear();

How to Access Cookies in the Controller Method

To access cookies in the Controller method, developers should register an instance of type IHttpContextAccessor in the Program.cs file as shown below:
```cs
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
```
To read or write cookie data in your controller methods, you will need to inject an instance of type IHttpContextAccessor in the constructor of your controller. The code example given below illustrates how this can be achieved:

```cs
public class SomeController : Controller
{
  private readonly IHttpContextAccessor _httpContextAccessor;
  public SomeController(IHttpContextAccessor httpContextAccessor)
  {
     this._httpContextAccessor = httpContextAccessor;
  }   
  //Write your action methods here
}
```
You can now use the following piece of code to access the Cookies object in your controller methods:

CookieOptions options = new CookieOptions();
options.Expires = DateTime.Now.AddSeconds(30);
_httpContextAccessor.HttpContext.Response.Cookies.Append("someKey", "someValue", options);

Final Thoughts on Cookies in ASP.NET

If you would like to use cookies to store sensitive information, it is important to ensure that your cookies are properly secured using SSL/TLS encryption. In this web development tutorial, we examined how programmers can work with cookies in ASP.NET 6 Core. We also explored the different types of cookies and how to create, read, and update them programmatically.

Read more ASP.NET programming tutorials and web development tips.