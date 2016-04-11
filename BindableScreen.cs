using System;
using PNet.Icap.Platform.ControlSdk2;

namespace BindingEngine
{
    public class BindableScreen<TViewModel> : PNetPage where TViewModel : BindableObject
    {
        public int ResourceId { get; set; }

        public TViewModel DataContext { get; set; }

        public int ViewLayoutResourceId { get; set; }

        protected BindableScreen(TViewModel viewModel, int viewLayoutResourceId)
        {
            this.ViewLayoutResourceId = viewLayoutResourceId;

            this.DataContext = viewModel;
        }

        public override void OnStart()
        {
            base.OnStart();
            BindingEngine.Initialize(this);
        }

    }
}