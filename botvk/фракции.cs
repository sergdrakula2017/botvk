using System;
using System.Collections.Generic;
using System.Text;

namespace botvk
{
    [Serializable]
     class фракции
    {
        public string namefr;
        private string _tag;
        public  string teg
        {
            get => _tag;
            set
            {
                if (value is null) throw new ArgumentNullException(nameof(value)/* ,"Тег не может быть ссылкой, не указывающим на экземпляр объекта"*/);
                /*foreach (char bukva in teg)
                {
                    if (Char.IsUpper(bukva))
                        Console.WriteLine("{0} в верхнем регистре ", bukva);
                }*/

                if (value.Length == 3)
                    teg = value;
                else
                throw new ArgumentException("Неверная длина тега", nameof(value));

                _tag = value.ToUpperInvariant();
            }
            
        }
        public string spec;
        public string uchast;
        public string rang;

        public фракции(string namefr, string teg)
        {
            this.namefr = namefr;
            this.teg = teg;

        }
        public override string ToString() => teg + "." + namefr;


    }
/*
    Фракция:
1. Название
2. Тег(3 заглавных символа)
3. Специализация(напишу отдельно варианты)
4. Участники(напишу отдельно структуру)
5. Ранги(разделяются на рядовых офицеров и лидера), может быть разное кол-во, от 3 до 255
*/
}
