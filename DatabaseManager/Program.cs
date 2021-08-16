using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DatabaseManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Mutex mutex = new Mutex(false, "supercooluniquemutex");
            try
            {
                bool tryAgain = true;
                while (tryAgain)
                {
                    bool result = false;
                    try
                    {
                        result = mutex.WaitOne(0, false);
                    }
                    catch (AbandonedMutexException ex)
                    {
                        // No action required
                        result = true;
                    }
                    if (result)
                    {
                        // Run the application
                        tryAgain = false;
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new Main());
                    }
                    else
                    {
                        foreach (Process proc in Process.GetProcesses())
                        {
                            if (proc.ProcessName.Equals(Process.GetCurrentProcess().ProcessName) && proc.Id != Process.GetCurrentProcess().Id)
                            {
                                proc.Kill();
                                break;
                            }
                        }
                        // Wait for process to close
                        Thread.Sleep(2000);
                    }
                }
            }
            finally
            {
                if (mutex != null)
                {
                    mutex.Close();
                    mutex = null;
                }
            }

            
        }
    }
}
