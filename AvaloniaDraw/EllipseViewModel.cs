using Avalonia;
using ReactiveUI;

namespace AvaloniaDraw;

public class EllipseViewModel : ViewModelBase
{
    private int _width;
    
    public int Width
    {
        get => _width;
        set => this.RaiseAndSetIfChanged(ref _width, value);
    }

    private int _height;

    public int Height
    {
        get => _height;
        set => this.RaiseAndSetIfChanged(ref _height, value);
    }

    private Point _centre;

    public Point Centre
    {
        get => _centre;
        set => this.RaiseAndSetIfChanged(ref _centre, value);
    }

    private double _opacity;

    public double Opacity
    {
        get => _opacity;
        set => this.RaiseAndSetIfChanged(ref _opacity, value);
    }
}