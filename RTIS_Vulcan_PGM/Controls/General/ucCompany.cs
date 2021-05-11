using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RTIS_Vulcan_PGM.Forms;
using RTIS_Vulcan_PGM.Classes;

namespace RTIS_Vulcan_PGM.Controls
{
    public partial class ucCompany : UserControl
    {
        public frmMsg msg;
        public string errMsg;
        public string errInfo;

        Panel parent;
        public frmMain main;

        public ucCompany(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }

        private void ucCompany_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;            
        }

        private void btnvW_Click(object sender, EventArgs e)
        {
            GlobalVars.currentCompany = GlobalVars.Companies.VW;

            switch (GlobalVars.currentState)
            {
                case GlobalVars.ApplicationStates.None:
                    break;
                case GlobalVars.ApplicationStates.FromV:
                    GlobalVars.lastControl = main.pnlMain.Controls[0];
                    try
                    {
                        ucScanItem scan = new ucScanItem(parent, main);
                        main.pnlMain.Controls.Clear();
                        main.pnlMain.Controls.Add(scan);
                    }
                    catch (Exception ex)
                    {
                        ExHandler.showErrorEx(ex);
                    }
                    break;
                case GlobalVars.ApplicationStates.Rec:
                    GlobalVars.lastControl = main.pnlMain.Controls[0];
                    try
                    {
                        ucWarehouseFrom whses = new ucWarehouseFrom(parent, main);
                        main.pnlMain.Controls.Clear();
                        main.pnlMain.Controls.Add(whses);
                    }
                    catch (Exception ex)
                    {
                        ExHandler.showErrorEx(ex);
                    }
                    break;
                case GlobalVars.ApplicationStates.Manuf:
                    GlobalVars.lastControl = main.pnlMain.Controls[0];
                    try
                    {
                        ucManufacture manuf = new ucManufacture(parent, main);
                        main.pnlMain.Controls.Clear();
                        main.pnlMain.Controls.Add(manuf);
                    }
                    catch (Exception ex)
                    {
                        ExHandler.showErrorEx(ex);
                    }
                    break;
                case GlobalVars.ApplicationStates.ToWip:
                    try
                    {
                        GlobalVars.lastControl = main.pnlMain.Controls[0];
                        GlobalVars.currentFGType = GlobalVars.FGType.VWSlurry;
                        ucSelectProductToManuf prod = new ucSelectProductToManuf(parent, main);
                        main.pnlMain.Controls.Clear();
                        main.pnlMain.Controls.Add(prod);
                    }
                    catch (Exception ex)
                    {
                        ExHandler.showErrorEx(ex);
                    }
                    
                    break;
                case GlobalVars.ApplicationStates.TransView:
                    try
                    {
                        GlobalVars.lastControl = main.pnlMain.Controls[0];
                        GlobalVars.currentFGType = GlobalVars.FGType.VWSlurry;
                        ucSelectItem item = new ucSelectItem(parent, main);
                        main.pnlMain.Controls.Clear();
                        main.pnlMain.Controls.Add(item);
                    }
                    catch (Exception ex)
                    {
                        ExHandler.showErrorEx(ex);
                    }
                    break;
                default:
                    break;
            }


        }

        private void btnToyota_Click(object sender, EventArgs e)
        {
            GlobalVars.currentCompany = GlobalVars.Companies.Toyota;
            switch (GlobalVars.currentState)
            {
                case GlobalVars.ApplicationStates.None:
                    break;
                case GlobalVars.ApplicationStates.FromV:
                    GlobalVars.lastControl = main.pnlMain.Controls[0];
                    try
                    {
                        ucScanItem scan = new ucScanItem(parent, main);
                        main.pnlMain.Controls.Clear();
                        main.pnlMain.Controls.Add(scan);
                    }
                    catch (Exception ex)
                    {
                        ExHandler.showErrorEx(ex);
                    }
                    break;
                case GlobalVars.ApplicationStates.Rec:
                    GlobalVars.lastControl = main.pnlMain.Controls[0];
                    try
                    {
                        ucWarehouseFrom whses = new ucWarehouseFrom(parent, main);
                        main.pnlMain.Controls.Clear();
                        main.pnlMain.Controls.Add(whses);
                    }
                    catch (Exception ex)
                    {
                        ExHandler.showErrorEx(ex);
                    }
                    break;
                case GlobalVars.ApplicationStates.Manuf:
                    GlobalVars.lastControl = main.pnlMain.Controls[0];
                    try
                    {
                        ucManufacture manuf = new ucManufacture(parent, main);
                        main.pnlMain.Controls.Clear();
                        main.pnlMain.Controls.Add(manuf);
                    }
                    catch (Exception ex)
                    {
                        ExHandler.showErrorEx(ex);
                    }
                    break;
                case GlobalVars.ApplicationStates.ToWip:
                    GlobalVars.lastControl = main.pnlMain.Controls[0];
                    try
                    {
                        ucFGType fgType = new ucFGType(parent, main);
                        main.pnlMain.Controls.Clear();
                        main.pnlMain.Controls.Add(fgType);
                    }
                    catch (Exception ex)
                    {
                        ExHandler.showErrorEx(ex);
                    }
                    break;
                case GlobalVars.ApplicationStates.TransView:
                    try
                    {
                        GlobalVars.lastControl = main.pnlMain.Controls[0];
                        GlobalVars.currentFGType = GlobalVars.FGType.VWSlurry;
                        ucSelectItem item = new ucSelectItem(parent, main);
                        main.pnlMain.Controls.Clear();
                        main.pnlMain.Controls.Add(item);
                    }
                    catch (Exception ex)
                    {
                        ExHandler.showErrorEx(ex);
                    }
                    break;
                default:
                    break;
            }        
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalVars.lastControl = new ucMenu(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(GlobalVars.lastControl);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
    }
}
