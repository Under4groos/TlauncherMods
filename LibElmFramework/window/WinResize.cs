using System;
using System.Windows;
 
using System.Windows.Input;


public class WinResize
{
    Window Wind;
    UIElement Element;
    ThreadTimer threadTimer;
    Point  poscur;
    Point last_poscur;

    double Width = 0;
    double Height = 0;
    Size resizeSize;
    bool isMouseDoun = false;
    bool isMouseMoove = false;
    public WinResize() { }
    public WinResize(Window w)
    {
        Wind = w;


        threadTimer = new ThreadTimer(Wind);
        threadTimer.TickTime = 10;
        threadTimer.Tick += (i, d) =>
        {
 
            if (isMouseDoun && WinApi.MouseKeyState(0x01) == true )
            {
                WinApi.GetCursorPos(out poscur);
                Width = resizeSize.Width - (last_poscur.X - poscur.X);
                Height = resizeSize.Height - (last_poscur.Y - poscur.Y);

                Wind.Width = Width < Wind.MinWidth ? Wind.MinWidth + 15 : Width;
                Wind.Height = Height < Wind.MinHeight ? Wind.MinHeight + 15 : Height;
            }
        };

      
        Wind.MouseEnter += (sender, e) => isMouseMoove = true;
        Wind.MouseLeave += (sender, e) => isMouseMoove = false;
        threadTimer.initialize();
    }

    public WinResize(bool isMouseMoove)
    {
        this.isMouseMoove = isMouseMoove;
    }

    public void RightDown(UIElement element)
    {
        Element = element;
        MouseHandlers(Element);
    }

    private void MouseHandlers(UIElement element)
    {
        element.MouseLeftButtonDown += new MouseButtonEventHandler(element_MouseLeftButtonDown);
        element.MouseLeftButtonUp += new MouseButtonEventHandler(element_MouseLeftButtonUp);
        element.MouseEnter += (sender, e) =>
        {
            Wind.Cursor = Cursors.SizeNWSE;
             
        };
        element.MouseLeave += (sender, e) =>
        {
            Wind.Cursor = Cursors.Arrow;
             
        };
    }

    private void element_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        isMouseDoun = false;


    }

    private void element_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        WinApi.GetCursorPos(out last_poscur);
        resizeSize = new Size(Wind.Width, Wind.Height);
        isMouseDoun = true;
    }


}
