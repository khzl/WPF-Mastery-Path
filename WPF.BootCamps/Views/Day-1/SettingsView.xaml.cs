using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF.BootCamps.Views
{
    /// <summary>
    /// Interaction logic for SettingsView.xaml
    /// </summary>
    public partial class SettingsView : Window
    {
        public SettingsView()
        {
            InitializeComponent();
            //LoadSettings();
        }

        // procedure Load Settings
        private void LoadSettings()
        {
            // هنا يمكن تحميل الإعدادات من ملف أو قاعدة بيانات
            // هذه قيم افتراضية للعرض
            rbLight.IsChecked = true;
            cmbPrimaryColor.SelectedIndex = 0;
            chkAccentColor.IsChecked = false;
            cmbFont.SelectedIndex = 0;
            sldFontSize.Value = 14;

            rbArabic.IsChecked = true;
            chkAutoTranslate.IsChecked = false;
            chkShowOriginal.IsChecked = true;
            cmbDateFormat.SelectedIndex = 0;
            cmbTimeFormat.SelectedIndex = 0;

            chkStartWithWindows.IsChecked = false;
            chkMinimizeToTray.IsChecked = true;
            chkShowSplashScreen.IsChecked = true;
            chkShowNotifications.IsChecked = true;
            chkSoundNotifications.IsChecked = false;
            chkToastNotifications.IsChecked = true;
            chkAutoUpdate.IsChecked = true;
            rbUpdateStable.IsChecked = true;
            chkAutoBackup.IsChecked = false;
            txtBackupInterval.Text = "7";
        }


        // procedure SaveSettings
        private void SaveSettings()
        {
            // هنا يمكن حفظ الإعدادات في ملف أو قاعدة بيانات

            // مثال لحفظ إعدادات المظهر
            string theme = rbLight.IsChecked == true ? "فاتح" :
                          rbDark.IsChecked == true ? "داكن" : "تلقائي";

            // Use null-conditional and null-coalescing operators to avoid CS8600 and unnecessary assignment (IDE0059)
            string? primaryColor = (cmbPrimaryColor.SelectedItem as ComboBoxItem)?.Content?.ToString();
            bool useAccentColor = chkAccentColor.IsChecked == true;

            // مثال لحفظ إعدادات اللغة
            string language = rbArabic.IsChecked == true ? "العربية" :
                             rbEnglish.IsChecked == true ? "الإنجليزية" : "الفرنسية";

            string? dateFormat = (cmbDateFormat.SelectedItem as ComboBoxItem)?.Content?.ToString();
            string? timeFormat = (cmbTimeFormat.SelectedItem as ComboBoxItem)?.Content?.ToString();

            // يمكنك إضافة منطق الحفظ هنا
            // مثل: حفظ في ملف XML أو JSON أو قاعدة بيانات
        }

        // Event handler
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveSettings();
            MessageBox.Show("تم حفظ الإعدادات بنجاح", "حفظ",
               MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }

        // Event Handler
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("هل تريد إلغاء التغييرات؟", "تأكيد",
               MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        // Event Handler
        private void BtnApply_Click(object sender, RoutedEventArgs e)
        {
            SaveSettings();
            MessageBox.Show("تم تطبيق الإعدادات بنجاح", "تطبيق",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Event Handler
        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("هل تريد إعادة تعيين جميع الإعدادات إلى القيم الافتراضية؟",
                "تأكيد إعادة التعيين",
                MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                LoadSettings();
                MessageBox.Show("تم إعادة تعيين الإعدادات", "إعادة تعيين",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

    }
}
