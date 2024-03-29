﻿using System;


namespace Fitness.BL.Model
{  /// <summary>
///  Пол.
/// </summary>
    public class Gender
    {/// <summary>
    /// Название пола
    /// </summary>
        public string Name { get; }

        public Gender (string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пола не может быть пустым", nameof(name));
            }
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
