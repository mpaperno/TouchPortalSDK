﻿using System;
using TouchPortalSDK.Messages.Items;

namespace TouchPortalSDK.Messages.Commands
{
    public class SettingUpdateCommand : ITouchPortalMessage
    {
        public string Type => "settingUpdate";

        public string Name { get; set; }

        public string Value { get; set; }

        public SettingUpdateCommand(string name, string value)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));

            Name = name;
            Value = value ?? string.Empty;
        }

        public Identifier GetIdentifier()
            => new Identifier(Type, Name, default);
    }
}
