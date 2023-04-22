using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practice14
{
    public partial class Form1 : Form
    {
        
        Queue<int> queue3 = new Queue<int>();
        Queue<string[]> peopleQueue;

        public Form1()
        {
            InitializeComponent();
        }

        //ЗАДАНИЕ 3
        private void buttonExtract_Click(object sender, EventArgs e)
        {
            // Извлекаем числа из очереди и выводим их на экран
            while (queue3.Count > 0)
            {
                int number = queue3.Dequeue();
                listBoxQueue.Items.Add(number);
            }

            MessageBox.Show($"Извлечено {listBoxQueue.Items.Count} чисел из очереди.");
        }

        private void buttonAddQueue_Click(object sender, EventArgs e)
        {
            // Получаем значение n из текстового поля
            try
            {
                int n = 1;
                while (true)
                {
                    n = int.Parse(textBoxAddN.Text);
                    if (n > 1)
                        break;
                    else
                    {
                        textBoxAddN.BackColor = Color.Red;
                        textBoxAddN.Text = "Введите число больше 1";
                    }
                       
                }
                // Добавляем числа от 1 до n в очередь
                for (int i = 1; i <= n; i++)
                {
                    queue3.Enqueue(i);
                }
                MessageBox.Show($"Добавлено {n} чисел в очередь.");
            }
            catch (Exception)
            {
                MessageBox.Show($"Введите число!");
            }
            
        }

        private void textBoxAddN_Click(object sender, EventArgs e)
        {
            textBoxAddN.Text = "";
            textBoxAddN.ForeColor = Color.Black;
            textBoxAddN.BackColor = Color.White;
        }

        //ЗАДАНИЕ 4
        private void DisplayData()
        {
            //Создаем таблицу
            DataTable datatable = new DataTable();
            datatable.Columns.Add("Фамилия");
            datatable.Columns.Add("Имя");
            datatable.Columns.Add("Отчество");
            datatable.Columns.Add("Возраст");
            datatable.Columns.Add("Вес");

            foreach (var person in peopleQueue)
            {
                datatable.Rows.Add(person[0], person[1], person[2], person[3], person[4]);
            }
            //Добавляем таблицу в DataGridView
            dataGridViewPeople.DataSource = datatable;
        }
        private void buttonSortPeople_Click(object sender, EventArgs e)
        {
            //Создаем две очереди для людей младше 40 лет(youngPeople) и для людей старше 40 лет(oldPeople) 
            var youngPeople = new Queue<string[]>();
            var oldPeople = new Queue<string[]>();

            foreach (var person in peopleQueue)
            {
                var age = int.Parse(person[3]);
                if (age < numericUpDownAge.Value)
                {
                    youngPeople.Enqueue(person);
                }
                else
                {
                    oldPeople.Enqueue(person);
                }
            }
            //var peopleYoungList = youngPeople.ToList();
            //var peopleOldList = oldPeople.ToList();

            //peopleYoungList.Sort((a, b) => int.Parse(a[3]).CompareTo(int.Parse(b[3])));
            //peopleOldList.Sort((a, b) => int.Parse(a[3]).CompareTo(int.Parse(b[3])));

            //youngPeople = new Queue<string[]>(peopleYoungList);
            //oldPeople = new Queue<string[]>(peopleOldList);

            // Объединяем очереди и отображаем данные в DataGridView
            peopleQueue = new Queue<string[]>(youngPeople.Concat(oldPeople));
            DisplayData();
        }

        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            peopleQueue = new Queue<string[]>();
            // Открываем файл для чтения
            using (var sr = new StreamReader("people.txt"))
            {
                    while (!sr.EndOfStream)
                    {
                        // Читаем строку из файла и разбиваем ее на массив строк
                        var line = sr.ReadLine();
                        if(line.Length == 0)
                        {
                            MessageBox.Show("Файл пуст");
                        }
                        else
                        {
                            var parts = line.Split(' ');

                            // Добавляем массив строк в очередь
                            peopleQueue.Enqueue(parts);
                        }
                    }
            }

            // Отображаем данные в DataGridView
            DisplayData();
        }

        //ЗАДАНИЕ 5
        private void buttonSortAge_Click(object sender, EventArgs e)
        {
            //Конвертируем очередь в список
            var peopleList = peopleQueue.ToList();
            //Сортируем список по возрасту
            peopleList.Sort((a, b) => int.Parse(a[3]).CompareTo(int.Parse(b[3])));
            peopleQueue = new Queue<string[]>(peopleList);
            DisplayData();


        }
    }
}
