using System;
using System.IO;
using indice.Edi;

namespace hcFinance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var grammar = new EDI_X12Grammar() 
                {
                        ComponentDataElementSeparator = new[] { '>' },
                        DataElementSeparator = new[] { '*' },
                        DecimalMark = null,
                        ReleaseCharacter = null,
                        Reserved = new char[0],
                        SegmentTerminator = '~',
                        ServiceStringAdviceTag = null,
                        InterchangeHeaderTag = "ISA",
                        FunctionalGroupHeaderTag = "GS",
                        MessageHeaderTag = "ST",
                        MessageTrailerTag = "SE",
                        FunctionalGroupTrailerTag = "GE",
                        InterchangeTrailerTag = "IEA",
                    };
            using (var stream = new StreamReader("C:\\Users\\ccuts\\Documents\\CSharp_Scripts\\hcFinance\\fake835_0.edi")) {
                interchange = new EdiSerializer().Deserialize<Interchange>(stream, grammar);
            }
        }
    }
}
