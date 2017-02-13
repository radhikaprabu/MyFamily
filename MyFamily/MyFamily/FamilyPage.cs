using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace MyFamily
{
    class FamilyPage : ContentPage
    {
        public FamilyPage()
        {
            double fontsize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            
            StackLayout stackLayout = new StackLayout

            {
                Spacing = 3.0,
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    new Label
                    {
                        Text = "Meet My Family" + Environment.NewLine + Environment.NewLine,
                        FontAttributes = FontAttributes.Bold,
                        FontSize = fontsize
                    },
                    new Label
                    {
                        FormattedText = new FormattedString
                        {
                            Spans =
                            {
                                new Span
                                {
                                Text = "I am "
                                },
                                new Span
                                {
                                Text = "Radhika.",
                                FontAttributes = FontAttributes.Bold,
                                FontSize = fontsize,
                                ForegroundColor = Color.Silver
                                }
                            }
                        }
                    },
                    new Label
                    {
                        FormattedText = new FormattedString
                        {
                            Spans =
                            {
                                new Span
                                {
                                    Text = "My husband is "
                                },
                                new Span
                                {
                                    Text = "Prabu." + Environment.NewLine + Environment.NewLine,
                                    FontAttributes = FontAttributes.Bold,
                                    FontSize = fontsize,
                                    ForegroundColor = Color.Orange
                                },
                                new Span
                                {
                                    Text = "He is an Application Architect"
                                }
                            }
                        }
                    },
                    new Label
                    {
                        FormattedText = new FormattedString
                        {
                            Spans =
                            {
                                new Span
                                {
                                    Text = "My daughter is "
                                },
                                new Span
                                {
                                    Text = "Aditi." + Environment.NewLine + Environment.NewLine,
                                    FontAttributes = FontAttributes.Bold,
                                    FontSize = fontsize,
                                    ForegroundColor = Color.Yellow
                                },
                                new Span
                                {
                                    Text = "She is in 8th Grade"
                                }
                            }
                        },
                    },
                    new Label
                    {
                        FormattedText = new FormattedString
                        {
                            Spans =
                            {
                                new Span
                                {
                                    Text = "My son is "
                                },
                                new Span
                                {
                                    Text = "Abishek." + Environment.NewLine + Environment.NewLine,
                                    FontAttributes = FontAttributes.Bold,
                                    FontSize = fontsize,
                                    ForegroundColor = Color.Red
                                },
                                new Span
                                {
                                    Text = "He is in 3rd grade."
                                }
                            }
                        }
                    },
                },
          
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.Blue
            };
            Content = new ScrollView
            {
                Content = stackLayout
            };
        }
    }
}
