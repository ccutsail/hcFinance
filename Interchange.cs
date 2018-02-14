public class Interchange
{
    public Interchange()
    {
        this.InterchangeHeader = new InterchangeHeader();
        this.Quote = new Quote();
        this.InterchangeTrailer = new InterchangeTrailer();
    }

    public InterchangeHeader InterchangeHeader { get; set; }

    public Quote Quote { get; set; }

    public InterchangeTrailer InterchangeTrailer { get; set; }
}