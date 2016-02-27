using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllowMC
{
    public partial class frmMCWatcher : Form
    {

        const string PROCESS_NAME = "java";

        public frmMCWatcher()
        {
            InitializeComponent();
        }


        #region Button Routines
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //Stop Service
                stopService();

                //disable the calendar
                dtStopTime.Enabled = false;

                //set end time
                // -- it is set in the datetime picker

                //disable start button
                btnStart.Enabled = false;
                //Enable button
                btnStop.Enabled = true;

                //disable closing
                this.ControlBox = false;
                
                //enable timer
                timerPlay.Enabled = true;
                timerPlay.Start();

            }
            catch
            {
                MessageBox.Show("You are not authorised to execute the program!", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            endTimer();
        }
        #endregion

        private void timerPlay_Tick(object sender, EventArgs e)
        {
            //update the timer
            lblTimer.Text = String.Format("{0:000.00} mins", dtStopTime.Value.Subtract(DateTime.Now).TotalMinutes);
            //end if time has elapsed
            if (dtStopTime.Value.CompareTo(DateTime.Now) <= 0)
            {
                //disable timer
                timerPlay.Stop();
                timerPlay.Enabled = false;
                endTimer();
            }

        }

        private void endTimer()
        {
            try
            {
                //disable timer
                timerPlay.Enabled = false;

                // Enable Service
                startService();

                //kill processes
                stopProcessByName(PROCESS_NAME);
             }
            catch
            {
                MessageBox.Show("Error shutting down cleanly. Please restart the computer", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
            //exit()
            this.Close();
            }
        }

        private void frmMCWatcher_FormClosing(object sender, FormClosingEventArgs e)
        {
            //endTimer because the form was closed
            //endTimer();
            //disable timer
            timerPlay.Enabled = false;

            // Enable Service
            startService();

            //kill processes
            stopProcessByName(PROCESS_NAME);
        }

        //stop service
        private void stopService()
        {
           if (svcMgr.Status == System.ServiceProcess.ServiceControllerStatus.Running)  svcMgr.Stop();
        }
        
        //start Service
        private void startService()
        {
            if (svcMgr.Status != System.ServiceProcess.ServiceControllerStatus.Running) svcMgr.Start();
            Thread.Sleep(5000);
        }
 
        #region Process Routines
        void stopProcessByID(int ID)
        {
            try
            {
                Process process = Process.GetProcessById(ID);
                process.Kill();
            }
            catch (Exception ex)
            {
               // EventLog.WriteEntry("Encountered Errors killing Process:\n" + ex.ToString(), EventLogEntryType.Error);
            }
        }

        void stopProcessByName(string processName)
        {
            if (processName != "")
            {
                string query = String.Format("Select * From Win32_Process Where Name LIKE \"{0}%\" ", processName);
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
                ManagementObjectCollection processList = searcher.Get();

                foreach (ManagementObject obj in processList)
                {

                    stopProcessByID(Convert.ToInt32(obj.GetPropertyValue("ProcessID")));
                }
            }
        }
        #endregion




    }
}
