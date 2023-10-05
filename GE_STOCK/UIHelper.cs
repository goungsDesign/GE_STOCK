using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GE_STOCK.Models;

namespace GE_STOCK
{
    internal class UIHelper
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public static void LogIncident(Exception ex)
        {
            File.AppendAllText(Application.LocalUserAppDataPath + "\\culstomer_log.txt", $"{Environment.NewLine}{DateTime.Now}:{ex.Message}");
        }
        public static void CopyToExcel(DataGridView dataGridView)
        {
            //dataGridView.SelectAll();
            //DataObject dataObj = dataGridView.GetClipboardContent();
            //if (dataObj != null)
            //    Clipboard.SetDataObject(dataObj);
            //Microsoft.Office.Interop.Excel.Application xlexcel;
            //Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            //Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;
            //xlexcel = new Microsoft.Office.Interop.Excel.Application();
            //xlexcel.Visible = true;
            //xlWorkBook = xlexcel.Workbooks.Add(misValue);
            //xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            //CR.Select();
            //xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
        /// <summary>
        /// Renvoit une valeur representant la valeur entière saisie dans la 
        /// zonne de texte fournit en paramètre
        /// </summary>
        /// <param name="textBox">Nom d'une zone de Texte</param>
        /// <returns>La valeur entière saisie ou zéro si aucune valeur n'a été saisie/returns>
        /// <exception cref="Exception">Valeur invalide est levée lorsque 
        /// autre chose qu'un entier est saisie</exception>
        public static int getTxtTypedValue(TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
                return 0;
            foreach (var item in textBox.Text)
            {
                if (!char.IsDigit(item))
                    throw new Exception("Valeur invalide!");
            }
            return Convert.ToInt32(textBox.Text);
        }
        static User _currentUser;
        public static User getCurrentUser()
        {
            return _currentUser;
        }
        public static void setCurrentUser(User user)
        {
            _currentUser= user;
        }
    }
}

