﻿// <copyright file="PKClearChatCommandArgs.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameLogic.PlugIns.ChatCommands.Arguments
{
    /// <summary>
    /// Arguments used by PKClearChatCommandPlugIn.
    /// </summary>
    public class PKClearChatCommandArgs : ArgumentsBase
    {
        /// <summary>
        /// Gets or sets the character name.
        /// </summary>
        [Argument("characterName")]
        public string? CharacterName { get; set; }
    }
}