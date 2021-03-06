//     Copyright (C) 2016 Rethought
// 
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 
//     Created: 04.10.2016 1:05 PM
//     Last Edited: 04.10.2016 1:44 PM

using EloBuddy; 
using LeagueSharp.Common; 
namespace RethoughtLib.FeatureSystem.Implementations
{
    #region Using Directives

    using System;

    using RethoughtLib.FeatureSystem.Abstract_Classes;

    #endregion

    public sealed class SuperParent : SuperParentBase
    {
        #region Constructors and Destructors

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="SuperParent" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public SuperParent(string name)
        {
            this.Name = name;
        }

        #endregion

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>
        ///     The name.
        /// </value>
        public override string Name { get; set; }

        #endregion

        #region Methods

        /// <summary>
        ///     Raises the <see cref="E:ChildAddInvoker" /> event.
        /// </summary>
        /// <param name="eventArgs">The <see cref="PareParentBaseentBaseEventArgs" /> instance containing the event data.</param>
        protected override void OnChildAddInvoker(ParentBaseEventArgs eventArgs)
        {
            if (eventArgs.Child is SuperParent) throw new InvalidOperationException("A Super-Parent can't add other Super-Parents");

            base.OnChildAddInvoker(eventArgs);
        }

        #endregion
    }
}