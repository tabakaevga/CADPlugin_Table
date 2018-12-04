using System;
using System.IO;
using System.Runtime.InteropServices;
using SldWorks;
using SWPublished;

namespace CadPlugin
{
    /// <summary>
    /// Сущность интеграции плагина в SolidWorks
    /// </summary>
    public class PluginIntegration : ISwAddin
    {
        #region Private Members

        /// <summary>
        /// Куки теущей сессии SolidWorks
        /// </summary>
        private int _swCookie;

        /// <summary>
        /// Служебный класс боковой панели
        /// </summary>
        private TaskpaneView _taskpaneView;

        /// <summary>
        /// UI Панели
        /// </summary>
        private TaskpaneHostUi _taskpaneHostUi;

        /// <summary>
        /// Текущая сессия SolidWorks
        /// </summary>
        private SldWorks.SldWorks _solidWorksApplication;

        #endregion

        #region Public Members

        /// <summary>
        /// ProgID плагина
        /// </summary>
        public const string SwPluginProgId = "Table SolidWorks Plugin";

        #endregion

        #region SolidWorks Add-in Callbacks

        /// <summary>
        /// Вызывается, когда Solidworks загрузил плагин и проводит логику соединения
        /// </summary>
        /// <param name="thisSw">Сессия Solidworks</param>
        /// <param name="cookie">Куки</param>
        public bool ConnectToSW(object thisSw, int cookie)
        {
            _solidWorksApplication = (SldWorks.SldWorks)thisSw;

            _swCookie = cookie;

            _solidWorksApplication.SetAddinCallbackInfo2(0, this, _swCookie);

            LoadUi();

            // Return ok
            return true;
        }

        /// <summary>
        /// Вызывается, когда Solidworks собирается выгрузить плагин и проводить логику разъединения
        /// </summary>
        public bool DisconnectFromSW()
        {
            UnloadUi();

            return true;
        }

        #endregion

        #region Create UI

        /// <summary>
        /// Создать UI
        /// </summary>
        private void LoadUi()
        {
            var imagePath = Path.Combine(Path.GetDirectoryName(typeof(PluginIntegration).Assembly.CodeBase)
                .Replace(@"file:\", string.Empty), "logo-small.png");

            _taskpaneView = _solidWorksApplication.CreateTaskpaneView2(imagePath, "That's the plugin of Table");

            _taskpaneHostUi = (TaskpaneHostUi)_taskpaneView.AddControl(PluginIntegration.SwPluginProgId, string.Empty);
        }

        /// <summary>
        /// Очистка панели и выгрузка
        /// </summary>
        private void UnloadUi()
        {
            _taskpaneHostUi = null;

            _taskpaneView.DeleteView();

            Marshal.ReleaseComObject(_taskpaneView);

            _taskpaneView = null;
        }

        #endregion

        #region COM Registration

        /// <summary>
        /// Регистрация плагина в реестре
        /// </summary>
        /// <param name="t"></param>
        [ComRegisterFunction()]
        private static void ComRegister(Type t)
        {
            var keyPath = $@"SOFTWARE\SolidWorks\AddIns\{t.GUID:b}";

            using (var rk = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(keyPath))
            {
                rk.SetValue(null, 1);

                rk.SetValue("Title", "Table Plugin");
                rk.SetValue("Description", "Plugin that creates 3d model of table");
            }
        }

        /// <summary>
        /// Удаление регистрации из реестра
        /// </summary>
        /// <param name="t"></param>
        [ComUnregisterFunction()]
        private static void ComUnregister(Type t)
        {
            var keyPath = $@"SOFTWARE\SolidWorks\AddIns\{t.GUID:b}";

            Microsoft.Win32.Registry.LocalMachine.DeleteSubKeyTree(keyPath);

        }

        #endregion
    }
}
