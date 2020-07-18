using System;

namespace DesPattCode.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new ZipDataProcessorWithKeyCancellation();
            processor.Run();
        }
    }
}
