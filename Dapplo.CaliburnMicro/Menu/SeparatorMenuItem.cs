﻿#region Dapplo 2016 - GNU Lesser General Public License

// Dapplo - building blocks for .NET applications
// Copyright (C) 2016 Dapplo
// 
// For more information see: http://dapplo.net/
// Dapplo repositories are hosted on GitHub: https://github.com/dapplo
// 
// This file is part of Dapplo.CaliburnMicro
// 
// Dapplo.CaliburnMicro is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Dapplo.CaliburnMicro is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have a copy of the GNU Lesser General Public License
// along with Dapplo.CaliburnMicro. If not, see <http://www.gnu.org/licenses/lgpl.txt>.

#endregion

#region Usings

using System;

#endregion

namespace Dapplo.CaliburnMicro.Menu
{
	/// <summary>
	///     Extend or provide this to have a separator
	/// </summary>
	public class SeparatorMenuItem : MenuItem
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public SeparatorMenuItem()
		{
			IsSeparator = true;
		}

		/// <summary>
		///     Is called when the IMenuItem it clicked, but doesn't make sense for a separator
		/// </summary>
		public override void Click(IMenuItem clickedItem)
		{
			throw new NotImplementedException();
		}
	}
}