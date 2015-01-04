﻿using System;
using System.Collections.Generic;

using SharpDX;

namespace PoeHUD.Hud.Interfaces
{
    public interface IPlugin : IDisposable
    {
        void Render(Dictionary<UiMountPoint, Vector2> mountPoints);
    }
}