using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab05
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditorCode : ContentPage
    {
        public EditorCode()
        {
            InitializeComponent();
            StackLayout stack = new StackLayout();
            var myEditor = new Editor { Text = "I am an editor" };
            stack.Children.Add(myEditor);
            Content = stack;
        }
    }
}