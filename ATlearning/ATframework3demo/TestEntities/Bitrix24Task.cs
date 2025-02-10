using AquaTestFramework.CommonFramework.BitrixCPinteraction;
using atFrameWork2.BaseFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.TestEntities
{
    public class Bitrix24Task
    {
        public Bitrix24Task(string title)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
        }
        public void CreateTask()
        {
            
            var phpExecutor = new PHPcommandLineExecutor(TestCase.RunningTestCase.TestPortal.PortalUri,
                TestCase.RunningTestCase.TestPortal.PortalAdmin.LoginAkaEmail,
                TestCase.RunningTestCase.TestPortal.PortalAdmin.Password);

            string phpCodeCreateTask = $"if (CModule::IncludeModule(\"tasks\"))\r\n{{\r\n\t$arFields = Array(\r\n\t\t\"TITLE\" => \"Task title\",\r\n\t\t\"DESCRIPTION\" => \"Task description\",\r\n\t\t\"RESPONSIBLE_ID\" => 2,\r\n\t);\r\n\t$obTask = new CTasks;\r\n\t$ID = $obTask->Add($arFields);\r\n}}";
            phpExecutor.Execute(phpCodeCreateTask);
        }

        public string Title { get; set; }
        public string Description { get; set; }
    }
}
