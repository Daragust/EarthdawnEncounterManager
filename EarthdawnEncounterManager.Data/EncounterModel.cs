// <copyright file="EncounterModel.cs" company="CHSInc">
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
    public class EncounterModel : EditableItemBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public List<EncounterEnemyModel> Enemies { get; set; }
        public bool Completed { get; set; }
    }
}
