﻿using System;

namespace ExCSS.Model
{
    /// <summary>
    /// The delimiter token that contains a series of characters.
    /// </summary>
    sealed class DelimBlock : CharacterBlock
    {
        #region ctor

        /// <summary>
        /// Creates a new delimiter token.
        /// </summary>
        public DelimBlock()
        {
            _type = GrammarSegment.Delimiter;
        }

        /// <summary>
        /// Creates a new delimiter token with the given character.
        /// </summary>
        /// <param name="value">The character.</param>
        public DelimBlock(Char value)
            : base(value)
        {
            _type = GrammarSegment.Delimiter;
        }

        #endregion

        #region string Representation

        /// <summary>
        /// Gets a string which represents the original value.
        /// </summary>
        /// <returns>The original value.</returns>
        public override string ToValue()
        {
            return Value.ToString();
        }

        #endregion
    }
}
