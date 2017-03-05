﻿//  Dapplo - building blocks for desktop applications
//  Copyright (C) 2016-2017 Dapplo
// 
//  For more information see: http://dapplo.net/
//  Dapplo repositories are hosted on GitHub: https://github.com/dapplo
// 
//  This file is part of Dapplo.Windows
// 
//  Dapplo.Windows is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  Dapplo.Windows is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
// 
//  You should have a copy of the GNU Lesser General Public License
//  along with Dapplo.Windows. If not, see <http://www.gnu.org/licenses/lgpl.txt>.

#region using

using System;

#endregion

namespace Dapplo.Windows
{
	/// <summary>
	///     Extension methods to test the windows version
	/// </summary>
	public static class WindowsVersion
	{
		private static readonly Version WinVersion;

		static WindowsVersion()
		{
			WinVersion = Environment.OSVersion.Version;
		}

		/// <summary>
		///     Test if the current OS is Windows 10
		/// </summary>
		/// <returns>true if we are running on Windows 10</returns>
		public static bool IsWindows10 => WinVersion.Major == 10;

		/// <summary>
		///     Test if the current OS is Windows 10 or later
		/// </summary>
		/// <returns>true if we are running on Windows 10 or later</returns>
		public static bool IsWindows10OrLater => WinVersion.Major >= 10;

		/// <summary>
		///     Test if the current OS is Windows 7 or later
		/// </summary>
		/// <returns>true if we are running on Windows 7 or later</returns>
		public static bool IsWindows7OrLater => WinVersion.Major == 6 && WinVersion.Minor >= 1 || WinVersion.Major > 6;

		/// <summary>
		///     Test if the current OS is Windows 8.0
		/// </summary>
		/// <returns>true if we are running on Windows 8.0</returns>
		public static bool IsWindows8 => WinVersion.Major == 6 && WinVersion.Minor == 2;

		/// <summary>
		///     Test if the current OS is Windows 8(.1)
		/// </summary>
		/// <returns>true if we are running on Windows 8(.1)</returns>
		public static bool IsWindows81 => WinVersion.Major == 6 && WinVersion.Minor == 3;

		/// <summary>
		///     Test if the current OS is Windows 8 or later
		/// </summary>
		/// <returns>true if we are running on Windows 8 or later</returns>
		public static bool IsWindows8OrLater => (WinVersion.Major == 6 && WinVersion.Minor >= 2) || WinVersion.Major > 6;

		/// <summary>
		///     Test if the current OS is Windows 8.1 or later
		/// </summary>
		/// <returns>true if we are running on Windows 8.1 or later</returns>
		public static bool IsWindows81OrLater => (WinVersion.Major == 6 && WinVersion.Minor >= 3) || WinVersion.Major > 6;

		/// <summary>
		///     Test if the current OS is Windows Vista or later
		/// </summary>
		/// <returns>true if we are running on Windows Vista or later</returns>
		public static bool IsWindowsVistaOrLater => WinVersion.Major >= 6;

		/// <summary>
		///     Test if the current OS is Windows Vista
		/// </summary>
		/// <returns>true if we are running on Windows Vista or later</returns>
		public static bool IsWindowsVista => WinVersion.Major >= 6 && WinVersion.Minor == 0;

		/// <summary>
		///     Test if the current OS is Windows XP or later
		/// </summary>
		/// <returns>true if we are running on Windows XP or later</returns>
		public static bool IsWindowsXpOrLater => WinVersion.Major >= 5 || WinVersion.Major == 5 && WinVersion.Minor >= 1;

		/// <summary>
		///     Test if the current OS is Windows XP
		/// </summary>
		/// <returns>true if we are running on Windows XP or later</returns>
		public static bool IsWindowsXp => WinVersion.Major == 5 && WinVersion.Minor >= 1;
	}
}