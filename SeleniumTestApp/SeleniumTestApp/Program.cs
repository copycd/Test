// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium.Chrome;

Console.WriteLine("Hello, World!");


ChromeDriverService svc = ChromeDriverService.CreateDefaultService();
var chromeDrv = new ChromeDriver(svc);
chromeDrv.Navigate().GoToUrl("https://www.naver.com");