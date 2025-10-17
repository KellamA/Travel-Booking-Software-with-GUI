// <copyright file="Program.cs" company="Kellam Adams">
// Copyright (c) {CS 321 Class WSU}. All rights reserved.
// </copyright>

namespace FinalExam
{
    /// <summary>
    /// main entry point of program.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}