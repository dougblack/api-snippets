using Twilio.TwiML;


class Example
{
    static void Main()
    {
        var response = new VoiceResponse();
        var dial = new Dial();
        dial.Sip("sip:jack@example.com;transport=tcp");
        response.Dial(dial);

        System.Console.WriteLine(response.ToString());
    }
}
