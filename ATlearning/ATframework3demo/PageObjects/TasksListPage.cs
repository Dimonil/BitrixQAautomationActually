using atFrameWork2.TestEntities;
using ATframework3demo.PageObjects;
using ATframework3demo.TestEntities;
using OpenQA.Selenium;

namespace atFrameWork2.PageObjects
{
    public class TasksListPage
    {
        public TasksListPage(IWebDriver driver = default)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }
        public TasksListPage ChooseAllTasks() 
        {  
            return new TasksListPage(Driver); 
        }
        public TasksListPage GroupAction(TasksAction action)
        {
            return new TasksListPage(Driver);
        }
        public TasksFinderBox OpenFinderBox()
        {
            //
            return new TasksFinderBox(Driver);
        }
        public TasksListPage ApplyChangeTasks()
        {
            return new TasksListPage(Driver);
        }
        public void AssertChangeExecutor(User user)
        {
            throw new NotImplementedException();
        }
        
    }
}