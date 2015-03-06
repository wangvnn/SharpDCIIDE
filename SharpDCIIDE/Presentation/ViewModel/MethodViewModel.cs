using KimHaiQuang.SharpDCIIDE.Domain.Data.DCIInfo;
using KimHaiQuang.SharpDCIIDE.Presentation.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimHaiQuang.SharpDCIIDE.Presentation.ViewModel
{
    public class MethodViewModel : ViewModelBase<DCIRoleMethod>
    {
        public MethodViewModel(DCIRoleMethod model)
            :base(model)
        {

        }
    }
}
