using System.Collections.Generic;

namespace SWD_Day6
{
    public class SampleUseCase
    {
        DataCollection sensorData = new DataCollection();
        InputExtractor inputJson = new InputExtractor();
        private string result;

        public async Task<string> CheckUseCase()
        {
            await Task.Delay(1);
            return result;
        }
    }
}