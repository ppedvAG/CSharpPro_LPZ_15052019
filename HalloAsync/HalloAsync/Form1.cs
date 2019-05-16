using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloAsync
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                metroProgressBar1.Value = i;
                Thread.Sleep(400);
            }
        }

        private void StarteTaskMetroButton_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    metroProgressBar1.Invoke((MethodInvoker)delegate () { metroProgressBar1.Value = i; });
                    Thread.Sleep(400);
                }
            });
        }


        CancellationTokenSource cts;
        private void MetroButton1_Click_1(object sender, EventArgs e)
        {
            TaskScheduler ts = TaskScheduler.FromCurrentSynchronizationContext();

            metroButton1.Enabled = false;
            cts = new CancellationTokenSource();
            Task.Run(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    Thread.Sleep(40);
                    Task.Factory.StartNew(() => metroProgressBar1.Value = i, cts.Token, TaskCreationOptions.None, ts);
                    if (cts.IsCancellationRequested)
                    {
                        //cleanup
                        break;
                    }
                }
            }).ContinueWith(t => metroButton1.Enabled = !false, CancellationToken.None, TaskContinuationOptions.None, ts);
        }

        private void AbbrechenMetroButton2_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
        }

        private async void MetroButton2_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            for (int i = 0; i <= 100; i++)
            {
                metroProgressBar1.Value = i;
                try
                {
                    await Task.Delay(100, cts.Token);
                }
                catch (TaskCanceledException)
                {
                    MessageBox.Show("Task wurde erfolgreich abgebrochen");
                    break;
                }
            }
        }

        private async void MetroButton3_Click(object sender, EventArgs e)
        {
            string conString = "Server=.;Database=Northwind;Trusted_Connection=true";
            using (var con = new SqlConnection(conString))
            {
                await con.OpenAsync();

                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "WAITFOR DELAY '00:00:05';SELECT COUNT(*) FROM Employees";
                    var count = (int)await cmd.ExecuteScalarAsync();
                    MessageBox.Show($"{count} Emps in DB");
                }
            } // con.Dispose(); => con.Close();
        }


        private long AlteLangsameFunktion()
        {
            Thread.Sleep(4000);
            return 654984984984;
        }

        private Task<long> AlteLangsameFunktionAsync()
        {
            return Task.Run(() => AlteLangsameFunktion());
        }

        private async void MetroButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show((await AlteLangsameFunktionAsync()).ToString());
        }
    }
}
