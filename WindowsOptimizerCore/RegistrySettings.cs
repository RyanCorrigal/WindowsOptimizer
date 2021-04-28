using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace WindowsOptimizerCore
{
    class RegistrySettings
    {
        const string MicrosoftWindowsWindowsCurrentVersion = @"\SOFTWARE\Microsoft\Windows\CurrentVersion\";
        const string BingSearchEnabled = "BingSearchEnabled";
        const string GlobalUserDisabled = "GlobalUserDisabled";

        protected void SetBackgroundApps(int setValue)
        {
            var currentUser = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
            var backgroundAccessApplications = currentUser.OpenSubKey(MicrosoftWindowsWindowsCurrentVersion + "BackgroundAccessApplications");
            var globalUserDisabledValue = backgroundAccessApplications.GetValue(GlobalUserDisabled).ToString();

            if (globalUserDisabledValue != "1" && setValue != 1)
            {
                backgroundAccessApplications.SetValue(GlobalUserDisabled, 0);
            }
            else
            {
                backgroundAccessApplications.SetValue(GlobalUserDisabled, 1);
            }

            currentUser.Close();
        }

        protected void SetBingSearch(int setValue)
        {
            var currentUser = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
            var searchSubKey = currentUser.OpenSubKey(MicrosoftWindowsWindowsCurrentVersion + "Search");
            var bingSearchEnabledValue = searchSubKey.GetValue(BingSearchEnabled).ToString();

            if (bingSearchEnabledValue != "1" && setValue != 1)
            {
                searchSubKey.SetValue(BingSearchEnabled, 0);
            }
            else
            {
                searchSubKey.SetValue(BingSearchEnabled, 1);
            }

            currentUser.Close();
        }
    }
}
