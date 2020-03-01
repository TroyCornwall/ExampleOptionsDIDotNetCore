using System;
using Microsoft.Extensions.Options;

namespace OptionsLoadingConsoleApp
{
    public class ExampleService: IExampleService
    {
        private MyOptions _myOptions;

        public ExampleService(IOptionsMonitor<MyOptions> myOptions)
        {
            _myOptions = myOptions.CurrentValue;
        }

        public void Run()
        {
            Console.WriteLine(_myOptions.Example);
        }
    }
}