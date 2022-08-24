using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Wikipedia.Helper
{
    internal class BrowserEnvHelper
    {
        /// <summary>
        /// 浏览器仿真
        /// </summary>
        const string FEATURE_BROWSER_EMULATION = @"\FEATURE_BROWSER_EMULATION";

        /// <summary>
        /// 子窗口剪裁优化
        /// </summary>
        const string FEATURE_ENABLE_CLIPCHILDREN_OPTIMIZATION = @"\FEATURE_ENABLE_CLIPCHILDREN_OPTIMIZATION";

        /// <summary>
        /// Microsoft Internet Explorer 特性控制
        /// </summary>
        const string MicrosoftInternetExplorerMainFeatureControl = @"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main\FeatureControl";

        /// <summary>
        /// 获取组件文件名
        /// </summary>
        /// <param name="hModule"></param>
        /// <param name="lpFilename"></param>
        /// <param name="nSize"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern int GetModuleFileName(IntPtr hModule, StringBuilder lpFilename, int nSize);

        /// <summary>
        /// 初始化本机浏览器仿真设置
        /// </summary>
        public void InitLocalBrowserEmulation()
        {
            // 获取本地浏览器版本
            var browserVersion = GetLocalBrowserVersion();
            // 获取浏览器仿真数值
            var emulationValue = GetBrowserEmulationValue(browserVersion);
            // 获取应用运行程序名称
            var appExecutableName = GetAppExecutableName();
            // 判断执行合法性
            if (browserVersion > 0 && !string.IsNullOrEmpty(appExecutableName))
            {
                // 注册表设置浏览器仿真值
                var FEATURE_BROWSER_EMULATION_KEY = $"{MicrosoftInternetExplorerMainFeatureControl}{FEATURE_BROWSER_EMULATION}";
                Registry.SetValue(FEATURE_BROWSER_EMULATION_KEY, appExecutableName, emulationValue, RegistryValueKind.DWord);

                // 注册表启用子窗口剪裁优化
                var FEATURE_ENABLE_CLIPCHILDREN_OPTIMIZATION_KEY = $"{MicrosoftInternetExplorerMainFeatureControl}{FEATURE_ENABLE_CLIPCHILDREN_OPTIMIZATION}";
                Registry.SetValue(FEATURE_ENABLE_CLIPCHILDREN_OPTIMIZATION_KEY, appExecutableName, 1, RegistryValueKind.DWord);
            }
        }

        /// <summary>
        /// 获取应用运行程序名称
        /// </summary>
        /// <returns></returns>
        private string GetAppExecutableName()
        {
            var appExecutablePath = string.Empty;
            var sb = new StringBuilder(1024);
            var len = GetModuleFileName(IntPtr.Zero, sb, sb.Capacity);
            if (len > 0)
            {
                appExecutablePath = sb.ToString(0, len);
            }

            var appExecutableName = Path.GetFileName(appExecutablePath);
            return appExecutableName;
        }

        /// <summary>
        /// 获取浏览器仿真数值
        /// </summary>
        /// <param name="localBrowserVersion"></param>
        /// <returns></returns>
        private uint GetBrowserEmulationValue(int localBrowserVersion)
        {
            uint emulationValue;
            switch (localBrowserVersion)
            {
                // Internet Explorer 7, 包含基于标准的!DOCTYPE指令的网页在IE 7标准模式下显示。托管WebBrowser控件的应用程序的默认值。
                case 7:
                    emulationValue = 7000;
                    break;
                // Internet Explorer 8, 包含基于标准的!DOCTYPE指令的网页在IE 8模式下显示。Internet Explorer 8的默认值。
                case 8:
                    emulationValue = 8000;
                    break;
                // Internet Explorer 9, 包含基于标准的!DOCTYPE指令的网页在IE 9模式下显示。Internet Explorer 9的默认值。
                case 9:
                    emulationValue = 9000;
                    break;
                // Internet Explorer 10, 包含基于标准的!DOCTYPE指令的网页在IE 10标准模式下显示。Internet Explorer 10的默认值。
                case 10:
                    emulationValue = 10000;
                    break;
                // Internet Explorer 11, 包含基于标准的!DOCTYPE指令的网页在IE 11 Edge模式下显示。Internet Explorer 11的默认值。
                case 11:
                default:
                    emulationValue = 11000;
                    break;
            }

            return emulationValue;
        }

        /// <summary>
        /// 获取本地浏览器版本
        /// </summary>
        /// <returns></returns>
        private int GetLocalBrowserVersion()
        {
            var systemDir = Environment.GetFolderPath(Environment.SpecialFolder.System);
            var localBrowserFilePath = Path.Combine(systemDir, "mshtml.dll");
            if (!string.IsNullOrEmpty(localBrowserFilePath) && File.Exists(localBrowserFilePath))
            {
                try
                {
                    var fileVersionInfo = FileVersionInfo.GetVersionInfo(localBrowserFilePath);
                    return fileVersionInfo.FileMajorPart;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }

            return -1;
        }
    }
}
