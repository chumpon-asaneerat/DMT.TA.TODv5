#region Using

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

#endregion

namespace DMT.Services
{
    /// <summary>
    /// The Command Line class.
    /// </summary>
    public class CommandLine
    {
        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        public CommandLine()
        {
            FileName = "netsh.exe";
            UseShellExecute = false;
            RedirectStandardOutput = false;
            RedirectStandardError = false;
            CreateNoWindow = true;
        }

        #endregion

        #region Public Method(s)

        /// <summary>
        /// Run (or execute) command.
        /// </summary>
        /// <param name="arguments">The command line arguments.</param>
        public void Run(string arguments)
        {
            var psi = new ProcessStartInfo();
            psi.FileName = FileName;
            psi.Arguments = arguments;
            psi.UseShellExecute = UseShellExecute;
            psi.RedirectStandardOutput = RedirectStandardOutput;
            psi.RedirectStandardError = RedirectStandardError;
            psi.CreateNoWindow = CreateNoWindow;

            using (var process = Process.Start(psi))
            {
                if (RedirectStandardOutput)
                {
                    process.OutputDataReceived += (sender, eventArgs) => Console.WriteLine("OUTPUT: " + eventArgs.Data);
                    process.BeginOutputReadLine();
                }

                if (RedirectStandardError)
                {
                    process.ErrorDataReceived += (sender, eventArgs) => Console.WriteLine("ERROR: " + eventArgs.Data);
                    process.BeginErrorReadLine();
                }

                process.WaitForExit();
            }
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets File Name.
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// Gets or sets use shell execute.
        /// </summary>
        public bool UseShellExecute { get; set; }
        /// <summary>
        /// Gets or sets is redirect standard output.
        /// </summary>
        public bool RedirectStandardOutput { get; set; }
        /// <summary>
        /// Gets or sets is redirect standard error.
        /// </summary>
        public bool RedirectStandardError { get; set; }
        /// <summary>
        /// Gets or sets create (or execute) with no window.
        /// </summary>
        public bool CreateNoWindow { get; set; }

        #endregion
    }
}
