﻿#region License
// Author: Nate Kohari <nate@enkari.com>
// Copyright (c) 2007-2009, Enkari, Ltd.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion
#region Using Directives
using System;
using System.Reflection;
using Ninject.Components;
using Ninject.Infrastructure.Language;
#endregion

namespace Ninject.Selection.Heuristics
{
	/// <summary>
	/// Determines whether methods should be injected during activation by checking
	/// if they are decorated with an injection marker attribute.
	/// </summary>
	public class StandardMethodInjectionHeuristic : NinjectComponent, IMethodInjectionHeuristic
	{
		/// <summary>
		/// Returns a value indicating whether the specified method should be injected.
		/// </summary>
		/// <param name="method">The method.</param>
		/// <returns><c>True</c> if the method should be injected; otherwise <c>false</c>.</returns>
		public bool ShouldInject(MethodInfo method)
		{
			return method.HasAttribute(Kernel.Settings.InjectAttribute);
		}
	}
}