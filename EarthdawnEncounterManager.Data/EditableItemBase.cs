// <copyright file="EditableItemBase.cs" company="CHSInc">
// © 2014 CHS Inc.
// </copyright>
// <author>AWallest</author>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthdawnEncounterManager.Data
{
    public abstract class EditableItemBase
    {
        public bool IsDirty { get; set; }

        public bool IsNew { get; set; }
    }
}
