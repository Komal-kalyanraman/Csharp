using System.Collections.Generic;

namespace SWD_Day6
{
    public class UseCaseRouter
    {
        InputExtractor inputJson = new InputExtractor();

        DataCollection sensorData = new DataCollection();
        private string result;

        public string UseCaseExtractor()
        {
            inputJson.ReadFile();
            result = inputJson.UseCase();
            return result;
        }
    }
}