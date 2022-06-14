using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel;            // 추가 - Component 사용
using System.Windows.Forms;             // 추가 - Control
using System.Runtime.InteropServices;   // 추가 - Dll impor 사용




namespace CAD_Modeler
{
    class UI_EFFECT
    {


    }   // The end of public class UI_Effect

    /* ******************************************************************
     * ******************************************************************
     * 메뉴 드레그 컨트롤 사용 클래스
     * ******************************************************************
     * ****************************************************************** */
    /// <summary>
    /// 메뉴 드레그 컨트롤 사용 클래스
    /// </summary>
    class DRAG_CONTROL : Component
    {
        private Control handleControl;

        public Control SelectControl
        {
            get
            {
                return this.handleControl;
            }
            set
            {
                this.handleControl = value;
                this.handleControl.MouseDown += new MouseEventHandler(this.DragForm_MouseDown);

            }
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr a, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            Boolean flag = e.Button == MouseButtons.Left;

            if (flag)
            {
                DRAG_CONTROL.ReleaseCapture();
                DRAG_CONTROL.SendMessage(this.SelectControl.FindForm().Handle, 161, 2, 0);
            }
        }
    }
    //The end of class DRAG_CONTROL


}
