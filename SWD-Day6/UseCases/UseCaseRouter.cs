using System.Collections.Generic;

namespace SWD_Day6
{
    public class UseCaseRouter
    {
        InputExtractor inputJson = new InputExtractor();

        DataCollection sensorData = new DataCollection();

        public string UseCaseExtractor()
        {
            inputJson.ReadFile();
            string result = inputJson.UseCase();
            return result;
        }
    }
}