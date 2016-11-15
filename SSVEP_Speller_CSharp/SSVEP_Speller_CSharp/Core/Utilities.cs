using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;


namespace SSVEP_Speller_CSharp
{
    // Custom Struct to hold the Speller configurations
    public struct Speller_Parms
    {
        // user defined
        public int num_targets;
        public int stimulus_duration;
        public float DEFAULT_PHASE;
        public int SCREEN_WIDTH, SCREEN_HEIGHT;
        public int refresh_rate, code_length;
        public double min_freq, freq_resol, min_phase, phase_resol;
        public string waveform, stim_shape;
        public int num_column, num_row;
        public int left_right_margin, inter_stimulus_spacing;
        public bool debug;

        public string subject_id;
        public string group_num, session_num, run_num;
        public string speller_mode, target_text, feedback;
        public string classifier, twitter_account;
        public string[] alphanumeric;

        // auto-generated
        public Stim_Design_Matrix stim_design_matrix;
    }

    public struct Stim_Design_Matrix
    {
        // stimulus matrix parms
        public int vBlocksize, hBlocksize, blocksize;
        public float dist2targ, lenside;
        public float wTxtFld, hTxtFld, locTxtFld;
        public double[] freq, phase, center_loc;
        public int[,] flicker_code;
        public Microsoft.Xna.Framework.Rectangle[] rect;
        public Microsoft.Xna.Framework.Color[,] color;
        public string[] text;
        public Microsoft.Xna.Framework.Vector2[] text_offset;
        public Microsoft.Xna.Framework.Vector2[] text_loc;
    }

    // Custom Struct to hold mouse pointer xy coordinates
    public struct MOUSEPOINT
    {
        public int X;
        public int Y;
    }

    // Class to hold win32 interoperability commands and functions 
    public class User32
    {
        [DllImport("user32.dll")]
        public static extern void SetWindowPos(uint Hwnd, int Level, int X, int Y, int W, int H, uint Flags);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("dwmapi.dll")]
        public static extern void DwmExtendFrameIntoClientArea(IntPtr hWnd, ref int[] pMargins);

        [DllImport("user32.dll")]
        public static extern int GetCursorPos(ref MOUSEPOINT mousePoint);

    }

    // Class to intercept key commands from the lowest level (useful for exit keystokes)
    public class InterceptKeys
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        public static event EventHandler KeyDown;
        public static event EventHandler KeyUp;

        // Hook to add LowLevelKeyboardProc to the process (check Program.cs)
        public static void Hook()
        {
            _hookID = SetHook(_proc);
        }

        // Unhook to remove LowLevelKeyboardProc of the process (check Program.cs)
        public static void Unhook()
        {
            UnhookWindowsHookEx(_hookID);
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(
            int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(
            int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);

                // The code bellow fires the HandleKeyDown() method defined in Game1.cs
                // with vkCode (the key that is pressed) as sender (since it's attached to KeyDown)
                EventHandler handler = KeyDown;
                if (handler != null)
                {
                    handler((Keys)vkCode, EventArgs.Empty);
                }
            }
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYUP)
            {
                int vkCode = Marshal.ReadInt32(lParam);

                EventHandler handler = KeyUp;
                if (handler != null)
                {
                    handler((Keys)vkCode, EventArgs.Empty);
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}