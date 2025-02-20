﻿using MiniMapLibrary;
using MiniMapLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace MiniMapMod.wrappers
{
    public class SettingConfigGroup : ISettingConfigGroup
    {
        public SettingConfigGroup(IConfigEntry<bool> enabled, IConfigEntry<float> height, IConfigEntry<float> width, IConfigEntry<Color> activeColor, IConfigEntry<Color> inactiveColor, IConfigEntry<string> iconPath)
        {
            Enabled = enabled;
            Height = height;
            Width = width;
            ActiveColor = activeColor;
            InactiveColor = inactiveColor;
            IconPath = iconPath;
        }

        public IConfigEntry<bool> Enabled { get; }
        public IConfigEntry<float> Height { get; }
        public IConfigEntry<float> Width { get; }
        public IConfigEntry<Color> ActiveColor { get; }
        public IConfigEntry<Color> InactiveColor { get; }
        public IConfigEntry<string> IconPath { get; }
    }
}
