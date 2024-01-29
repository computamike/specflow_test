using BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTest
{
    [Binding]
    public class hooks
    {
        public ScenarioContext _scenarioContext { get; private set; } = null!;

        public hooks(ScenarioContext scenarioContext, IObjectContainer container)
        {
            _scenarioContext = scenarioContext;
        }

            [BeforeScenario] // -> Notice how we're doing these steps before each scenario
        public async Task RegisterSingleInstancePractitioner()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(path, "test_explorer.log");
            File.AppendAllText(filePath, $"{Environment.NewLine}{DateTime.Now} {_scenarioContext.ScenarioInfo.Title}");
            await Console.Out.WriteLineAsync("STARTING TEST");
        }
    }
   }
