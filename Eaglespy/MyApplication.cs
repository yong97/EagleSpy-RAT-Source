using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x020000EB RID: 235
[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class MyApplication : WindowsFormsApplicationBase
{
	// Token: 0x06000952 RID: 2386 RVA: 0x000DF600 File Offset: 0x000DD800
	[STAThread]
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static void Main(string[] Args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
		}
		finally
		{
		}
		WindowsFormsApplicationBase application = MyProject.Application;
		global::SplashScreen.Execute();
		application.Run(Args);
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x000DF63C File Offset: 0x000DD83C
	public string ExceptionToString(Exception ex)
	{
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		try
		{
			text2 = "";
		}
		catch (Exception ex2)
		{
		}
		try
		{
			text3 = "";
		}
		catch (Exception ex3)
		{
		}
		try
		{
			text4 = "";
		}
		catch (Exception ex4)
		{
		}
		try
		{
			text5 = "";
		}
		catch (Exception ex5)
		{
		}
		checked
		{
			try
			{
				string left = "";
				int count = ex.Data.Keys.Count;
				for (int num = 0; num <= count; num++)
				{
					try
					{
						left = Conversions.ToString(Operators.ConcatenateObject(left, Operators.ConcatenateObject(ex.Data[RuntimeHelpers.GetObjectValue(ex.Data.Keys.Cast<object>().ElementAtOrDefault(num))], "\r\n")));
					}
					catch (Exception ex6)
					{
					}
				}
				text6 = "";
			}
			catch (Exception ex7)
			{
			}
			return string.Concat(new string[]
			{
				text,
				text2,
				text3,
				text4,
				text5,
				text6
			});
		}
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x000DF7EC File Offset: 0x000DD9EC
	private void MyApplication_Startup(object sender, StartupEventArgs e)
	{
		try
		{
			if (Directory.Exists(Path.GetTempPath() + "CP"))
			{
				Directory.Delete(Path.GetTempPath() + "CP", true);
			}
		}
		catch (Exception ex)
		{
		}
		try
		{
			if (Directory.Exists(Path.GetTempPath() + "UPATER"))
			{
				Directory.Delete(Path.GetTempPath() + "UPATER", true);
			}
		}
		catch (Exception ex2)
		{
		}
		try
		{
			if (File.Exists(Path.GetTempPath() + "UPATER.zip"))
			{
				File.Delete(Path.GetTempPath() + "UPATER.zip");
			}
		}
		catch (Exception ex3)
		{
		}
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x000DF8D8 File Offset: 0x000DDAD8
	private void MyApplication_UnhandledException(object sender, Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e)
	{
		if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Errorlogs.txt"))
		{
			File.Create(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Errorlogs.txt").Dispose();
		}
		try
		{
		}
		catch (Exception ex)
		{
		}
		try
		{
		}
		catch (Exception ex2)
		{
		}
		try
		{
		}
		catch (Exception ex3)
		{
		}
		try
		{
			string message = e.Exception.InnerException.Message;
		}
		catch (Exception ex4)
		{
		}
		try
		{
		}
		catch (Exception ex5)
		{
		}
		try
		{
		}
		catch (Exception ex6)
		{
		}
		Interaction.MsgBox("Unhandled Exception ", MsgBoxStyle.OkOnly, null);
		e.ExitApplication = true;
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x000DFA10 File Offset: 0x000DDC10
	[DebuggerStepThrough]
	public MyApplication() : base(AuthenticationMode.Windows)
	{
		base.Startup += this.MyApplication_Startup;
		base.UnhandledException += this.MyApplication_UnhandledException;
		base.IsSingleInstance = false;
		base.EnableVisualStyles = true;
		base.SaveMySettingsOnExit = true;
		base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
	}

	// Token: 0x06000957 RID: 2391 RVA: 0x00003D00 File Offset: 0x00001F00
	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		base.MainForm = MyProject.Forms.CraxsRatMain;
	}

	// Token: 0x06000958 RID: 2392 RVA: 0x000DFA64 File Offset: 0x000DDC64
	[DebuggerStepThrough]
	protected override bool OnInitialize(ReadOnlyCollection<string> commandLineArgs)
	{
		base.MinimumSplashScreenDisplayTime = 0;
		return base.OnInitialize(commandLineArgs);
	}
}
