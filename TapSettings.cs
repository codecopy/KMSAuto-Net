﻿// Decompiled with JetBrains decompiler
// Type: KMSAuto_Net.TapSettings
// Assembly: KMSAuto Net, Version=1.3.9.0, Culture=neutral, PublicKeyToken=334b8937f48b3142
// MVID: 4B7D3064-FB93-447A-8F9C-DC4A190A5ACC
// Assembly location: D:\Desktop\KMSAuto Net-cleaned-cleaned.exe

using KMSAuto_Net.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace KMSAuto_Net
{
  [DesignerGenerated]
  public class TapSettings : Form
  {
    private IContainer components;

    public TapSettings()
    {
      this.Load += new EventHandler(this.TAPSettings_Load);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TapSettings));
      this.Button1 = new Button();
      this.Button2 = new Button();
      this.SuspendLayout();
      this.Button1.Location = new Point(49, 16);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(227, 23);
      this.Button1.TabIndex = 0;
      this.Button1.Text = "Button1";
      this.Button1.UseVisualStyleBackColor = true;
      this.Button2.Location = new Point(49, 57);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(227, 23);
      this.Button2.TabIndex = 1;
      this.Button2.Text = "Button2";
      this.Button2.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(325, 98);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.Button1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "TAPSettings";
      this.StartPosition = FormStartPosition.Manual;
      this.Text = "TAPSettings";
      this.ResumeLayout(false);
    }

    internal virtual Button Button1
    {
      get
      {
        return this._Button1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        Button button1_1 = this._Button1;
        if (button1_1 != null)
          button1_1.Click -= eventHandler;
        this._Button1 = value;
        Button button1_2 = this._Button1;
        if (button1_2 == null)
          return;
        button1_2.Click += eventHandler;
      }
    }

    internal virtual Button Button2
    {
      get
      {
        return this._Button2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        Button button2_1 = this._Button2;
        if (button2_1 != null)
          button2_1.Click -= eventHandler;
        this._Button2 = value;
        Button button2_2 = this._Button2;
        if (button2_2 == null)
          return;
        button2_2.Click += eventHandler;
      }
    }

    private void TAPSettings_Load(object sender, EventArgs e)
    {
      this.Text = Lang.TabPageText2 + " TAP";
      this.Button1.Text = Lang.TapAllDelTxt;
      this.Button2.Text = Lang.Tap2AllDelTxt;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      string tapType = MyProject.Forms.Form1.TapType;
      MyProject.Forms.Form1.TapType = "TAP1";
      MyProject.Forms.Form1.UnInstallTap();
      MyProject.Forms.Form1.TapType = "";
      this.Close();
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      string tapType = MyProject.Forms.Form1.TapType;
      MyProject.Forms.Form1.TapType = "TAP2";
      MyProject.Forms.Form1.UnInstallTap();
      MyProject.Forms.Form1.TapType = "";
      this.Close();
    }
  }
}