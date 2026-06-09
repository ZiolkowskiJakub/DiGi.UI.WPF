using System.Windows;

namespace DiGi.UI.WPF.Windows
{
    /// <summary>
    /// Interaction logic for TextBoxWindow.xaml
    /// </summary>
    public partial class TextBoxWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextBoxWindow"/> class.
        /// </summary>
        public TextBoxWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBoxWindow"/> class with specified title, initial text, and an associated value.
        /// </summary>
        /// <param name="title">The window title.</param>
        /// <param name="text">The initial text for the text box.</param>
        /// <param name="value">The object value to be converted to a string representation.</param>
        public TextBoxWindow(string? title, string? text, object? value)
        {
            InitializeComponent();

            Title = title;
            Text = text;
            Value = value?.ToString();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBoxWindow"/> class with specified title and initial text.
        /// </summary>
        /// <param name="title">The window title.</param>
        /// <param name="text">The initial text for the text box.</param>
        public TextBoxWindow(string? title, string? text)
        {
            InitializeComponent();

            Title = title;
            Text = text;
        }

        /// <summary>
        /// Gets or sets the text content of the main text box control.
        /// </summary>
        public string? Text
        {
            get
            {
                return TextBoxControl_Main.Text;
            }

            set
            {
                TextBoxControl_Main.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets the validation function used to verify the input text.
        /// </summary>
        public Func<string, bool>? Validation
        {
            get
            {
                return TextBoxControl_Main.Validation;
            }

            set
            {
                TextBoxControl_Main.Validation = value;
            }
        }

        /// <summary>
        /// Gets or sets the value associated with the text box control.
        /// </summary>
        public string? Value
        {
            get
            {
                return TextBoxControl_Main.Value;
            }

            set
            {
                TextBoxControl_Main.Value = value;
            }
        }

        /// <summary>
        /// Retrieves the current value from the text box as the specified type.
        /// </summary>
        /// <typeparam name="T">The target type to retrieve.</typeparam>
        /// <returns>The retrieved value of type <typeparamref name="T"/>, or the default value if retrieval fails.</returns>
        public T? GetValue<T>()
        {
            return TextBoxControl_Main.GetValue<T>();
        }

        /// <summary>
        /// Retrieves the current value from the text box as the specified type, returning a default value if retrieval fails.
        /// </summary>
        /// <typeparam name="T">The target type to retrieve.</typeparam>
        /// <param name="defaultValue">The value to return if the actual value cannot be retrieved or converted.</param>
        /// <returns>The retrieved value of type <typeparamref name="T"/>, or the provided <paramref name="defaultValue"/>.</returns>
        public T? GetValue<T>(T? defaultValue)
        {
            return TextBoxControl_Main.GetValue(defaultValue);
        }

        /// <summary>
        /// Attempts to retrieve the current value from the text box as the specified type.
        /// </summary>
        /// <typeparam name="T">The target type to retrieve.</typeparam>
        /// <param name="value">When this method returns, contains the retrieved value if successful; otherwise, the default value of <typeparamref name="T"/>.</param>
        /// <returns>True if the value was successfully retrieved and converted; otherwise, false.</returns>
        public bool TryGetValue<T>(out T? value)
        {
            return TextBoxControl_Main.TryGetValue(out value);
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void Button_OK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}