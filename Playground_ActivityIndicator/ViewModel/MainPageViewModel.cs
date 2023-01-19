using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground_ActivityIndicator.ViewModel
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool isLoading = false;

        [RelayCommand]
        private async Task ButtonClicked()
        {
            IsLoading = true;

            await WriteLines();

            IsLoading = false;
        }

        private async Task WriteLines()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
