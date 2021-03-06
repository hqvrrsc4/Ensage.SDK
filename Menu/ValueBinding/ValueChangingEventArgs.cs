﻿// <copyright file="ValueChangedEventArgs.cs" company="Ensage">
//    Copyright (c) 2018 Ensage.
// </copyright>

namespace Ensage.SDK.Menu.ValueBinding
{
    using System;

    public class ValueChangingEventArgs<T> : EventArgs
    {
        public ValueChangingEventArgs(T value, T oldValue)
        {
            this.Value = value;
            this.OldValue = oldValue;
            this.Process = true;
        }

        public T OldValue { get; }

        public bool Process { get; set; }

        public T Value { get; }
    }
}