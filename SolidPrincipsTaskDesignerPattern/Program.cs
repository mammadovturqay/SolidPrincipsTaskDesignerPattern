using System;

public interface IButton
{
    void Render();
    void onClick();

}

public class  WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Renderin windows Button ");

    }
    public void onClick()
    {
        Console.WriteLine("Windows Button Clicked ");

    }

}


public class HTMLButton : IButton
{
    public void Render() { Console.WriteLine("Render Html button "); }

    public void onClick() { Console.WriteLine("HTML button clicked "); }

}

public abstract class Dialog
{
    public abstract IButton CreateButton();
    public void Render()
    {
        var Button = CreateButton();
        Button.Render();

    }

}


public class WindowsDialog : Dialog
{
    public override IButton CreateButton()
    {
        return new  WindowsButton();

    }
}


public class WebDialog : Dialog
{
    public override IButton CreateButton()
    {
        return new HTMLButton();
    }
}

public class Program
{
    public static void Main (string[] args)
    {
        Dialog Windowdialog1 = new WindowsDialog();  
        Windowdialog1.Render();

        Dialog Webdialog1 = new WebDialog();
       Webdialog1.Render();


    }
}