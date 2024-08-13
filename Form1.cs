using Avalonia.Animation;
using Avalonia.Animation.Easings;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Styling;

public class AnimatedButton : Button
{
    public AnimatedButton()
    {
        this.PointerEnter += OnPointerEnter;
        this.PointerLeave += OnPointerLeave;
    }

    private void OnPointerEnter(object? sender, Avalonia.Input.PointerEventArgs e)
    {
        var animation = new Animation
        {
            Duration = TimeSpan.FromSeconds(0.3),
            Easing = new QuadraticEaseInOut(),
            Children =
            {
                new KeyFrame
                {
                    Setters =
                    {
                        new Setter(Button.BackgroundProperty, new SolidColorBrush(Color.Parse("#FF0055AA")))
                    },
                    Cue = new Cue(0d)
                },
                new KeyFrame
                {
                    Setters =
                    {
                        new Setter(Button.BackgroundProperty, new SolidColorBrush(Color.Parse("#FF007ACC")))
                    },
                    Cue = new Cue(1d)
                }
            }
        };

        animation.RunAsync(this);
    }

    private void OnPointerLeave(object? sender, Avalonia.Input.PointerEventArgs e)
    {
        var animation = new Animation
        {
            Duration = TimeSpan.FromSeconds(0.3),
            Easing = new QuadraticEaseInOut(),
            Children =
            {
                new KeyFrame
                {
                    Setters =
                    {
                        new Setter(Button.BackgroundProperty, new SolidColorBrush(Color.Parse("#FF007ACC")))
                    },
                    Cue = new Cue(0d)
                },
                new KeyFrame
                {
                    Setters =
                    {
                        new Setter(Button.BackgroundProperty, new SolidColorBrush(Color.Parse("#FF0055AA")))
                    },
                    Cue = new Cue(1d)
                }
            }
        };

        animation.RunAsync(this);
    }
}
