using atFrameWork2.PageObjects;
using atFrameWork2.TestEntities;
using OpenQA.Selenium;

namespace ATframework3demo.PageObjects
{
    public class TasksFinderBox
    {
        public TasksFinderBox(IWebDriver driver = default)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }
        public TasksFinderBox ChooseExecutor(User user) { return new TasksFinderBox(Driver); }
        public TasksListPage CloseFinderBox() 
        {
            //
            return new TasksListPage(Driver);
        }
    }
}
