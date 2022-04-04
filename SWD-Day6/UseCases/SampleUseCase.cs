using System.Collections.Generic;

namespace SWD_Day6
{
    public class SampleUseCase
    {
        InputExtractor inputJson = new InputExtractor();
        DataCollection sensorData = new DataCollection();
        private string result;

        public async Task<string> CheckUseCase()
        {
            await Task.Delay(1);
            return result;
        }
    }
}