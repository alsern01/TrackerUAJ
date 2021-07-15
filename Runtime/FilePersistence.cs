public class FilePersistence : FilePersistence
{

    Writer w;
    public FilePersistence()
    {
        w.Init()
    }
        
    public override void Send(Event item, string format)
    {
        w.WriteToFile(Event e, string format);
    }

}