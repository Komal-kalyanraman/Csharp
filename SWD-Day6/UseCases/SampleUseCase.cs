using System.Collections.Generic;

namespace SWD_Day6
{
    public class SampleUseCase
    {
        InputExtractor inputJson = new InputExtractor();
        private string result;

        public string Run()
        {
            result = "I am a standard UseCase template";
            return result;
        }
    }
}