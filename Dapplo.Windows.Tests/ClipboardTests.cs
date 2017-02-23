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

using System.Threading.Tasks;
using Dapplo.Log;
using Dapplo.Log.XUnit;
using Dapplo.Windows.Clipboard;
using Xunit;
using Xunit.Abstractions;
using System;

#endregion

namespace Dapplo.Windows.Tests
{
	public class ClipboardTests
	{
		private static readonly LogSource Log = new LogSource();

		public ClipboardTests(ITestOutputHelper testOutputHelper)
		{
			LogSettings.RegisterDefaultLogger<XUnitLogger>(LogLevels.Verbose, testOutputHelper);
		}

		/// <summary>
		///     Test monitoring the clipboard
		/// </summary>
		/// <returns></returns>
		[WpfFact]
		private async Task TestClipboardMonitor()
		{
			bool hasNewContent = false;
			var subscription = ClipboardMonitor.ClipboardUpdateEvents.Subscribe(args =>
			{
				Log.Debug().WriteLine("Detected change.");
				hasNewContent = true;
			});

			System.Windows.Clipboard.SetText("Dapplo.Windows.Tests.ClipboardTests");
			await Task.Delay(1000);
			subscription.Dispose();

			// Doesn't work!!
			Assert.True(hasNewContent);
		}
	}
}