using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

public class Common
{
    public static void Show(object msg)
    {
        MessageBox.Show(msg.ToString());
    }

    public static List<string> GetIPAddress()
    {
        var Addresses = new List<string>();
        string hostName = Dns.GetHostName();
        IPHostEntry hostEntry = Dns.GetHostEntry(hostName);
        IPAddress[] addressList = hostEntry.AddressList;
        foreach (IPAddress address in addressList)
        {
            if (address.AddressFamily == AddressFamily.InterNetwork)
            {
                Addresses.Add(address.ToString());
            }
        }
        return Addresses;
    }

    internal static void InvokeAddControl(Control control, Control child)
    {
        if (control.InvokeRequired)
        {
            control.Invoke(new Action(() => { control.Controls.Add(child); }));
        }
        else
            control.Controls.Add(child);
    }

    internal static void InvokeAction(Control control, Action action)
    {
        if (control.InvokeRequired)
        {
            control.Invoke(action);
        }
        else
            action();
    }

    internal static void InvokeRemoveControl(Control control, Control child)
    {
        if (control.InvokeRequired)
        {
            control.Invoke(new Action(() => { control.Controls.Remove(child); }));
        }
        else
            control.Controls.Remove(child);
    }

    

    public static string LongToMbytes(long lBytes)
    {
        StringBuilder stringBuilder = new StringBuilder();
        string str1 = "Bytes";
        if (lBytes > 1024L)
        {
            string str2;
            float num;
            if (lBytes < 1048576L)
            {
                str2 = "KB";
                num = Convert.ToSingle(lBytes) / 1024f;
            }
            else
            {
                str2 = "MB";
                num = Convert.ToSingle(lBytes) / 1048576f;
            }
            stringBuilder.AppendFormat("{0:0.0} {1}", (object)num, (object)str2);
        }
        else
        {
            float num = Convert.ToSingle(lBytes);
            stringBuilder.AppendFormat("{0:0} {1}", (object)num, (object)str1);
        }
        return stringBuilder.ToString();
    }

    public static void EnsureDirectoryExists(string filePath, bool isFile = false)
    {
        if (!string.IsNullOrEmpty(filePath))
        {
            filePath = filePath.Trim().Replace("\0", string.Empty);
            if (!string.IsNullOrEmpty(filePath))
            {
                try
                {
                    string text = isFile ? Path.GetDirectoryName(filePath) : filePath;
                    if (Path.IsPathRooted(filePath))
                    {
                        text = text.Trim();
                        if (!Directory.Exists(text))
                        {
                            Directory.CreateDirectory(text);
                        }
                    }
                }
                catch (Exception exception)
                {

                }
            }
        }
    }

    public static int GetRandom()
    {
        return new Random().Next(1, 9999);
    }

    public static string GetPath()
    {
        Process currentProcess;
        try
        {
            currentProcess = Process.GetCurrentProcess();
            return new FileInfo(currentProcess.MainModule.FileName).Directory?.FullName;
        }
        finally { currentProcess = null; }
    }
}