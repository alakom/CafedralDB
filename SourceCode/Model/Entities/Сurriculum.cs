﻿using System.Collections.Generic;
using System.Text;
using System.IO;
namespace CafedralDB.SourceCode.Model.Entities
{
    internal class CurriculumDiscipline
    {
        public string Name { get;  set; }
        public string Semester { get;  set; }
        public int LabCount { get; set; }
        public int PracticeCount { get;  set; }
        public int LectureCount { get;  set; }
        public bool CourseWork { get;  set; }
        public bool Ekz { get;  set; }
        public bool Zach { get;  set; }
        public CurriculumDiscipline()
        {

        }
        public CurriculumDiscipline(string _name, string _semester, int _lectureCount, int _labCount, int _practiceCount = 0, bool _courseWork = false, bool _ekz = false, bool _zach = false)
        {
            Name = _name;
            Semester = _semester;
            LabCount = _labCount;
            PracticeCount = _practiceCount;
            LectureCount = _lectureCount;
            CourseWork = _courseWork;
            Ekz = _ekz;
            Zach = _zach;
        }

        public override bool Equals(object obj)
        {
            var compared = obj as CurriculumDiscipline;
            if (compared == null)
            {
                return false;
            }
            var props = this.GetType().GetProperties();
            foreach (var prop in props)
            {
                var val1 = prop.GetValue(this).ToString();
                var val2 = prop.GetValue(compared).ToString();
                if (val1!=val2)
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
    internal static class Сurriculum
    {
        static Dictionary<int, int> Semesters = new Dictionary<int, int>{
            {1,15 }, { 2, 15 },
            { 3, 15 }, { 4, 15 },
            { 5, 15 }, { 6, 15 },
            { 7, 15 }, { 8 , 13 },
            { 9, 12 }, { 10, 14 },
            { 11, 13 }, { 12, 10 } };
        static List<CurriculumDiscipline> Curriculums = new List<CurriculumDiscipline>() { 
            //семестр 1
        new CurriculumDiscipline(_name: "Информатика и программирование",
                _semester: "1",
                _lectureCount:1,
                _labCount:2,
                _practiceCount:0,
                _courseWork:true,
                _ekz:true,
                _zach:false),
        new CurriculumDiscipline(_name: "Введение в программную инженерию",
                _semester: "1",
                _lectureCount:1,
                _labCount:2,
                _practiceCount:0,
                _courseWork:true,
                _ekz:true,
                _zach:false),
        new CurriculumDiscipline(_name: "История вычислительной техники и программирование",
                _semester: "1",
                _lectureCount:1,
                _labCount:1,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Разработка консольных приложений",
                _semester: "1",
                _lectureCount:1,
                _labCount:2,
                _practiceCount:0,
                _courseWork:false,
                _ekz:true,
                _zach:false),
            //семестр 2
        new CurriculumDiscipline(_name: "Основы программирования",
                _semester: "2",
                _lectureCount:2,
                _labCount:2,
                _practiceCount:0,
                _courseWork:true,
                _ekz:true,
                _zach:false),
        new CurriculumDiscipline(_name: "Современные программные платформы",
                _semester: "2",
                _lectureCount:1,
                _labCount:1,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Среды разработки программных средств",
                _semester: "2",
                _lectureCount:2,
                _labCount:2,
                _practiceCount:0,
                _courseWork:true,
                _ekz:true,
                _zach:false),
        new CurriculumDiscipline(_name: "Учебная практика, ознакомительная",
                _semester: "2",
                _lectureCount:0,
                _labCount:0,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:false
                //_isPractice:true
            ),
        // 3 семестр
        new CurriculumDiscipline(_name: "Компьютерная математика",
                _semester: "3",
                _lectureCount:1,
                _labCount:0,
                _practiceCount:1,
                _courseWork:false,
                _ekz:true,
                _zach:false),
        new CurriculumDiscipline(_name: "Структуры и алгоритмы обработки данных",
                _semester: "3",
                _lectureCount:1,
                _labCount:2,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Теоретическая информатика",
                _semester: "3",
                _lectureCount:1,
                _labCount:2,
                _practiceCount:0,
                _courseWork:true,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Объектно-ориентированное программирование",
                _semester: "3",
                _lectureCount:1,
                _labCount:2,
                _practiceCount:0,
                _courseWork:true,
                _ekz:true,
                _zach:false),
        new CurriculumDiscipline(_name: "Основы программирования",
                _semester: "3",
                _lectureCount:1,
                _labCount:2,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:true),
            //СЕМЕСТР 4
        new CurriculumDiscipline(_name: "Компьютерная математика",
                _semester: "4",
                _lectureCount:1,
                _labCount:2,
                _practiceCount:0,
                _courseWork:false,
                _ekz:true,
                _zach:false),
        new CurriculumDiscipline(_name: "Структуры и алгоритмы обработки данных",
                _semester: "4",
                _lectureCount:2,
                _labCount:2,
                _practiceCount:0,
                _courseWork:true,
                _ekz:true,
                _zach:false),
        new CurriculumDiscipline(_name: "Объектно-ориентированное программирование",
                _semester: "4",
                _lectureCount:2,
                _labCount:1,
                _practiceCount:0,
                _courseWork:false,
                _ekz:true,
                _zach:false),
        new CurriculumDiscipline(_name: "Базы данных",
                _semester: "4",
                _lectureCount:2,
                _labCount:2,
                _practiceCount:0,
                _courseWork:true,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Унифицированный язык моделирования UML",
                _semester: "4",
                _lectureCount:1,
                _labCount:1,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Архитектура вычислительных систем",
                _semester: "4",
                _lectureCount:2,
                _labCount:2,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Производственная практика, проектно-технологическая",
                _semester: "4",
                _lectureCount:0,
                _labCount:0,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:false
                //_isPractice:true
            ),
            //семестр 5
        new CurriculumDiscipline(_name: "Базы данных",
                _semester: "5",
                _lectureCount:1,
                _labCount:2,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Теория алгоритмов",
                _semester: "5",
                _lectureCount:1,
                _labCount:0,
                _practiceCount:1,
                _courseWork:true,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Операционные системы и сети",
                _semester: "5",
                _lectureCount:2,
                _labCount:2,
                _practiceCount:0,
                _courseWork:true,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Проектирование и архитектура программных систем",
                _semester: "5",
                _lectureCount:2,
                _labCount:1,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Основы компьютерных вычислений",
                _semester: "5",
                _lectureCount:2,
                _labCount:2,
                _practiceCount:0,
                _courseWork:false,
                _ekz:true,
                _zach:false),
        new CurriculumDiscipline(_name: "Разработка мобильных приложений для Android",
                _semester: "5",
                _lectureCount:2,
                _labCount:1,
                _practiceCount:0,
                _courseWork:false,
                _ekz:true,
                _zach:false),
            //семестр 6
        new CurriculumDiscipline(_name: "Теория автоматов и формальных языков",
                _semester: "6",
                _lectureCount:2,
                _labCount:2,
                _practiceCount:0,
                _courseWork:true,
                _ekz:true,
                _zach:false),
        new CurriculumDiscipline(_name: "Тестирование программного обеспечения",
                _semester: "6",
                _lectureCount:1,
                _labCount:2,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Объектно-ориентированное программирование экономических информационных систем",
                _semester: "6",
                _lectureCount:2,
                _labCount:2,
                _practiceCount:0,
                _courseWork:false,
                _ekz:true,
                _zach:false),
        new CurriculumDiscipline(_name: "Компьютерные системы моделирования",
                _semester: "6",
                _lectureCount:1,
                _labCount:2,
                _practiceCount:0,
                _courseWork:false,
                _ekz:true,
                _zach:false),
        new CurriculumDiscipline(_name: "Основы компьютерных вычислений",
                _semester: "6",
                _lectureCount:2,
                _labCount:2,
                _practiceCount:0,
                _courseWork:false,
                _ekz:true,
                _zach:false),
        new CurriculumDiscipline(_name: "Инструментальные программные средства для разработки автоматизированных систем в промышленности",
                _semester: "6",
                _lectureCount:1,
                _labCount:2,
                _practiceCount:0,
                _courseWork:true,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Параллельные вычисления",
                _semester: "6",
                _lectureCount:2,
                _labCount:2,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Производственная  практика, проектная",
                _semester: "6",
                _lectureCount:0,
                _labCount:0,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:false
                //_isPractice:true
            ),
            // Семестр 7
        new CurriculumDiscipline(_name: "Объектно-ориентированное программирование экономических информационных систем",
                _semester: "7",
                _lectureCount:2,
                _labCount:2,
                _practiceCount:0,
                _courseWork:true,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Системы искусственного интеллекта",
                _semester: "7",
                _lectureCount:2,
                _labCount:2,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Web-программирование",
                _semester: "7",
                _lectureCount:2,
                _labCount:2,
                _practiceCount:0,
                _courseWork:false,
                _ekz:true,
                _zach:false),
        new CurriculumDiscipline(_name: "Параллельные вычисления",
                _semester: "7",
                _lectureCount:2,
                _labCount:2,
                _practiceCount:0,
                _courseWork:false,
                _ekz:true,
                _zach:false),
        new CurriculumDiscipline(_name: "Проектирование человеко-машинного интерфейса",
                _semester: "7",
                _lectureCount:1,
                _labCount:1,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Разработка и анализ требований",
                _semester: "7",
                _lectureCount:1,
                _labCount:2,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Теория языков программирования и методы трансляции",
                _semester: "7",
                _lectureCount:2,
                _labCount:2,
                _practiceCount:0,
                _courseWork:true,
                _ekz:true,
                _zach:false),

            //Семестр 8
        new CurriculumDiscipline(_name: "Системы искусственного интеллекта",
                _semester: "8",
                _lectureCount:2,
                _labCount:2,
                _practiceCount:0,
                _courseWork:true,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Управление программными проектами",
                _semester: "8",
                _lectureCount:1,
                _labCount:1,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Теория вычислительных процессов",
                _semester: "8",
                _lectureCount:2,
                _labCount:2,
                _practiceCount:0,
                _courseWork:true,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Защита информации",
                _semester: "8",
                _lectureCount:1,
                _labCount:2,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Моделирование систем",
                _semester: "8",
                _lectureCount:2,
                _labCount:2,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Параллельные вычисления",
                _semester: "8",
                _lectureCount:1,
                _labCount:2,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:true),
        new CurriculumDiscipline(_name: "Анализ больших данных",
                _semester: "8",
                _lectureCount:2,
                _labCount:3,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:true),


        new CurriculumDiscipline(_name: "Преддипломная практика",
                _semester: "8",
                _lectureCount:0,
                _labCount:0,
                _practiceCount:0,
                _courseWork:false,
                _ekz:false,
                _zach:false
                //_isPractice:true
            ),
        new CurriculumDiscipline(_name: "Подготовка к сдаче и сдача государственного экзамена",
                _semester: "8",
                _lectureCount:0,
                _labCount:0,
                _practiceCount:0,
                _courseWork:false,
                _ekz:true,
                _zach:false
                //_isPractice:true
            ),
        new CurriculumDiscipline(_name: "Выполнение и защита выпускной квалификационной работы",
                _semester: "8",
                _lectureCount:0,
                _labCount:0,
                _practiceCount:0,
                _courseWork:false,
                _ekz:true,
                _zach:false
                //_isPractice:true
            ),
            // Магистры 9 семестр
        new CurriculumDiscipline(
                _name: "Интеллектуальный анализ данных",
                _semester: "9",
                _lectureCount: 1,
                _labCount: 2,
                _practiceCount: 0,
                _courseWork: true,
                _ekz: true,
                _zach: false),
        new CurriculumDiscipline(
                _name: "Компьютерные технологии",
                _semester: "9",
                _lectureCount: 1,
                _labCount: 2,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: false,
                _zach: true ),
        new CurriculumDiscipline(
                _name: "Надежность информационных систем",
                _semester: "9",
                _lectureCount: 1,
                _labCount: 2,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: true,
                _zach: false
                ),
        new CurriculumDiscipline(
                _name: "Интеллектуальные информационные системы",
                _semester: "9",
                _lectureCount: 1,
                _labCount: 1,
                _practiceCount: 0,
                _courseWork: true,
                _ekz: true,
                _zach: false ),
        new CurriculumDiscipline(
                _name: "Новые технологии в разработке программных систем",
                _semester: "9",
                _lectureCount: 1,
                _labCount: 2,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: true,
                _zach: false ),
        new CurriculumDiscipline(
                _name: "Учебная практика, ознакомительная",
                _semester: "9",
                _lectureCount: 0,
                _labCount: 0,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: false,
                _zach: false
                //_isPractice: true 
            ),
            //семестр 10
        new CurriculumDiscipline(
                _name: "Интеллектуальный анализ данных",
                _semester: "10",
                _lectureCount: 1,
                _labCount: 2,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: true,
                _zach: false ),
        new CurriculumDiscipline(
                _name: "Моделирование",
                _semester: "10",
                _lectureCount: 1,
                _labCount: 2,
                _practiceCount: 0,
                _courseWork: true,
                _ekz: true,
                _zach: false ),
        new CurriculumDiscipline(
                _name: "Теория принятия решений",
                _semester: "10",
                _lectureCount: 1,
                _labCount: 1,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: true,
                _zach: false ),
        new CurriculumDiscipline(
                _name: "Теория мягких вычислений",
                _semester: "10",
                _lectureCount: 1,
                _labCount: 1,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: true,
                _zach: false ),
        new CurriculumDiscipline(
                _name: "Интеллектуальные информационные системы",
                _semester: "10",
                _lectureCount: 1,
                _labCount: 2,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: false,
                _zach: true),

        new CurriculumDiscipline(
                _name: "Новые технологии в разработке программных систем",
                _semester: "10",
                _lectureCount: 1,
                _labCount: 2,
                _practiceCount: 0,
                _courseWork: true,
                _ekz: true,
                _zach: false ),
        new CurriculumDiscipline(
                _name: "Производственная практика, научно-исследовательская работа",
                _semester: "10",
                _lectureCount: 0,
                _labCount: 0,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: false,
                _zach: false
                //_isPractice: true 
            ),
            //Семестр 11
        new CurriculumDiscipline(
                _name: "Научно-практический семинар",
                _semester: "11",
                _lectureCount: 1,
                _labCount: 2,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: false,
                _zach: true ),
        new CurriculumDiscipline(
                _name: "Интеллектуальный анализ текстов",
                _semester: "11",
                _lectureCount: 2,
                _labCount: 2,
                _practiceCount: 0,
                _courseWork: true,
                _ekz: true,
                _zach: false ),
        new CurriculumDiscipline(
                _name: "Искусственные нейронные сети",
                _semester: "11",
                _lectureCount: 1,
                _labCount: 2,
                _practiceCount: 0,
                _courseWork: true,
                _ekz: true,
                _zach: false ),
        new CurriculumDiscipline(
                _name: "Параллельные вычисления на кластерах и многоядерных компьютерах",
                _semester: "11",
                _lectureCount: 2,
                _labCount: 3,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: true,
                _zach: false ),
        new CurriculumDiscipline(
                _name: "Параллельные вычисления в интеллектуальных системах",
                _semester: "11",
                _lectureCount: 2,
                _labCount: 3,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: true,
                _zach: false ),
        new CurriculumDiscipline(
                _name: "Вычислительный эксперимент",
                _semester: "11",
                _lectureCount: 1,
                _labCount: 3,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: true,
                _zach: false ),
        new CurriculumDiscipline(
                _name: "Производственная практика, научно-исследовательская работа",
                _semester: "11",
                _lectureCount: 0,
                _labCount: 0,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: false,
                _zach: false
                //_isPractice: true
            ),
            //Семестр 12
        new CurriculumDiscipline(
                _name: "Интеллектуальный анализ текстов",
                _semester: "12",
                _lectureCount: 2,
                _labCount: 2,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: true,
                _zach: false ),
        new CurriculumDiscipline(
                _name: "Искусственные нейронные сети",
                _semester: "12",
                _lectureCount: 2,
                _labCount: 2,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: true,
                _zach: false ),
        new CurriculumDiscipline(
               _name: "Методология программной инженерии",
                _semester:"12",
                _lectureCount: 1,
                _labCount: 2,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: false,
                _zach: true ),
        new CurriculumDiscipline(
                _name: "Параллельные вычисления на кластерах и многоядерных компьютерах",
                _semester: "12",
                _lectureCount: 2,
                _labCount: 2,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: true,
                _zach: false ),
        new CurriculumDiscipline(
                _name: "Параллельные вычисления в интеллектуальных системах",
                _semester: "12",
                _lectureCount: 2,
                _labCount: 2,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: true,
                _zach: false ),
        new CurriculumDiscipline(
                _name: "Вычислительный эксперимент",
                _semester: "12",
                _lectureCount: 1,
                _labCount: 2,
                _practiceCount: 0,
                _courseWork: true,
                _ekz: false,
                _zach: true ),
        new CurriculumDiscipline(
                _name: "Производственная практика, проектная",
                _semester: "12",
                _lectureCount: 0,
                _labCount: 0,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: false,
                _zach: false
                //_isPractice: true 
            ),
        new CurriculumDiscipline(
                _name: "Преддипломная практика",
                _semester: "12",
                _lectureCount: 0,
                _labCount: 0,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: false,
                _zach: false
                //_isPractice: true 
            ),
        new CurriculumDiscipline(
                _name: "Подготовка к сдаче и сдача государственного экзамена",
                _semester: "12",
                _lectureCount: 0,
                _labCount: 0,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: false,
                _zach: false
                //_isPractice: true 
            ),
        new CurriculumDiscipline(
                _name: "Выполнение и защита выпускной квалификационной работы",
                _semester: "12",
                _lectureCount: 0,
                _labCount: 0,
                _practiceCount: 0,
                _courseWork: false,
                _ekz: false,
                _zach: false
                //_isPractice: true
            ),
        };

        public static void ReadFromJson()
        {
            var jsonString = File.ReadAllText("curriculum.json");
            Curriculums = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CurriculumDiscipline>>(jsonString);

        }

        internal static bool checkWorkPlan(CurriculumDiscipline discipline)
        {

            foreach (var item in Curriculums)
            {
                if (item.Name == discipline.Name && item.Semester==discipline.Semester)
                {
                    return item.Equals(discipline);
                }
            }
            return false;
        }

        internal static bool checkSemesterLength(int semester, int weekCount)
        {
            return Semesters[semester] == weekCount;
        }
    }
}
