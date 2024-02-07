using System;


namespace Fitness.BL.Model
{
    public class User
    {
        public string Name { get;}
        public Gender Gender { get;}
        public DateTime BirthDate { get;}
        public double  Weight { get; set; }
        public double Heihgt { get; set; }

        public User(string name, Gender gender, DateTime birthDate, double weight, double height) {
            #region Валидация входящих данных
            if (string.IsNullOrWhiteSpace(name)) {
                throw new ArgumentNullException("Имя не может быть пустым", nameof(name));
            }
            if(gender == null)
            {
                throw new ArgumentNullException("Пол не может быть пустым", nameof(gender));
            }
            if (birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.UtcNow ) {
                throw new ArgumentException("Невозможная дата рождения", nameof(birthDate)); }

            if(weight <= 0) {
                throw new ArgumentException("Некорректный вес", nameof(weight));
            }
        
            if(height <= 0)
            {
                throw new ArgumentException("Некорректный рост", nameof(height));
            }
            #endregion
            Gender = gender;
            Name = name;
            BirthDate = birthDate;
            Weight = weight;
            Heihgt = height;
             
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
