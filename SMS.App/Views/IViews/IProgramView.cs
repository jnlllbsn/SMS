
namespace SMS.App
{
    public interface IProgramView
    {
        string Description { get; set; }
        int ProgramId { get; set; }
        string ProgramName { get; set; }

        void GetProgramList(BindingSource bindingSource);

        event EventHandler CreateEvent;
        event EventHandler ReadEvent;
        event EventHandler UpdateEvent;
        event EventHandler DeleteEvent;
    }
}