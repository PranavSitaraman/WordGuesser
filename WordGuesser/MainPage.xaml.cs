using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WordGuesser
{
    public partial class MainPage : ContentPage
    {
        string word = "HELLO";
        public MainPage()
        {
            InitializeComponent();
        }
        int yes = 0;
        string text;
        void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            text = e.NewTextValue.ToUpper();
            if (text.Equals(word)) yes = 1;
            else if (text.Length < 5) yes = 2;
            else yes = 0;
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (yes == 1)
            {
                var entry = new Entry
                {
                    Placeholder = "Word!",
                    Keyboard = Keyboard.Text,
                    PlaceholderColor = Color.LightBlue,
                    TextTransform = TextTransform.Uppercase,
                    MaxLength = 5,
                    IsSpellCheckEnabled = false,
                    IsTextPredictionEnabled = false,
                    TextColor = Color.Navy,
                    BackgroundColor = Color.LightBlue,
                };
                entry.TextChanged += Entry_TextChanged;
                var button = new Button
                {
                    Text = "You got it correct!",
                };
                button.Clicked += Handle_Clicked;
                Color[] colors = new Color[5];
                for (int i = 0; i < 5; i++)
                {
                    colors[i] = Color.LightGray;
                }
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (text[j] == word[i] && colors[j] == Color.LightGray)
                        {
                            colors[j] = Color.Goldenrod;
                            break;
                        }
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    if (text[i] == word[i])
                    {
                        colors[i] = Color.PaleGreen;
                    }
                }
                Content = new StackLayout
                {
                    Padding = 10,
                    Children =
                    {
                        new Frame
                        {
                            BackgroundColor=Color.DeepPink,
                            Padding= new Thickness(24),
                            CornerRadius=0,
                            Content = new StackLayout
                            {
                                Children =
                                {
                                    new Label
                                    {
                                        Text = "Guess the 5-letter word!",
                                        HorizontalTextAlignment = TextAlignment.Center,
                                        TextColor=Color.White,
                                        FontSize=36
                                    }
                                }
                            }
                        },
                        new StackLayout
                        {
                            Margin= new Thickness(20),
                            Orientation=StackOrientation.Horizontal,
                            HorizontalOptions=LayoutOptions.Center,
                            Spacing=5,
                            Children =
                            {
                                new Frame
                                {
                                    BackgroundColor=colors[0],
                                    Padding= new Thickness(5),
                                    HorizontalOptions=LayoutOptions.Center,
                                    VerticalOptions=LayoutOptions.Center,
                                    WidthRequest=50,
                                    HeightRequest=50,
                                    CornerRadius=5,
                                    Content = new StackLayout
                                    {
                                        Children =
                                        {
                                            new Label
                                            {
                                                WidthRequest=50,
                                                HeightRequest=50,
                                                Text=$"{text[0]}",
                                                HorizontalTextAlignment=TextAlignment.Center,
                                                VerticalTextAlignment = TextAlignment.Center
                                            }
                                        }
                                    }
                                },
                                new Frame
                                {
                                    BackgroundColor=colors[1],
                                    Padding= new Thickness(5),
                                    HorizontalOptions=LayoutOptions.Center,
                                    VerticalOptions=LayoutOptions.Center,
                                    WidthRequest=50,
                                    HeightRequest=50,
                                    CornerRadius=5,
                                    Content = new StackLayout
                                    {
                                        Children =
                                        {
                                            new Label
                                            {
                                                WidthRequest=50,
                                                HeightRequest=50,
                                                Text=$"{text[1]}",
                                                HorizontalTextAlignment=TextAlignment.Center,
                                                VerticalTextAlignment = TextAlignment.Center
                                            }
                                        }
                                    }
                                },
                                new Frame
                                {
                                    BackgroundColor=colors[2],
                                    Padding= new Thickness(5),
                                    HorizontalOptions=LayoutOptions.Center,
                                    VerticalOptions=LayoutOptions.Center,
                                    WidthRequest=50,
                                    HeightRequest=50,
                                    CornerRadius=5,
                                    Content = new StackLayout
                                    {
                                        Children =
                                        {
                                            new Label
                                            {
                                                WidthRequest=50,
                                                HeightRequest=50,
                                                Text=$"{text[2]}",
                                                HorizontalTextAlignment=TextAlignment.Center,
                                                VerticalTextAlignment = TextAlignment.Center
                                            }
                                        }
                                    }
                                },
                                new Frame
                                {
                                    BackgroundColor=colors[3],
                                    Padding= new Thickness(5),
                                    HorizontalOptions=LayoutOptions.Center,
                                    VerticalOptions=LayoutOptions.Center,
                                    WidthRequest=50,
                                    HeightRequest=50,
                                    CornerRadius=5,
                                    Content = new StackLayout
                                    {
                                        Children =
                                        {
                                            new Label
                                            {
                                                WidthRequest=50,
                                                HeightRequest=50,
                                                Text=$"{text[3]}",
                                                HorizontalTextAlignment=TextAlignment.Center,
                                                VerticalTextAlignment = TextAlignment.Center
                                            }
                                        }
                                    }
                                },
                                new Frame
                                {
                                    BackgroundColor=colors[4],
                                    Padding= new Thickness(5),
                                    HorizontalOptions=LayoutOptions.Center,
                                    VerticalOptions=LayoutOptions.Center,
                                    WidthRequest=50,
                                    HeightRequest=50,
                                    CornerRadius=5,
                                    Content = new StackLayout
                                    {
                                        Children =
                                        {
                                            new Label
                                            {
                                                WidthRequest=50,
                                                HeightRequest=50,
                                                Text=$"{text[4]}",
                                                HorizontalTextAlignment=TextAlignment.Center,
                                                VerticalTextAlignment = TextAlignment.Center
                                            }
                                        }
                                    }
                                }
                            }
                        },
                        button,
                        entry
                    }
                };
            }
            else if (yes == 2)
            {
                ((Button)sender).Text = "Remember, the answer is 5 letters long!";
            }
            else
            {
                var entry = new Entry
                {
                    Placeholder = "Word!",
                    Keyboard = Keyboard.Text,
                    PlaceholderColor = Color.LightBlue,
                    TextTransform = TextTransform.Uppercase,
                    MaxLength = 5,
                    IsSpellCheckEnabled = false,
                    IsTextPredictionEnabled = false,
                    TextColor = Color.Navy,
                    BackgroundColor = Color.LightBlue,
                };
                entry.TextChanged += Entry_TextChanged;
                var button = new Button
                {
                    Text = "Sorry, try again!",
                };
                button.Clicked += Handle_Clicked;
                Color[] colors = new Color[5];
                for (int i = 0; i < 5; i++)
                {
                    colors[i] = Color.LightGray;
                }
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (text[j] == word[i] && colors[j] == Color.LightGray)
                        {
                            colors[j] = Color.Goldenrod;
                            break;
                        }
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    if (text[i] == word[i])
                    {
                        colors[i] = Color.PaleGreen;
                    }
                }
                Content = new StackLayout
                {
                    Padding = 10,
                    Children =
                    {
                        new Frame
                        {
                            BackgroundColor=Color.DeepPink,
                            Padding= new Thickness(24),
                            CornerRadius=0,
                            Content = new StackLayout
                            {
                                Children =
                                {
                                    new Label
                                    {
                                        Text = "Guess the 5-letter word!",
                                        HorizontalTextAlignment = TextAlignment.Center,
                                        TextColor=Color.White,
                                        FontSize=36
                                    }
                                }
                            }
                        },
                        new StackLayout
                        {
                            Margin= new Thickness(20),
                            Orientation=StackOrientation.Horizontal,
                            HorizontalOptions=LayoutOptions.Center,
                            Spacing=5,
                            Children =
                            {
                                new Frame
                                {
                                    BackgroundColor=colors[0],
                                    Padding= new Thickness(5),
                                    HorizontalOptions=LayoutOptions.Center,
                                    VerticalOptions=LayoutOptions.Center,
                                    WidthRequest=50,
                                    HeightRequest=50,
                                    CornerRadius=5,
                                    Content = new StackLayout
                                    {
                                        Children =
                                        {
                                            new Label
                                            {
                                                WidthRequest=50,
                                                HeightRequest=50,
                                                Text=$"{text[0]}",
                                                HorizontalTextAlignment=TextAlignment.Center,
                                                VerticalTextAlignment = TextAlignment.Center
                                            }
                                        }
                                    }
                                },
                                new Frame
                                {
                                    BackgroundColor=colors[1],
                                    Padding= new Thickness(5),
                                    HorizontalOptions=LayoutOptions.Center,
                                    VerticalOptions=LayoutOptions.Center,
                                    WidthRequest=50,
                                    HeightRequest=50,
                                    CornerRadius=5,
                                    Content = new StackLayout
                                    {
                                        Children =
                                        {
                                            new Label
                                            {
                                                WidthRequest=50,
                                                HeightRequest=50,
                                                Text=$"{text[1]}",
                                                HorizontalTextAlignment=TextAlignment.Center,
                                                VerticalTextAlignment = TextAlignment.Center
                                            }
                                        }
                                    }
                                },
                                new Frame
                                {
                                    BackgroundColor=colors[2],
                                    Padding= new Thickness(5),
                                    HorizontalOptions=LayoutOptions.Center,
                                    VerticalOptions=LayoutOptions.Center,
                                    WidthRequest=50,
                                    HeightRequest=50,
                                    CornerRadius=5,
                                    Content = new StackLayout
                                    {
                                        Children =
                                        {
                                            new Label
                                            {
                                                WidthRequest=50,
                                                HeightRequest=50,
                                                Text=$"{text[2]}",
                                                HorizontalTextAlignment=TextAlignment.Center,
                                                VerticalTextAlignment = TextAlignment.Center
                                            }
                                        }
                                    }
                                },
                                new Frame
                                {
                                    BackgroundColor=colors[3],
                                    Padding= new Thickness(5),
                                    HorizontalOptions=LayoutOptions.Center,
                                    VerticalOptions=LayoutOptions.Center,
                                    WidthRequest=50,
                                    HeightRequest=50,
                                    CornerRadius=5,
                                    Content = new StackLayout
                                    {
                                        Children =
                                        {
                                            new Label
                                            {
                                                WidthRequest=50,
                                                HeightRequest=50,
                                                Text=$"{text[3]}",
                                                HorizontalTextAlignment=TextAlignment.Center,
                                                VerticalTextAlignment = TextAlignment.Center
                                            }
                                        }
                                    }
                                },
                                new Frame
                                {
                                    BackgroundColor=colors[4],
                                    Padding= new Thickness(5),
                                    HorizontalOptions=LayoutOptions.Center,
                                    VerticalOptions=LayoutOptions.Center,
                                    WidthRequest=50,
                                    HeightRequest=50,
                                    CornerRadius=5,
                                    Content = new StackLayout
                                    {
                                        Children =
                                        {
                                            new Label
                                            {
                                                WidthRequest=50,
                                                HeightRequest=50,
                                                Text=$"{text[4]}",
                                                HorizontalTextAlignment=TextAlignment.Center,
                                                VerticalTextAlignment = TextAlignment.Center
                                            }
                                        }
                                    }
                                }
                            }
                        },
                        button,
                        entry
                    }
                };
            }
        }
    }
}