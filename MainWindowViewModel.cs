H:\ws\NAudio1.7\NAudioWpfDemo\MainWindowViewModel.cs

        public MainWindowViewModel(IEnumerable<IModule> modules)
        {
            //this.Modules = modules.OrderBy(m => m.Name).ToList();
            this.Modules = modules.OrderByDescending(m => m.Name).ToList();

            if (this.Modules.Count > 0)
            {
                this.SelectedModule = this.Modules[0];
            }
        }
