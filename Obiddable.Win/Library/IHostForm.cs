namespace Obiddable.Win.Library;

public interface IHostForm
{
    void GoForward(HostScreen control);

    void GoBack();

    void GoTo(HostScreen control);

    HeaderWidthManager HeaderWidthManager { get; }
}
