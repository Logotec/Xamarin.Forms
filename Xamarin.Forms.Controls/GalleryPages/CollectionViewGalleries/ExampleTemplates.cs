﻿using System;
using System.Globalization;

namespace Xamarin.Forms.Controls.GalleryPages.CollectionViewGalleries
{
	internal class ExampleTemplates
	{
		public static DataTemplate PhotoTemplate()
		{
			return new DataTemplate(() =>
			{
				var templateLayout = new Grid
				{
					RowDefinitions = new RowDefinitionCollection { new RowDefinition(), new RowDefinition() },
					WidthRequest = 200,
					HeightRequest = 100
				};

				var image = new Image
				{
					HeightRequest = 100,
					WidthRequest = 100,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center,
					Margin = new Thickness(2, 5, 2, 2),
					AutomationId = "photo"
				};

				image.SetBinding(Image.SourceProperty, new Binding("Image"));

				var caption = new Label
				{
					FontSize = 12,
					HorizontalOptions = LayoutOptions.Fill,
					HorizontalTextAlignment = TextAlignment.Center,
					Margin = new Thickness(2, 0, 2, 2)
				};

				caption.SetBinding(Label.TextProperty, new Binding("Caption"));

				templateLayout.Children.Add(image);
				templateLayout.Children.Add(caption);

				Grid.SetRow(caption, 1);

				return templateLayout;
			});
		}

		public static DataTemplate SnapPointsTemplate()
		{
			return new DataTemplate(() =>
			{
				var templateLayout = new Grid
				{
					RowDefinitions = new RowDefinitionCollection { new RowDefinition(), new RowDefinition { Height = GridLength.Auto } },
					WidthRequest = 280,
					HeightRequest = 310,
				};

				var image = new Image
				{
					Margin = new Thickness(5),
					HeightRequest = 280,
					WidthRequest = 280,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center,
					Aspect = Aspect.AspectFit
				};

				image.SetBinding(Image.SourceProperty, new Binding("Image"));

				var caption = new Label
				{
					FontSize = 12,
					HorizontalOptions = LayoutOptions.Fill,
					BackgroundColor = Color.Aquamarine,
					HorizontalTextAlignment = TextAlignment.Center
				};

				caption.SetBinding(Label.TextProperty, new Binding("Caption"));

				templateLayout.Children.Add(image);
				templateLayout.Children.Add(caption);

				Grid.SetRow(caption, 1);

				return templateLayout;
			});
		}

		public static DataTemplate CarouselXamlTemplate()
		{
			return new DataTemplate(() =>
			{
				return new CarouselViewGalleries.ExampleTemplateCarousel();
			});
		}

		public static DataTemplate CarouselTemplate()
		{
			return new DataTemplate(() =>
			{
				var grid = new Grid
				{
					BackgroundColor = Color.LightBlue,
					RowDefinitions = new RowDefinitionCollection
					{
						new RowDefinition(),
						new RowDefinition { Height = GridLength.Auto }
					}
				};

				var image = new Image
				{
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center,
					Aspect = Aspect.AspectFill
				};

				image.SetBinding(Image.SourceProperty, new Binding("Image"));

				var caption = new Button
				{
					BackgroundColor = Color.Gray,
					HorizontalOptions = LayoutOptions.Fill,
					Margin = new Thickness(5)
				};

				caption.SetBinding(Button.TextProperty, new Binding("Caption"));
				caption.Clicked += (sender, e) =>
				{
					App.Current.MainPage.DisplayAlert("Button works", (sender as Button).Text, "Ok");
				};

				grid.Children.Add(image);
				grid.Children.Add(caption);

				Grid.SetRow(caption, 1);

				var frame = new Frame
				{
					Padding = new Thickness(5),
					Content = grid
				};

				return frame;
			});
		}

		public static DataTemplate ScrollToIndexTemplate()
		{
			return new DataTemplate(() =>
			{
				var templateLayout = new Grid
				{
					BackgroundColor = Color.Bisque,

					RowDefinitions = new RowDefinitionCollection
						{ new RowDefinition(), new RowDefinition { Height = GridLength.Auto } },
					WidthRequest = 100,
					HeightRequest = 140
				};

				var image = new Image
				{
					Margin = new Thickness(5),
					HeightRequest = 100,
					WidthRequest = 100,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center,
					Aspect = Aspect.AspectFit
				};

				image.SetBinding(Image.SourceProperty, new Binding("Image"));

				var caption = new Label
				{
					HorizontalOptions = LayoutOptions.Fill,
					HorizontalTextAlignment = TextAlignment.Center,
					HeightRequest = 40,
					WidthRequest = 100,
					BackgroundColor = Color.Crimson,
					Text = "Caption"
				};

				caption.SetBinding(Label.TextProperty, new Binding("Index", stringFormat: "Index {0}"));

				templateLayout.Children.Add(image);
				templateLayout.Children.Add(caption);

				Grid.SetRow(caption, 1);

				return templateLayout;
			});
		}

		public static DataTemplate ScrollToItemTemplate()
		{
			return new DataTemplate(() =>
			{
				var templateLayout = new Grid
				{
					BackgroundColor = Color.Bisque,

					RowDefinitions = new RowDefinitionCollection { new RowDefinition(), new RowDefinition { Height = GridLength.Auto } },
					WidthRequest = 100,
					HeightRequest = 140
				};

				var image = new Image
				{
					Margin = new Thickness(5),
					HeightRequest = 100,
					WidthRequest = 100,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center,
					Aspect = Aspect.AspectFit
				};

				image.SetBinding(Image.SourceProperty, new Binding("Image"));

				var caption = new Label
				{
					HorizontalOptions = LayoutOptions.Fill,
					HorizontalTextAlignment = TextAlignment.Center,
					HeightRequest = 40,
					WidthRequest = 100,
					BackgroundColor = Color.Crimson,
					Text = "Caption"
				};

				caption.SetBinding(Label.TextProperty, new Binding("Date", stringFormat: "{0:d}"));

				templateLayout.Children.Add(image);
				templateLayout.Children.Add(caption);

				Grid.SetRow(caption, 1);

				return templateLayout;
			});
		}

