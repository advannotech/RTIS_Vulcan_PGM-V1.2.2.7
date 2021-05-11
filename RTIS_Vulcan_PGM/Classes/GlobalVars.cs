using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTIS_Vulcan_PGM.Classes
{
   public class GlobalVars
    {
        #region General
        public static string sep = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;

        public static Control lastControl;
        public static string RSCFolder = string.Empty;
        public static string SettingsDB = string.Empty;
        public static TextEdit focusedEdit = new TextEdit();
        public enum msgState { Error, Success, Question, First, Info }
        public enum ApplicationStates {None, FromV, Rec, Manuf, ToWip, TransView }
        public static ApplicationStates currentState = ApplicationStates.FromV;
        public enum Companies { None, VW, Toyota}
        public static Companies currentCompany = Companies.None;
        public static string userName { get; set; }
        public static string[] userPerms { get; set; }
        public static string ServerIP { get; set; }
        public static string ServerPort { get; set; }
        public static string vaultWhse { get; set; }
        public static string ToyotaWhse { get; set; }
        public static string VWWhse { get; set; }
        public static string ToyotaIT { get; set; }
        public static string VWIT { get; set; }
        public static bool bToVAult { get; set; }
        public static bool bReceive { get; set; }
        public static bool bManufacture { get; set; }
        public static bool bToWIP { get; set; }
        public static bool bTransViewer { get; set; }
        public static string PGMLineCount { get; set; }
        #endregion

        #region Receive
        public static string RecWhseFromCode { get; set; }
        public static string RecWhseFromName { get; set; }
        #endregion

        #region Manufacture
        public static string manufItem { get; set; }
        public static string manufBatch { get; set; }
        public static string manufConcen { get; set; }
        #endregion

        #region Transfer to WIP
        public enum FGType { None, VWSlurry, ToyotaPowder, ToyotaSlurry, ToyotaAW }
        public static FGType currentFGType = FGType.None;
        public static string WIPFGCode { get; set; }
        #endregion

        #region Transaction Veiwer
        public static string TransactionItem { get; set; }
        public static string TransactionBatch { get; set; }
        #endregion
    }
}
