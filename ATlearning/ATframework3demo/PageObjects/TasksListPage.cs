using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;
using ATframework3demo.PageObjects;
using OpenQA.Selenium;
using atFrameWork2.BaseFramework.LogTools;
using atFrameWork2.BaseFramework;

namespace atFrameWork2.PageObjects
{
    public class TasksListPage

    {
        WebItem checkBoxTasks =>
                new WebItem("//input[@id='TASKS_GRID_ROLE_ID_4096_0_ADVANCED_N_check_all']", 
                    "отметка всех задач");
        WebItem buttonGroupAction =>
            new WebItem("//span[@id='action_button_TASKS_GRID_ROLE_ID_4096_0_ADVANCED_N_control']",
                "кнопка группового действия");
        WebItem popupGroupAction =>
            new WebItem("//div[@id='menu-popup-action_button_TASKS_GRID_ROLE_ID_4096_0_ADVANCED_N_control_menu']",
                "Выбор группового действия");

        WebItem changeExecutor =>
            new WebItem("//span[text()='Сменить исполнителя']",
                "кнопка сменить исполнителя");

        WebItem buttonSelectUser =>
            new WebItem("//input[@id='action_set_responsible_text_control']",
                "кнопка открытия поле для выбора юзера");
        WebItem fieldFindUser =>
            new WebItem("//input[@id='bx-dest-internal-input']",
                "Поле для поиска сотрудника");
        WebItem resultUser =>
            new WebItem($"//div[contains(text(),'{TestCase.RunningTestCase.TestPortal.PortalAdmin.LoginAkaEmail}')]",
                "Выбор конкретного юзера");

        WebItem buttonApplyChange =>
            new WebItem("//span[@id='apply_button_control']",
                "Нажать кнопку применить");
        WebItem buttonConfirm =>
            new WebItem("//span[@class='popup-window-button popup-window-button-accept']",
                "Нажать продолжить");

        WebItem checkExecutor =>
            new WebItem("//span[@class='tasks-grid-username-inner tasks-grid-avatar-extranet']",
                "объекты исполнителей");
        public TasksListPage(IWebDriver driver = default)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }
        public TasksListPage ChooseAllTasks() 
        {  
            checkBoxTasks.Click();

            return new TasksListPage(); 
        }
        public TasksListPage GroupAction()
        {
            buttonGroupAction.Click();
            changeExecutor.Hover();
            changeExecutor.Click();
 
            return new TasksListPage();
        }
        public TasksListPage OpenFinderBox()
        {
            buttonSelectUser.Click();
            
            return new TasksListPage();
        }
        public TasksListPage ApplyChangeTasks()
        {
            buttonApplyChange.Click();
            buttonConfirm.Click();
            
            return new TasksListPage();
        }
        public bool AssertChangeExecutor()
        {     
            return checkExecutor.InnerText() == "Дмитрий Смоленцев";
        }
        public TasksListPage ChooseUser()
        {
            fieldFindUser.SendKeys($"{TestCase.RunningTestCase.TestPortal.PortalAdmin.LoginAkaEmail}");
            resultUser.WaitElementDisplayed(5);
            resultUser.Click();

            return new TasksListPage();
        }
       
        
    }
}