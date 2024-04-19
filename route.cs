//Copyright (C) 2002 Microsoft Corporation
//All rights reserved.
//THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER 
//EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF 
//MERCHANTIBILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
//Requires the Trial or Release version of Visual Studio .NET Professional (or greater).

using System;

public class frmTaskProgress : System.Windows.Forms.Form
{

#region " Windows Form Designer generated code "

	public frmTaskProgress()
	{
        //This call is required by the Windows Form Designer.
        InitializeComponent();
		//Add any initialization after the InitializeComponent() call
    }

    //Form overrides dispose to clean up the component list.
    protected override void Dispose(bool disposing)
	{
        if(disposing)
		{
            if (components != null) {
                components.Dispose();
            }
        }

        base.Dispose(disposing);
    }

    //Required by the Windows Form Designer
    private System.ComponentModel.IContainer components;

    //NOTE: The following procedure is required by the Windows Form Designer
    //It can be modified using the Windows Form Designer.  
    //Do not modify it using the code editor.

	public System.Windows.Forms.ProgressBar prgTaskProgress;
    private System.Windows.Forms.Label lblLengthyTask;
    private System.Windows.Forms.Label lblThreadID;

    private void InitializeComponent()
	{
		System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmTaskProgress));

		this.prgTaskProgress = new System.Windows.Forms.ProgressBar();
		this.lblLengthyTask = new System.Windows.Forms.Label();
		this.lblThreadID = new System.Windows.Forms.Label();
		this.SuspendLayout();

		//
		//prgTaskProgress
		//
		this.prgTaskProgress.Location = new System.Drawing.Point(32, 40);
		this.prgTaskProgress.Name = "prgTaskProgress";
		this.prgTaskProgress.Size = new System.Drawing.Size(216, 24);
		this.prgTaskProgress.TabIndex = 0;
		//
		//lblLengthyTask
		//
		this.lblLengthyTask.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) 8.25, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
		this.lblLengthyTask.Location = new System.Drawing.Point(56, 72);
		this.lblLengthyTask.Name = "lblLengthyTask";
		this.lblLengthyTask.Size = new System.Drawing.Size(184, 16);
		this.lblLengthyTask.TabIndex = 1;
		this.lblLengthyTask.Text = "Executing some lengthy task...";
		//
		//lblThreadID
		//
		this.lblThreadID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
		this.lblThreadID.Location = new System.Drawing.Point(32, 8);
		this.lblThreadID.Name = "lblThreadID";
		this.lblThreadID.Size = new System.Drawing.Size(272, 24);
		this.lblThreadID.TabIndex = 5;
		this.lblThreadID.Text = "This window is being serviced by thread: ";
		//
		//frmTaskProgress
		//
		this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		this.ClientSize = new System.Drawing.Size(292, 101);
		this.Controls.AddRange(new System.Windows.Forms.Control[] {this.lblThreadID, this.lblLengthyTask, this.prgTaskProgress});
		this.Icon = (System.Drawing.Icon) resources.GetObject("$this.Icon");
		this.Name = "frmTaskProgress";
		this.Text = "Task Progress";
		this.ResumeLayout(false);
		this.Load += new System.EventHandler(this.frmTaskProgress_Load);
	}
#endregion

	private void frmTaskProgress_Load(object sender, System.EventArgs e) 
	{
		//Display the ID of the thread that is loading this form.
		this.lblThreadID.Text += System.AppDomain.GetCurrentThreadId().ToString();
	}
}

