using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


WebDriver devByioPage = new ChromeDriver();
devByioPage.Url = "https://devby.io/";
devByioPage.Manage().Window.Maximize();

const string MAIN_PAGE_JAVA_VACANCIES_COUNT_XPATH = "//div[@data-gtm-track='jobs-specializations-main']//child::a[@title='Java']//following-sibling::div";
const string JAVA_VACANCIES_COUNT_XPATH = "//*[@class='vacancies-list-item__body js-vacancies-list-item--open']";

var MainPageJavaVacanciesCount = Int32.Parse(devByioPage.FindElement(By.XPath(MAIN_PAGE_JAVA_VACANCIES_COUNT_XPATH)).Text.Split(" ")[0]);

devByioPage.Url = "https://jobs.devby.io/?filter[specialization_title]=Java";

var PageJavaVacanciesCount = devByioPage.FindElements(By.XPath(JAVA_VACANCIES_COUNT_XPATH)).Count();

if (MainPageJavaVacanciesCount == PageJavaVacanciesCount)
{
    Console.WriteLine("=================== Similar values =====================");
}
else
{
    Console.WriteLine("=================== Different values ====================");
}

devByioPage.Close();