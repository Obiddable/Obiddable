namespace Obiddable.Win.Library;

public interface IActionMenu
{
    void AddSeparator();
    void AddAction(string title, Action action, bool enabled = true);
    void AddActionSubMenu(string title, Action<IActionMenu> addSubActions);
}