		public static DataTemplate PropagationTemplate()
		{
			return new DataTemplate(() =>
			{
				var templateLayout = new Grid
				{
					BackgroundColor = Color.Bisque,
					RowDefinitions = new RowDefinitionCollection { new RowDefinition { Height = GridLength.Auto } },
					WidthRequest = 100,
					HeightRequest = 140
				};

				var buttonLayout = new StackLayout { Orientation = StackOrientation.Horizontal };

				var button1 = new Button
				{
					Margin = new Thickness(5),
					Text = "Button 1"
				};

				var button2 = new Button
				{
					Margin = new Thickness(5),
					Text = "Button 2"
				};

				var button3 = new Button
				{
					Margin = new Thickness(5),
					Text = "Button 3"
				};

				buttonLayout.Children.Add(button1);
				buttonLayout.Children.Add(button2);
				buttonLayout.Children.Add(button3);

				templateLayout.Children.Add(buttonLayout);

				return templateLayout;
			});
		}

		public static DataTemplate VariableSizeTemplate()
		{
			var indexHeightConverter = new IndexRequestConverter(3, 50, 150);
			var indexWidthConverter = new IndexRequestConverter(3, 100, 300);
			var colorConverter = new IndexColorConverter();

			return new DataTemplate(() =>
			{
				var layout = new Frame();

				layout.SetBinding(VisualElement.HeightRequestProperty, new Binding("Index", converter: indexHeightConverter));
				layout.SetBinding(VisualElement.WidthRequestProperty, new Binding("Index", converter: indexWidthConverter));
				layout.SetBinding(VisualElement.BackgroundColorProperty, new Binding("Index", converter: colorConverter));

				var image = new Image
				{
					Aspect = Aspect.AspectFit
				};

				image.SetBinding(VisualElement.HeightRequestProperty, new Binding("Index", converter: indexHeightConverter));
				image.SetBinding(VisualElement.WidthRequestProperty, new Binding("Index", converter: indexWidthConverter));

				image.SetBinding(Image.SourceProperty, new Binding("Image"));

				layout.Content = image;

				return layout;
			});
		}

		public static DataTemplate DynamicTextTemplate()
		{
			return new DataTemplate(() =>
			{
				var templateLayout = new Grid
				{
					RowDefinitions = new RowDefinitionCollection
					{
						new RowDefinition() { Height = GridLength.Auto },
						new RowDefinition() { Height = GridLength.Auto },
						new RowDefinition() { Height = GridLength.Auto }
					},
					BackgroundColor = Color.LightGoldenrodYellow,
					Margin = 10
				};

				var frame = new Frame
				{
					HeightRequest = 50,
					WidthRequest = 200,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center,
					Margin = new Thickness(2, 5, 2, 2),
					AutomationId = "frame",
					BackgroundColor = Color.CadetBlue
				};

				var date = new Label
				{
					FontSize = 12,
					HorizontalOptions = LayoutOptions.Fill,
					VerticalOptions = LayoutOptions.Fill,
					HorizontalTextAlignment = TextAlignment.Center,
					VerticalTextAlignment = TextAlignment.Center,
					Margin = new Thickness(2, 0, 2, 2)
				};

				date.SetBinding(Label.TextProperty, new Binding("Date"));

				frame.Content = date;

				var caption = new Label
				{
					FontSize = 12,
					HorizontalOptions = LayoutOptions.Fill,
					HorizontalTextAlignment = TextAlignment.Center,
					Margin = new Thickness(2, 0, 2, 2),
					LineBreakMode = LineBreakMode.WordWrap,
					MaxLines = 10
				};

				caption.SetBinding(Label.TextProperty, new Binding("Caption"));

				var more = new Button { Text = "More Text" };
				var less = new Button { Text = "Less Text" };

				var buttonLayout = new StackLayout
				{
					Children = { more, less },
					Orientation = StackOrientation.Horizontal,
					HorizontalOptions = LayoutOptions.Center					
				};

				more.SetBinding(Button.CommandProperty, new Binding("MoreCommand"));
				less.SetBinding(Button.CommandProperty, new Binding("LessCommand"));

				templateLayout.Children.Add(frame);
				templateLayout.Children.Add(caption);
				templateLayout.Children.Add(buttonLayout);

				Grid.SetRow(buttonLayout, 1);
				Grid.SetRow(caption, 2);

				var rootLayout = new StackLayout
				{
					Children = { templateLayout }
				};

				return rootLayout;
			});
		}

		static void More_Clicked(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		class IndexRequestConverter : IValueConverter
		{
			readonly int _cutoff;
			readonly int _lowValue;
			readonly int _highValue;

			public IndexRequestConverter(int cutoff, int lowValue, int highValue)
			{
				_cutoff = cutoff;
				_lowValue = lowValue;
				_highValue = highValue;
			}

			public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
			{
				var index = (int)value;

				return index < _cutoff ? _lowValue : (object)_highValue;
			}

			public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
		}

		class IndexColorConverter : IValueConverter
		{
			Color[] _colors = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Orange, Color.BlanchedAlmond };

			public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
			{
				var index = (int)value;
				return _colors[index % _colors.Length];
			}

			public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
		}
	}
}
