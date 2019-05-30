﻿using OmniCore.Model.Interfaces;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace OmniCore.Model.Eros
{
    public class ErosPodUserSettings : IPodUserSettings
    {
        [PrimaryKey, AutoIncrement]
        public uint? Id { get; set; }

        public DateTime Created { get; set; }
        public Guid PodId { get; set; }
        public decimal? ReservoirWarningAtLevel { get; set; }
        public int? ExpiryWarningAtMinute { get; set; }
    }
}