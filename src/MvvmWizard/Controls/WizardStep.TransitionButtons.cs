﻿// ReSharper disable StyleCop.SA1600
namespace MvvmWizard.Controls
{
    using System.Windows;
    using System.Windows.Media;

    /// <summary>
    /// The wizard step.
    /// </summary>
    public partial class WizardStep
    {
        public static readonly DependencyProperty BackButtonTooltipProperty = DependencyProperty.Register(nameof(BackButtonTooltip), typeof(object), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonTooltipProperty = DependencyProperty.Register(nameof(SkipButtonTooltip), typeof(object), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonTooltipProperty = DependencyProperty.Register(nameof(ForwardButtonTooltip), typeof(object), typeof(WizardStep));
        public static readonly DependencyProperty HelpButtonTooltipProperty = DependencyProperty.Register(nameof(HelpButtonTooltip), typeof(object), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonVisibilityProperty = DependencyProperty.Register(nameof(BackButtonVisibility), typeof(Visibility), typeof(WizardStep), new PropertyMetadata(Visibility.Visible));
        public static readonly DependencyProperty SkipButtonVisibilityProperty = DependencyProperty.Register(nameof(SkipButtonVisibility), typeof(Visibility), typeof(WizardStep), new PropertyMetadata(Visibility.Visible));
        public static readonly DependencyProperty ForwardButtonVisibilityProperty = DependencyProperty.Register(nameof(ForwardButtonVisibility), typeof(Visibility), typeof(WizardStep), new PropertyMetadata(Visibility.Visible));
        public static readonly DependencyProperty HelpButtonVisibilityProperty = DependencyProperty.Register(nameof(HelpButtonVisibility), typeof(Visibility), typeof(WizardStep), new PropertyMetadata(Visibility.Visible));

        public static readonly DependencyProperty BackButtonIsEnabledProperty = DependencyProperty.Register(nameof(BackButtonIsEnabled), typeof(bool), typeof(WizardStep), new PropertyMetadata(true));
        public static readonly DependencyProperty SkipButtonIsEnabledProperty = DependencyProperty.Register(nameof(SkipButtonIsEnabled), typeof(bool), typeof(WizardStep), new PropertyMetadata(true));
        public static readonly DependencyProperty ForwardButtonIsEnabledProperty = DependencyProperty.Register(nameof(ForwardButtonIsEnabled), typeof(bool), typeof(WizardStep), new PropertyMetadata(true));
        public static readonly DependencyProperty HelpButtonIsEnabledProperty = DependencyProperty.Register(nameof(HelpButtonIsEnabled), typeof(bool), typeof(WizardStep), new PropertyMetadata(true));

        public static readonly DependencyProperty BackButtonTitleProperty = DependencyProperty.Register(nameof(BackButtonTitle), typeof(string), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonTitleProperty = DependencyProperty.Register(nameof(SkipButtonTitle), typeof(string), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonTitleProperty = DependencyProperty.Register(nameof(ForwardButtonTitle), typeof(string), typeof(WizardStep));
        public static readonly DependencyProperty HelpButtonTitleProperty = DependencyProperty.Register(nameof(HelpButtonTitle), typeof(string), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonIconProperty = DependencyProperty.Register(nameof(BackButtonIcon), typeof(object), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonIconProperty = DependencyProperty.Register(nameof(SkipButtonIcon), typeof(object), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonIconProperty = DependencyProperty.Register(nameof(ForwardButtonIcon), typeof(object), typeof(WizardStep));
        public static readonly DependencyProperty HelpButtonIconProperty = DependencyProperty.Register(nameof(HelpButtonIcon), typeof(object), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonForegroundProperty = DependencyProperty.Register(nameof(BackButtonForeground), typeof(Brush), typeof(WizardStep), new PropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty SkipButtonForegroundProperty = DependencyProperty.Register(nameof(SkipButtonForeground), typeof(Brush), typeof(WizardStep), new PropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty ForwardButtonForegroundProperty = DependencyProperty.Register(nameof(ForwardButtonForeground), typeof(Brush), typeof(WizardStep), new PropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty HelpButtonForegroundProperty = DependencyProperty.Register(nameof(HelpButtonForeground), typeof(Brush), typeof(WizardStep), new PropertyMetadata(Brushes.Black));

        public static readonly DependencyProperty BackButtonBackgroundProperty = DependencyProperty.Register(nameof(BackButtonBackground), typeof(Brush), typeof(WizardStep), new PropertyMetadata(Brushes.Transparent));
        public static readonly DependencyProperty SkipButtonBackgroundProperty = DependencyProperty.Register(nameof(SkipButtonBackground), typeof(Brush), typeof(WizardStep), new PropertyMetadata(Brushes.Transparent));
        public static readonly DependencyProperty ForwardButtonBackgroundProperty = DependencyProperty.Register(nameof(ForwardButtonBackground), typeof(Brush), typeof(WizardStep), new PropertyMetadata(Brushes.Transparent));
        public static readonly DependencyProperty HelpButtonBackgroundProperty = DependencyProperty.Register(nameof(HelpButtonBackground), typeof(Brush), typeof(WizardStep), new PropertyMetadata(Brushes.Transparent));

        public static readonly DependencyProperty BackButtonMouseMouseOverBackgroundProperty = DependencyProperty.Register(nameof(BackButtonMouseMouseOverBackground), typeof(Brush), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonMouseMouseOverBackgroundProperty = DependencyProperty.Register(nameof(SkipButtonMouseMouseOverBackground), typeof(Brush), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonMouseMouseOverBackgroundProperty = DependencyProperty.Register(nameof(ForwardButtonMouseMouseOverBackground), typeof(Brush), typeof(WizardStep));
        public static readonly DependencyProperty HelpButtonMouseMouseOverBackgroundProperty = DependencyProperty.Register(nameof(HelpButtonMouseMouseOverBackground), typeof(Brush), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonBorderBrushProperty = DependencyProperty.Register(nameof(BackButtonBorderBrush), typeof(Brush), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonBorderBrushProperty = DependencyProperty.Register(nameof(SkipButtonBorderBrush), typeof(Brush), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonBorderBrushProperty = DependencyProperty.Register(nameof(ForwardButtonBorderBrush), typeof(Brush), typeof(WizardStep));
        public static readonly DependencyProperty HelpButtonBorderBrushProperty = DependencyProperty.Register(nameof(HelpButtonBorderBrush), typeof(Brush), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonBorderThicknessProperty = DependencyProperty.Register(nameof(BackButtonBorderThickness), typeof(Thickness), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonBorderThicknessProperty = DependencyProperty.Register(nameof(SkipButtonBorderThickness), typeof(Thickness), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonBorderThicknessProperty = DependencyProperty.Register(nameof(ForwardButtonBorderThickness), typeof(Thickness), typeof(WizardStep));
        public static readonly DependencyProperty HelpButtonBorderThicknessProperty = DependencyProperty.Register(nameof(HelpButtonBorderThickness), typeof(Thickness), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonMinWidthProperty = DependencyProperty.Register(nameof(BackButtonMinWidth), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(0.0));
        public static readonly DependencyProperty SkipButtonMinWidthProperty = DependencyProperty.Register(nameof(SkipButtonMinWidth), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(0.0));
        public static readonly DependencyProperty ForwardButtonMinWidthProperty = DependencyProperty.Register(nameof(ForwardButtonMinWidth), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(0.0));
        public static readonly DependencyProperty HelpButtonMinWidthProperty = DependencyProperty.Register(nameof(HelpButtonMinWidth), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(0.0));

        public static readonly DependencyProperty BackButtonMinHeightProperty = DependencyProperty.Register(nameof(BackButtonMinHeight), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(0.0));
        public static readonly DependencyProperty SkipButtonMinHeightProperty = DependencyProperty.Register(nameof(SkipButtonMinHeight), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(0.0));
        public static readonly DependencyProperty ForwardButtonMinHeightProperty = DependencyProperty.Register(nameof(ForwardButtonMinHeight), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(0.0));
        public static readonly DependencyProperty HelpButtonMinHeightProperty = DependencyProperty.Register(nameof(HelpButtonMinHeight), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(0.0));

        public static readonly DependencyProperty BackButtonWidthProperty = DependencyProperty.Register(nameof(BackButtonWidth), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(double.NaN));
        public static readonly DependencyProperty SkipButtonWidthProperty = DependencyProperty.Register(nameof(SkipButtonWidth), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(double.NaN));
        public static readonly DependencyProperty ForwardButtonWidthProperty = DependencyProperty.Register(nameof(ForwardButtonWidth), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(double.NaN));
        public static readonly DependencyProperty HelpButtonWidthProperty = DependencyProperty.Register(nameof(HelpButtonWidth), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(double.NaN));

        public static readonly DependencyProperty BackButtonHeightProperty = DependencyProperty.Register(nameof(BackButtonHeight), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(double.NaN));
        public static readonly DependencyProperty SkipButtonHeightProperty = DependencyProperty.Register(nameof(SkipButtonHeight), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(double.NaN));
        public static readonly DependencyProperty ForwardButtonHeightProperty = DependencyProperty.Register(nameof(ForwardButtonHeight), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(double.NaN));
        public static readonly DependencyProperty HelpButtonHeightProperty = DependencyProperty.Register(nameof(HelpButtonHeight), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(double.NaN));

        public static readonly DependencyProperty BackButtonMaxWidthProperty = DependencyProperty.Register(nameof(BackButtonMaxWidth), typeof(double), typeof(WizardStep), new PropertyMetadata(double.PositiveInfinity));
        public static readonly DependencyProperty SkipButtonMaxWidthProperty = DependencyProperty.Register(nameof(SkipButtonMaxWidth), typeof(double), typeof(WizardStep), new PropertyMetadata(double.PositiveInfinity));
        public static readonly DependencyProperty ForwardButtonMaxWidthProperty = DependencyProperty.Register(nameof(ForwardButtonMaxWidth), typeof(double), typeof(WizardStep), new PropertyMetadata(double.PositiveInfinity));
        public static readonly DependencyProperty HelpButtonMaxWidthProperty = DependencyProperty.Register(nameof(HelpButtonMaxWidth), typeof(double), typeof(WizardStep), new PropertyMetadata(double.PositiveInfinity));

        public static readonly DependencyProperty BackButtonMaxHeightProperty = DependencyProperty.Register(nameof(BackButtonMaxHeight), typeof(double), typeof(WizardStep), new PropertyMetadata(double.PositiveInfinity));
        public static readonly DependencyProperty SkipButtonMaxHeightProperty = DependencyProperty.Register(nameof(SkipButtonMaxHeight), typeof(double), typeof(WizardStep), new PropertyMetadata(double.PositiveInfinity));
        public static readonly DependencyProperty ForwardButtonMaxHeightProperty = DependencyProperty.Register(nameof(ForwardButtonMaxHeight), typeof(double), typeof(WizardStep), new PropertyMetadata(double.PositiveInfinity));
        public static readonly DependencyProperty HelpButtonMaxHeightProperty = DependencyProperty.Register(nameof(HelpButtonMaxHeight), typeof(double), typeof(WizardStep), new PropertyMetadata(double.PositiveInfinity));

        public static readonly DependencyProperty BackButtonMarginProperty = DependencyProperty.Register(nameof(BackButtonMargin), typeof(Thickness), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonMarginProperty = DependencyProperty.Register(nameof(SkipButtonMargin), typeof(Thickness), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonMarginProperty = DependencyProperty.Register(nameof(ForwardButtonMargin), typeof(Thickness), typeof(WizardStep));
        public static readonly DependencyProperty HelpButtonMarginProperty = DependencyProperty.Register(nameof(HelpButtonMargin), typeof(Thickness), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonCornerRadiusProperty = DependencyProperty.Register(nameof(BackButtonCornerRadius), typeof(CornerRadius), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonCornerRadiusProperty = DependencyProperty.Register(nameof(SkipButtonCornerRadius), typeof(CornerRadius), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonCornerRadiusProperty = DependencyProperty.Register(nameof(ForwardButtonCornerRadius), typeof(CornerRadius), typeof(WizardStep));
        public static readonly DependencyProperty HelpButtonCornerRadiusProperty = DependencyProperty.Register(nameof(HelpButtonCornerRadius), typeof(CornerRadius), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonHorizontalContentAlignmentProperty = DependencyProperty.Register(nameof(BackButtonHorizontalContentAlignment), typeof(HorizontalAlignment), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonHorizontalContentAlignmentProperty = DependencyProperty.Register(nameof(SkipButtonHorizontalContentAlignment), typeof(HorizontalAlignment), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonHorizontalContentAlignmentProperty = DependencyProperty.Register(nameof(ForwardButtonHorizontalContentAlignment), typeof(HorizontalAlignment), typeof(WizardStep));
        public static readonly DependencyProperty HelpButtonHorizontalContentAlignmentProperty = DependencyProperty.Register(nameof(HelpButtonHorizontalContentAlignment), typeof(HorizontalAlignment), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonVerticalContentAlignmentProperty = DependencyProperty.Register(nameof(BackButtonVerticalContentAlignment), typeof(VerticalAlignment), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonVerticalContentAlignmentProperty = DependencyProperty.Register(nameof(SkipButtonVerticalContentAlignment), typeof(VerticalAlignment), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonVerticalContentAlignmentProperty = DependencyProperty.Register(nameof(ForwardButtonVerticalContentAlignment), typeof(VerticalAlignment), typeof(WizardStep));
        public static readonly DependencyProperty HelpButtonVerticalContentAlignmentProperty = DependencyProperty.Register(nameof(HelpButtonVerticalContentAlignment), typeof(VerticalAlignment), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonFontSizeProperty = DependencyProperty.Register(nameof(BackButtonFontSize), typeof(double), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonFontSizeProperty = DependencyProperty.Register(nameof(SkipButtonFontSize), typeof(double), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonFontSizeProperty = DependencyProperty.Register(nameof(ForwardButtonFontSize), typeof(double), typeof(WizardStep));
        public static readonly DependencyProperty HelpButtonFontSizeProperty = DependencyProperty.Register(nameof(HelpButtonFontSize), typeof(double), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonFontWeightProperty = DependencyProperty.Register(nameof(BackButtonFontWeight), typeof(FontWeight), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonFontWeightProperty = DependencyProperty.Register(nameof(SkipButtonFontWeight), typeof(FontWeight), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonFontWeightProperty = DependencyProperty.Register(nameof(ForwardButtonFontWeight), typeof(FontWeight), typeof(WizardStep));
        public static readonly DependencyProperty HelpButtonFontWeightProperty = DependencyProperty.Register(nameof(HelpButtonFontWeight), typeof(FontWeight), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonFontStyleProperty = DependencyProperty.Register(nameof(BackButtonFontStyle), typeof(FontStyle), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonFontStyleProperty = DependencyProperty.Register(nameof(SkipButtonFontStyle), typeof(FontStyle), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonFontStyleProperty = DependencyProperty.Register(nameof(ForwardButtonFontStyle), typeof(FontStyle), typeof(WizardStep));
        public static readonly DependencyProperty HelpButtonFontStyleProperty = DependencyProperty.Register(nameof(HelpButtonFontStyle), typeof(FontStyle), typeof(WizardStep));

        /* Tooltip */
        public object BackButtonTooltip
        {
            get { return this.GetValue(BackButtonTooltipProperty); }
            set { this.SetValue(BackButtonTooltipProperty, value); }
        }

        public object SkipButtonTooltip
        {
            get { return this.GetValue(SkipButtonTooltipProperty); }
            set { this.SetValue(SkipButtonTooltipProperty, value); }
        }

        public object ForwardButtonTooltip
        {
            get { return this.GetValue(ForwardButtonTooltipProperty); }
            set { this.SetValue(ForwardButtonTooltipProperty, value); }
        }

        public object HelpButtonTooltip
        {
            get { return this.GetValue(HelpButtonTooltipProperty); }
            set { this.SetValue(HelpButtonTooltipProperty, value); }
        }

        /* Visibility */
        public Visibility BackButtonVisibility
        {
            get { return (Visibility)this.GetValue(BackButtonVisibilityProperty); }
            set { this.SetValue(BackButtonVisibilityProperty, value); }
        }

        public Visibility SkipButtonVisibility
        {
            get { return (Visibility)this.GetValue(SkipButtonVisibilityProperty); }
            set { this.SetValue(SkipButtonVisibilityProperty, value); }
        }

        public Visibility ForwardButtonVisibility
        {
            get { return (Visibility)this.GetValue(ForwardButtonVisibilityProperty); }
            set { this.SetValue(ForwardButtonVisibilityProperty, value); }
        }

        public Visibility HelpButtonVisibility
        {
            get { return (Visibility)this.GetValue(HelpButtonVisibilityProperty); }
            set { this.SetValue(HelpButtonVisibilityProperty, value); }
        }

        /* IsEnabled */
        public bool BackButtonIsEnabled
        {
            get { return (bool)this.GetValue(BackButtonIsEnabledProperty); }
            set { this.SetValue(BackButtonIsEnabledProperty, value); }
        }

        public bool SkipButtonIsEnabled
        {
            get { return (bool)this.GetValue(SkipButtonIsEnabledProperty); }
            set { this.SetValue(SkipButtonIsEnabledProperty, value); }
        }

        public bool ForwardButtonIsEnabled
        {
            get { return (bool)this.GetValue(ForwardButtonIsEnabledProperty); }
            set { this.SetValue(ForwardButtonIsEnabledProperty, value); }
        }

        public bool HelpButtonIsEnabled
        {
            get { return (bool)this.GetValue(HelpButtonIsEnabledProperty); }
            set { this.SetValue(HelpButtonIsEnabledProperty, value); }
        }

        /* Title */
        public string BackButtonTitle
        {
            get { return (string)this.GetValue(BackButtonTitleProperty); }
            set { this.SetValue(BackButtonTitleProperty, value); }
        }

        public string SkipButtonTitle
        {
            get { return (string)this.GetValue(SkipButtonTitleProperty); }
            set { this.SetValue(SkipButtonTitleProperty, value); }
        }

        public string ForwardButtonTitle
        {
            get { return (string)this.GetValue(ForwardButtonTitleProperty); }
            set { this.SetValue(ForwardButtonTitleProperty, value); }
        }

        public string HelpButtonTitle
        {
            get { return (string)this.GetValue(HelpButtonTitleProperty); }
            set { this.SetValue(HelpButtonTitleProperty, value); }
        }

        /* Icon */
        public object BackButtonIcon
        {
            get { return this.GetValue(BackButtonIconProperty); }
            set { this.SetValue(BackButtonIconProperty, value); }
        }

        public object SkipButtonIcon
        {
            get { return this.GetValue(SkipButtonIconProperty); }
            set { this.SetValue(SkipButtonIconProperty, value); }
        }

        public object ForwardButtonIcon
        {
            get { return this.GetValue(ForwardButtonIconProperty); }
            set { this.SetValue(ForwardButtonIconProperty, value); }
        }

        public object HelpButtonIcon
        {
            get { return this.GetValue(HelpButtonIconProperty); }
            set { this.SetValue(HelpButtonIconProperty, value); }
        }

        /* Foreground */
        public Brush BackButtonForeground
        {
            get { return (Brush)this.GetValue(BackButtonForegroundProperty); }
            set { this.SetValue(BackButtonForegroundProperty, value); }
        }

        public Brush SkipButtonForeground
        {
            get { return (Brush)this.GetValue(SkipButtonForegroundProperty); }
            set { this.SetValue(SkipButtonForegroundProperty, value); }
        }

        public Brush ForwardButtonForeground
        {
            get { return (Brush)this.GetValue(ForwardButtonForegroundProperty); }
            set { this.SetValue(ForwardButtonForegroundProperty, value); }
        }

        public Brush HelpButtonForeground
        {
            get { return (Brush)this.GetValue(HelpButtonForegroundProperty); }
            set { this.SetValue(HelpButtonForegroundProperty, value); }
        }

        /* Background */
        public Brush BackButtonBackground
        {
            get { return (Brush)this.GetValue(BackButtonBackgroundProperty); }
            set { this.SetValue(BackButtonBackgroundProperty, value); }
        }

        public Brush SkipButtonBackground
        {
            get { return (Brush)this.GetValue(SkipButtonBackgroundProperty); }
            set { this.SetValue(SkipButtonBackgroundProperty, value); }
        }

        public Brush ForwardButtonBackground
        {
            get { return (Brush)this.GetValue(ForwardButtonBackgroundProperty); }
            set { this.SetValue(ForwardButtonBackgroundProperty, value); }
        }

        public Brush HelpButtonBackground
        {
            get { return (Brush)this.GetValue(HelpButtonBackgroundProperty); }
            set { this.SetValue(HelpButtonBackgroundProperty, value); }
        }

        /* Mouse Over Background */
        public Brush BackButtonMouseMouseOverBackground
        {
            get { return (Brush)this.GetValue(BackButtonMouseMouseOverBackgroundProperty); }
            set { this.SetValue(BackButtonMouseMouseOverBackgroundProperty, value); }
        }

        public Brush SkipButtonMouseMouseOverBackground
        {
            get { return (Brush)this.GetValue(SkipButtonMouseMouseOverBackgroundProperty); }
            set { this.SetValue(SkipButtonMouseMouseOverBackgroundProperty, value); }
        }

        public Brush ForwardButtonMouseMouseOverBackground
        {
            get { return (Brush)this.GetValue(ForwardButtonMouseMouseOverBackgroundProperty); }
            set { this.SetValue(ForwardButtonMouseMouseOverBackgroundProperty, value); }
        }

        public Brush HelpButtonMouseMouseOverBackground
        {
            get { return (Brush)this.GetValue(HelpButtonMouseMouseOverBackgroundProperty); }
            set { this.SetValue(HelpButtonMouseMouseOverBackgroundProperty, value); }
        }

        /* Border Brush */
        public Brush BackButtonBorderBrush
        {
            get { return (Brush)this.GetValue(BackButtonBorderBrushProperty); }
            set { this.SetValue(BackButtonBorderBrushProperty, value); }
        }

        public Brush SkipButtonBorderBrush
        {
            get { return (Brush)this.GetValue(SkipButtonBorderBrushProperty); }
            set { this.SetValue(SkipButtonBorderBrushProperty, value); }
        }

        public Brush ForwardButtonBorderBrush
        {
            get { return (Brush)this.GetValue(ForwardButtonBorderBrushProperty); }
            set { this.SetValue(ForwardButtonBorderBrushProperty, value); }
        }

        public Brush HelpButtonBorderBrush
        {
            get { return (Brush)this.GetValue(HelpButtonBorderBrushProperty); }
            set { this.SetValue(HelpButtonBorderBrushProperty, value); }
        }

        /* Border Thickness */
        public Thickness BackButtonBorderThickness
        {
            get { return (Thickness)this.GetValue(BackButtonBorderThicknessProperty); }
            set { this.SetValue(BackButtonBorderThicknessProperty, value); }
        }

        public Thickness SkipButtonBorderThickness
        {
            get { return (Thickness)this.GetValue(SkipButtonBorderThicknessProperty); }
            set { this.SetValue(SkipButtonBorderThicknessProperty, value); }
        }

        public Thickness ForwardButtonBorderThickness
        {
            get { return (Thickness)this.GetValue(ForwardButtonBorderThicknessProperty); }
            set { this.SetValue(ForwardButtonBorderThicknessProperty, value); }
        }

        public Thickness HelpButtonBorderThickness
        {
            get { return (Thickness)this.GetValue(HelpButtonBorderThicknessProperty); }
            set { this.SetValue(HelpButtonBorderThicknessProperty, value); }
        }

        /* Min Width */
        public double BackButtonMinWidth
        {
            get { return (double)this.GetValue(BackButtonMinWidthProperty); }
            set { this.SetValue(BackButtonMinWidthProperty, value); }
        }

        public double SkipButtonMinWidth
        {
            get { return (double)this.GetValue(SkipButtonMinWidthProperty); }
            set { this.SetValue(SkipButtonMinWidthProperty, value); }
        }

        public double ForwardButtonMinWidth
        {
            get { return (double)this.GetValue(ForwardButtonMinWidthProperty); }
            set { this.SetValue(ForwardButtonMinWidthProperty, value); }
        }

        public double HelpButtonMinWidth
        {
            get { return (double)this.GetValue(HelpButtonMinWidthProperty); }
            set { this.SetValue(HelpButtonMinWidthProperty, value); }
        }

        /* Min Height */
        public double BackButtonMinHeight
        {
            get { return (double)this.GetValue(BackButtonMinHeightProperty); }
            set { this.SetValue(BackButtonMinHeightProperty, value); }
        }

        public double SkipButtonMinHeight
        {
            get { return (double)this.GetValue(SkipButtonMinHeightProperty); }
            set { this.SetValue(SkipButtonMinHeightProperty, value); }
        }

        public double ForwardButtonMinHeight
        {
            get { return (double)this.GetValue(ForwardButtonMinHeightProperty); }
            set { this.SetValue(ForwardButtonMinHeightProperty, value); }
        }

        public double HelpButtonMinHeight
        {
            get { return (double)this.GetValue(HelpButtonMinHeightProperty); }
            set { this.SetValue(HelpButtonMinHeightProperty, value); }
        }

        /* Width */
        public double BackButtonWidth
        {
            get { return (double)this.GetValue(BackButtonWidthProperty); }
            set { this.SetValue(BackButtonWidthProperty, value); }
        }

        public double SkipButtonWidth
        {
            get { return (double)this.GetValue(SkipButtonWidthProperty); }
            set { this.SetValue(SkipButtonWidthProperty, value); }
        }

        public double ForwardButtonWidth
        {
            get { return (double)this.GetValue(ForwardButtonWidthProperty); }
            set { this.SetValue(ForwardButtonWidthProperty, value); }
        }

        public double HelpButtonWidth
        {
            get { return (double)this.GetValue(HelpButtonWidthProperty); }
            set { this.SetValue(HelpButtonWidthProperty, value); }
        }

        /* Height */
        public double BackButtonHeight
        {
            get { return (double)this.GetValue(BackButtonHeightProperty); }
            set { this.SetValue(BackButtonHeightProperty, value); }
        }

        public double SkipButtonHeight
        {
            get { return (double)this.GetValue(SkipButtonHeightProperty); }
            set { this.SetValue(SkipButtonHeightProperty, value); }
        }

        public double ForwardButtonHeight
        {
            get { return (double)this.GetValue(ForwardButtonHeightProperty); }
            set { this.SetValue(ForwardButtonHeightProperty, value); }
        }

        public double HelpButtonHeight
        {
            get { return (double)this.GetValue(HelpButtonHeightProperty); }
            set { this.SetValue(HelpButtonHeightProperty, value); }
        }

        /* Max Width */
        public double BackButtonMaxWidth
        {
            get { return (double)this.GetValue(BackButtonMaxWidthProperty); }
            set { this.SetValue(BackButtonMaxWidthProperty, value); }
        }

        public double SkipButtonMaxWidth
        {
            get { return (double)this.GetValue(SkipButtonMaxWidthProperty); }
            set { this.SetValue(SkipButtonMaxWidthProperty, value); }
        }

        public double ForwardButtonMaxWidth
        {
            get { return (double)this.GetValue(ForwardButtonMaxWidthProperty); }
            set { this.SetValue(ForwardButtonMaxWidthProperty, value); }
        }

        public double HelpButtonMaxWidth
        {
            get { return (double)this.GetValue(HelpButtonMaxWidthProperty); }
            set { this.SetValue(HelpButtonMaxWidthProperty, value); }
        }

        /* Max Height */
        public double BackButtonMaxHeight
        {
            get { return (double)this.GetValue(BackButtonMaxHeightProperty); }
            set { this.SetValue(BackButtonMaxHeightProperty, value); }
        }

        public double SkipButtonMaxHeight
        {
            get { return (double)this.GetValue(SkipButtonMaxHeightProperty); }
            set { this.SetValue(SkipButtonMaxHeightProperty, value); }
        }

        public double ForwardButtonMaxHeight
        {
            get { return (double)this.GetValue(ForwardButtonMaxHeightProperty); }
            set { this.SetValue(ForwardButtonMaxHeightProperty, value); }
        }

        public double HelpButtonMaxHeight
        {
            get { return (double)this.GetValue(HelpButtonMaxHeightProperty); }
            set { this.SetValue(HelpButtonMaxHeightProperty, value); }
        }

        /* Margin */
        public Thickness BackButtonMargin
        {
            get { return (Thickness)this.GetValue(BackButtonMarginProperty); }
            set { this.SetValue(BackButtonMarginProperty, value); }
        }

        public Thickness SkipButtonMargin
        {
            get { return (Thickness)this.GetValue(SkipButtonMarginProperty); }
            set { this.SetValue(SkipButtonMarginProperty, value); }
        }

        public Thickness ForwardButtonMargin
        {
            get { return (Thickness)this.GetValue(ForwardButtonMarginProperty); }
            set { this.SetValue(ForwardButtonMarginProperty, value); }
        }

        public Thickness HelpButtonMargin
        {
            get { return (Thickness)this.GetValue(HelpButtonMarginProperty); }
            set { this.SetValue(HelpButtonMarginProperty, value); }
        }

        /* Corner Radius */
        public CornerRadius BackButtonCornerRadius
        {
            get { return (CornerRadius)this.GetValue(BackButtonCornerRadiusProperty); }
            set { this.SetValue(BackButtonCornerRadiusProperty, value); }
        }

        public CornerRadius SkipButtonCornerRadius
        {
            get { return (CornerRadius)this.GetValue(SkipButtonCornerRadiusProperty); }
            set { this.SetValue(SkipButtonCornerRadiusProperty, value); }
        }

        public CornerRadius ForwardButtonCornerRadius
        {
            get { return (CornerRadius)this.GetValue(ForwardButtonCornerRadiusProperty); }
            set { this.SetValue(ForwardButtonCornerRadiusProperty, value); }
        }

        public CornerRadius HelpButtonCornerRadius
        {
            get { return (CornerRadius)this.GetValue(HelpButtonCornerRadiusProperty); }
            set { this.SetValue(HelpButtonCornerRadiusProperty, value); }
        }

        /* Horizontal Content Alignment */
        public HorizontalAlignment BackButtonHorizontalContentAlignment
        {
            get { return (HorizontalAlignment)this.GetValue(BackButtonHorizontalContentAlignmentProperty); }
            set { this.SetValue(BackButtonHorizontalContentAlignmentProperty, value); }
        }

        public HorizontalAlignment SkipButtonHorizontalContentAlignment
        {
            get { return (HorizontalAlignment)this.GetValue(SkipButtonHorizontalContentAlignmentProperty); }
            set { this.SetValue(SkipButtonHorizontalContentAlignmentProperty, value); }
        }

        public HorizontalAlignment ForwardButtonHorizontalContentAlignment
        {
            get { return (HorizontalAlignment)this.GetValue(ForwardButtonHorizontalContentAlignmentProperty); }
            set { this.SetValue(ForwardButtonHorizontalContentAlignmentProperty, value); }
        }

        public HorizontalAlignment HelpButtonHorizontalContentAlignment
        {
            get { return (HorizontalAlignment)this.GetValue(HelpButtonHorizontalContentAlignmentProperty); }
            set { this.SetValue(HelpButtonHorizontalContentAlignmentProperty, value); }
        }

        /* Vertical Content Alignment */
        public VerticalAlignment BackButtonVerticalContentAlignment
        {
            get { return (VerticalAlignment)this.GetValue(BackButtonVerticalContentAlignmentProperty); }
            set { this.SetValue(BackButtonVerticalContentAlignmentProperty, value); }
        }

        public VerticalAlignment SkipButtonVerticalContentAlignment
        {
            get { return (VerticalAlignment)this.GetValue(SkipButtonVerticalContentAlignmentProperty); }
            set { this.SetValue(SkipButtonVerticalContentAlignmentProperty, value); }
        }

        public VerticalAlignment ForwardButtonVerticalContentAlignment
        {
            get { return (VerticalAlignment)this.GetValue(ForwardButtonVerticalContentAlignmentProperty); }
            set { this.SetValue(ForwardButtonVerticalContentAlignmentProperty, value); }
        }

        public VerticalAlignment HelpButtonVerticalContentAlignment
        {
            get { return (VerticalAlignment)this.GetValue(HelpButtonVerticalContentAlignmentProperty); }
            set { this.SetValue(HelpButtonVerticalContentAlignmentProperty, value); }
        }

        /* Font Size */
        public double BackButtonFontSize
        {
            get { return (double)this.GetValue(BackButtonFontSizeProperty); }
            set { this.SetValue(BackButtonFontSizeProperty, value); }
        }

        public double SkipButtonFontSize
        {
            get { return (double)this.GetValue(SkipButtonFontSizeProperty); }
            set { this.SetValue(SkipButtonFontSizeProperty, value); }
        }

        public double ForwardButtonFontSize
        {
            get { return (double)this.GetValue(ForwardButtonFontSizeProperty); }
            set { this.SetValue(ForwardButtonFontSizeProperty, value); }
        }

        public double HelpButtonFontSize
        {
            get { return (double)this.GetValue(HelpButtonFontSizeProperty); }
            set { this.SetValue(HelpButtonFontSizeProperty, value); }
        }

        /* Font Weight */
        public FontWeight BackButtonFontWeight
        {
            get { return (FontWeight)this.GetValue(BackButtonFontWeightProperty); }
            set { this.SetValue(BackButtonFontWeightProperty, value); }
        }

        public FontWeight SkipButtonFontWeight
        {
            get { return (FontWeight)this.GetValue(SkipButtonFontWeightProperty); }
            set { this.SetValue(SkipButtonFontWeightProperty, value); }
        }

        public FontWeight ForwardButtonFontWeight
        {
            get { return (FontWeight)this.GetValue(ForwardButtonFontWeightProperty); }
            set { this.SetValue(ForwardButtonFontWeightProperty, value); }
        }

        public FontWeight HelpButtonFontWeight
        {
            get { return (FontWeight)this.GetValue(HelpButtonFontWeightProperty); }
            set { this.SetValue(HelpButtonFontWeightProperty, value); }
        }

        /* Font Style */
        public FontStyle BackButtonFontStyle
        {
            get { return (FontStyle)this.GetValue(BackButtonFontStyleProperty); }
            set { this.SetValue(BackButtonFontStyleProperty, value); }
        }

        public FontStyle SkipButtonFontStyle
        {
            get { return (FontStyle)this.GetValue(SkipButtonFontStyleProperty); }
            set { this.SetValue(SkipButtonFontStyleProperty, value); }
        }

        public FontStyle ForwardButtonFontStyle
        {
            get { return (FontStyle)this.GetValue(ForwardButtonFontStyleProperty); }
            set { this.SetValue(ForwardButtonFontStyleProperty, value); }
        }

        public FontStyle HelpButtonFontStyle
        {
            get { return (FontStyle)this.GetValue(HelpButtonFontStyleProperty); }
            set { this.SetValue(HelpButtonFontStyleProperty, value); }
        }
    }
}
