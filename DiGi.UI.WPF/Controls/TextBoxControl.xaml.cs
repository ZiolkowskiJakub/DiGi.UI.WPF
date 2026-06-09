using System.Windows.Controls;
using System.Windows.Input;

namespace DiGi.UI.WPF.Controls
{
    /// <summary>
    /// Interaction logic for TextBoxControl.xaml
    /// </summary>
    public partial class TextBoxControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextBoxControl"/> class.
        /// </summary>
        public TextBoxControl()
        {
            InitializeComponent();

            TextBox_Value.PreviewTextInput += TextBox_Value_PreviewTextInput;
            TextBox_Value.PreviewKeyDown += TextBox_Value_PreviewKeyDown;
        }

        /// <summary>
        /// Gets or sets the text content displayed in the control's label.
        /// </summary>
        public string? Text
        {
            get
            {
                return Label_Text.Content?.ToString();
            }

            set
            {
                Label_Text.Content = value;
            }
        }

        /// <summary>
        /// Gets or sets the validation function used to determine if a string input is valid.
        /// </summary>
        public Func<string, bool>? Validation { get; set; }

        /// <summary>
        /// Gets or sets the text value of the internal text box.
        /// </summary>
        public string? Value
        {
            get
            {
                return TextBox_Value.Text?.ToString();
            }

            set
            {
                TextBox_Value.Text = value;
            }
        }

        /// <summary>
        /// Retrieves the current value of the control converted to the specified type.
        /// </summary>
        /// <typeparam name="T">The target type for conversion.</typeparam>
        /// <returns>The converted value if successful; otherwise, the default value of type <typeparamref name="T"/>.</returns>
        public T? GetValue<T>()
        {
            if (!TryGetValue(out T? result))
            {
                return default;
            }

            return result;
        }

        /// <summary>
        /// Retrieves the current value of the control converted to the specified type, or returns a provided default value if conversion fails.
        /// </summary>
        /// <typeparam name="T">The target type for conversion.</typeparam>
        /// <param name="defaultValue">The value to return if the conversion cannot be performed.</param>
        /// <returns>The converted value if successful; otherwise, the specified <paramref name="defaultValue"/>.</returns>
        public T? GetValue<T>(T? defaultValue)
        {
            if (!TryGetValue(out T? result))
            {
                return defaultValue;
            }

            return result;
        }

        /// <summary>
        /// Attempts to convert the current value of the control to the specified type.
        /// </summary>
        /// <typeparam name="T">The target type for conversion.</typeparam>
        /// <param name="value">When this method returns, contains the converted value if successful; otherwise, the default value of type <typeparamref name="T"/>.</param>
        /// <returns><c>true</c> if the value was successfully converted; otherwise, <c>false</c>.</returns>
        public bool TryGetValue<T>(out T? value)
        {
            return DiGi.Core.Query.TryConvert(Value, out value);
        }

        private void TextBox_Value_Pasting(object sender, System.Windows.DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string text = (string)e.DataObject.GetData(typeof(string));
                if (Validation is not null && !Validation.Invoke(text))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }

        private void TextBox_Value_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            // Allow Backspace, Delete, Left, Right, Tab
            if (e.Key == Key.Back || e.Key == Key.Delete ||
                e.Key == Key.Left || e.Key == Key.Right || e.Key == Key.Tab)
            {
                e.Handled = false;
            }
        }

        private void TextBox_Value_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Validation is not null)
            {
                e.Handled = !Validation.Invoke(e.Text);
            }
        }
    }
}