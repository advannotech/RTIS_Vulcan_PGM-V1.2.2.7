using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using RTIS_Vulcan_PGM.Classes;


namespace RTIS_Vulcan_PGM.Classes
{
    class Client
    {
        public static string Login(string pin)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*PGMLOGIN*@" + pin);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-1*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }

        public static string GetPGMPerms(string username)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*GETPGMUSERPERMS*@" + username);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-1*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }

        #region From Vault

        public static string GetFVItemDetails(string itemInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*PGMGETFVITEMINFO*@" + itemInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-1*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }

        public static string TransferFromVault(string itemInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*PGMTRANSFERFROMVAULT*@" + itemInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-1*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }

        #endregion

        #region Receiving
        public static string GetFromWarehouses()
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*PGMGETWHSESREC*@");
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-1*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        public static string GetRecItemDetails(string itemInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*PGMGETRECITEMINFO*@" + itemInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-1*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        public static string ReceiveTransfer(string itemInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*PGMRECEIVETRANS*@" + itemInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-1*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        #endregion

        #region Manufacture
        public static string getRemainderCaptured(string itemInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*PGMGETREMCAPTURED*@" + itemInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-1*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        public static string getBatchLines(string itemInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*PGMGETBATCHLINES*@" + itemInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-1*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        public static string manufacturePGM(string itemInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*PGMMANUFACTURECONTAINER*@" + itemInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-1*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        public static string refillPGM(string itemInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*PGMREFILLCONTAINER*@" + itemInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-1*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        public static string setBatchRemainder(string itemInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*PGMSETREMAINDER*@" + itemInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-1*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        #endregion

        #region Transfer to WIP
        public static string GetFGItems(string transType)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*PGMGETTRANSFERITEMS*@" + transType);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*" + ex.Message;
            }
        }
        public static string TransferItemToWIP(string itemInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*PGMTRANSFERTOWIP*@" + itemInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*" + ex.Message;
            }
        }
        #endregion

        #region Transaction Veiwer
        public static string GetAllPGMItems(string whseCode)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*PGMGETITEMLIST*@" + whseCode);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*" + ex.Message;
            }
        }
        public static string GetAllPGMHeader(string itemInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*GETPGMTRANSACTIONSHEADER*@" + itemInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*" + ex.Message;
            }
        }
        public static string GetAllPGMHeaderRows(string itemInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*GETPGMTRANSACTIONSHEADERROWS*@" + itemInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*" + ex.Message;
            }
        }
        public static string GetAllPGMTransactions(string itemInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*GETITEMTRANSACTIONSBATCHSPEC*@" + itemInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*" + ex.Message;
            }
        }

        public static string GetAllPGMItemTransactions(string whseCode)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*GETITEMTRANSACTIONS*@" + whseCode);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*" + ex.Message;
            }
        }
        public static string UpdateContainerQty(string whseCode)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*PGMEDITCONTAINERWEIGHT*@" + whseCode);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*" + ex.Message;
            }
        }
        #endregion
    }
}
