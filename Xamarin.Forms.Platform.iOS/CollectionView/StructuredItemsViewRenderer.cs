﻿using System.ComponentModel;

namespace Xamarin.Forms.Platform.iOS
{
	public class StructuredItemsViewRenderer : ItemsViewRenderer
	{
		StructuredItemsView StructuredItemsView => (StructuredItemsView)Element;
		StructuredItemsViewController StructuredItemsViewController => (StructuredItemsViewController)ItemsViewController;

		protected override ItemsViewController CreateController(ItemsView itemsView, ItemsViewLayout layout)
		{
			return new StructuredItemsViewController(itemsView as StructuredItemsView, layout);
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs changedProperty)
		{
			base.OnElementPropertyChanged(sender, changedProperty);

			if (changedProperty.IsOneOf(StructuredItemsView.HeaderProperty, StructuredItemsView.HeaderTemplateProperty))
			{
				StructuredItemsViewController.UpdateHeaderView();
			}
			else if (changedProperty.IsOneOf(StructuredItemsView.FooterProperty, StructuredItemsView.FooterTemplateProperty))
			{
				StructuredItemsViewController.UpdateFooterView();
			}
		}

		protected override void SetUpNewElement(ItemsView newElement)
		{
			base.SetUpNewElement(newElement);

			if (newElement == null)
			{
				return;
			}

			StructuredItemsViewController.UpdateFooterView();
			StructuredItemsViewController.UpdateHeaderView();
		}
	}
}