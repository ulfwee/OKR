using Xunit;
using projectLR2;  
using System.Threading;

namespace test1
{
    public class UnitTest1
    {
        // Запуск у STA (для WinForms обов’язково)
        [StaFact]
        public void Form1_Should_Open_Without_Exception()
        {
            var exception = Record.Exception(() =>
            {
                var form = new Form1();
                form.Dispose();
            });

            Assert.Null(exception);
        }

    }

    // Спеціальний Attribute для запуску в STA
    public sealed class StaFactAttribute : FactAttribute { }
}
