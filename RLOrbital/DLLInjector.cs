using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RLOrbital
{
    public class DLLInjector
    {
        static readonly IntPtr INTPTR_ZERO = IntPtr.Zero;
        static readonly uint desiredAccess = (0x2 | 0x8 | 0x10 | 0x20 | 0x400);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesWritten);


        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress,
            IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int CloseHandle(IntPtr hObject);

       public bool injectDLL(uint processToInject, string dllPath)
        {
            //if your reading this your cool af! :))
            IntPtr processHandle = OpenProcess(desiredAccess, 1, processToInject);

            if (processHandle == INTPTR_ZERO) return false; //Not exists

            IntPtr loadLibraryAddress = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");

            if (loadLibraryAddress == INTPTR_ZERO) return false;

            IntPtr argAddress = VirtualAllocEx(processHandle, (IntPtr)null, (IntPtr)dllPath.Length, (0x1000 | 0x2000), 0X40);

            if (argAddress == INTPTR_ZERO) return false;

            byte[] bytes = Encoding.ASCII.GetBytes(dllPath);

            if (WriteProcessMemory(processHandle, argAddress, bytes, (uint)bytes.Length, 0) == 0)
                return false;

            if (CreateRemoteThread(processHandle, (IntPtr)null, INTPTR_ZERO, loadLibraryAddress, argAddress, 0, (IntPtr)null) == INTPTR_ZERO)
            {
                return false;
            }

            CloseHandle(processHandle);
            return true;
        }
    }

}

