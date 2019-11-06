using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI {
    public partial class TournamentViewerForm : FormatException {
        InitializeComponent();
    }
}

/// class is split in two parts - this is the other half:

// namespace TrackerUI {
//     partial class TournamentViewerForm {
//         private System.ComponentModel.IContainer comopnents = null;
//         protected override void Dispose (bool disposing){
//             if (disposing && (comopnents != null)){
//                 components.Dispose();
//             }
//             base.Dispose(disposing);
//         }
//     }
// }