using indice.Edi;
using System;

public class EDI_X12Grammar : IEdiGrammar
{
    public EDI_X12Grammar(string FunctionalGroupTrailerTag, string MessageHeaderTag, string InterchangeTrailerTag, string ServiceStringAdviceTag, string InterchangeHeaderTag, string FunctionalGroupHeaderTag, string MessageTrailerTag, char SegmentNameDelimiter, char DataElementSeparator, char ComponentDataElementSeparator, char SegmentTerminator, char? ReleaseCharacter, char? Reserved, char? DecimalMark)
    {
        _ComponentDataElementSeparator = ComponentDataElementSeparator;
        _DataElementSeparator = DataElementSeparator;
        _DecimalMark = DecimalMark;
        _ReleaseCharacter = ReleaseCharacter;
        _Reserved = Reserved.ToString().ToCharArray();
        _SegmentTerminator = SegmentTerminator;
        _ServiceStringAdviceTag = ServiceStringAdviceTag;
        _SegmentNameDelimiter = SegmentNameDelimiter;
        _MessageTrailerTag = MessageTrailerTag;
        _FunctionalGroupHeaderTag = FunctionalGroupHeaderTag;
        _InterchangeHeaderTag = InterchangeHeaderTag;
        _ServiceStringAdviceTag = ServiceStringAdviceTag;
        _InterchangeTrailerTag = InterchangeTrailerTag;
        _MessageHeaderTag = MessageHeaderTag;
        _FunctionalGroupTrailerTag = FunctionalGroupTrailerTag;

    }
        private char[] _Reserved { get; }
        private string _MessageTrailerTag { get; }
        private string _MessageHeaderTag { get; }
        private string _FunctionalGroupHeaderTag { get; }
        private string _InterchangeHeaderTag { get; }
        private string _ServiceStringAdviceTag { get; }
        private char _SegmentTerminator { get; }
        private string _FunctionalGroupTrailerTag { get; }
        private string _InterchangeTrailerTag { get; }
        private char? _DecimalMark { get; }
        private char _DataElementSeparator { get; }
        private char _ComponentDataElementSeparator { get; }
        private char _SegmentNameDelimiter { get; }
        private char? _ReleaseCharacter { get; }




        public char[] Reserved { get { return _Reserved;} set { Reserved = value; } }
        public string MessageTrailerTag { get { return _MessageTrailerTag;} set { MessageTrailerTag = value; } }
        public string MessageHeaderTag { get { return _MessageHeaderTag;} set {MessageHeaderTag = value} }
        public string FunctionalGroupHeaderTag { get { return FunctionalGroupHeaderTag;} set { FunctionalGroupHeaderTag = value; } }
        public string InterchangeHeaderTag { get { return _InterchangeHeaderTag;} set {InterchangeHeaderTag = value;} }
        public string ServiceStringAdviceTag { get { return _ServiceStringAdviceTag;} set { ServiceStringAdviceTag = value;} }
        public char SegmentTerminator { get { return _SegmentTerminator;} set { SegmentTerminator = value; } }
        public string FunctionalGroupTrailerTag { get {return _FunctionalGroupTrailerTag;} set { FunctionalGroupTrailerTag = value; } }
        public string InterchangeTrailerTag { get { return _InterchangeTrailerTag; } set { InterchangeTrailerTag = value; } }
        public char? DecimalMark { get { return _DecimalMark;} set { DecimalMark = value; } }
        public char DataElementSeparator { get{ return _DataElementSeparator;} set { DataElementSeparator = value; } }
        public char ComponentDataElementSeparator { get { return _ComponentDataElementSeparator;} set {ComponentDataElementSeparator = value; } }
        public char SegmentNameDelimiter { get { return _SegmentNameDelimiter; } set { SegmentNameDelimiter = value; } }
        public char? ReleaseCharacter { get { return _ReleaseCharacter;} set { ReleaseCharacter = value; } }




        public bool IsSpecial(char character)
        {   
            return true;
        }
        public void SetAdvice(char segmentNameDelimiter, char dataElementSeparator, char componentDataElementSeparator, char segmentTerminator, char? releaseCharacter, char? reserved, char? decimalMark)
        {
            Console.WriteLine("Hello World!");
        }
        public void SetAdvice(char[] chars)
        {
            Console.WriteLine("Populate Me!");
        }

}