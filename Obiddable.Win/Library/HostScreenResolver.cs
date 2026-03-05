namespace Obiddable.Win.Library;

public class HostScreenResolver
{
    public HostScreen Resolve<TScreen>() where TScreen : HostScreen
    {
        HostScreen output;

        output = (HostScreen)Activator.CreateInstance<TScreen>();

        return output;
    }
}
