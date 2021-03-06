﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WorkSphere.Controls
{
    public sealed class RoundedBoxView : BoxView
    {
        public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create<RoundedBoxView, double>(p => p.CornerRadius, 0);
        public double CornerRadius
        {
            get { return (double)base.GetValue(CornerRadiusProperty); }
            set { base.SetValue(CornerRadiusProperty, value); }
        }
        
        /// <summary>
        /// Thickness property of border
        /// </summary>
        public static readonly BindableProperty BorderThicknessProperty = BindableProperty.Create<RoundedBoxView, int>(p => p.BorderThickness, 0);

        /// <summary>
        /// Border thickness of circle image
        /// </summary>
        public int BorderThickness
        {
            get { return (int)GetValue(BorderThicknessProperty); }
            set { SetValue(BorderThicknessProperty, value); }
        }

        /// <summary>
        /// Color property of border
        /// </summary>
        public static readonly BindableProperty BorderColorProperty = BindableProperty.Create<RoundedBoxView, Color>(p => p.BorderColor, Color.White);

        /// <summary>
        /// Border Color of circle image
        /// </summary>
        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }
    }
}
