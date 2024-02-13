using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace Cookbook__Recipes
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Привязка обработчиков событий к кнопкам
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += Button4_Click;
            button5.Click += Button5_Click;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            // Очистить предыдущее содержимое FlowDocumentReader
            flowDocumentReader.Document = new FlowDocument();

            // Установить заголовок документа
            flowDocumentReader.Document.Blocks.Add(new Paragraph(new Run("Український Борщ")));

            // Добавить изображение готового блюда
            Image image = new Image();
            image.Source = new BitmapImage(new Uri(@"C:\Users\Teslyar\source\repos\Cookbook _Recipes\Cookbook _Recipes\Images\borsch.jpg"));
            flowDocumentReader.Document.Blocks.Add(new BlockUIContainer(image));

            // Создать список продуктов
            List<string> ingredients = new List<string> { "Картофель", "Свекла", "Морковь", "Лук", "Капуста", "Мясо" };
            Paragraph ingredientsParagraph = new Paragraph();
            foreach (string ingredient in ingredients)
            {
                ingredientsParagraph.Inlines.Add(new Run(ingredient + "\n"));
            }
            flowDocumentReader.Document.Blocks.Add(ingredientsParagraph);

            // Добавить описание кулинарного рецепта
            string description = "Это классический украинский борщ, который готовится по традиционному рецепту с" +
                " добавлением свежих овощей и мяса." +
                "В Киевской Руси борщ готовили из съедобных листьев борщевика — отсюда название. Позднее стали " +
                "варить со свёклой, а с XIX века добавлять картошку." +
                "Сегодня в каждой семье есть свой рецепт борща. В кастрюлю добавляют и фасоль, и грибы, и копчёности," +
                " и даже сельдерей. Мы же научим вас готовить" +
                " идеальный традиционный борщ.";
            flowDocumentReader.Document.Blocks.Add(new Paragraph(new Run(description)));
        }


        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            // Очистить предыдущее содержимое FlowDocumentReader
            flowDocumentReader.Document = new FlowDocument();

            // Установить заголовок документа
            flowDocumentReader.Document.Blocks.Add(new Paragraph(new Run("Галушки")));

            // Добавить изображение готового блюда Галушки
            Image image = new Image();
            image.Source = new BitmapImage(new Uri(@"C:\Users\Teslyar\source\repos\Cookbook _Recipes\Cookbook _Recipes\Images\galushki.jpg"));
            flowDocumentReader.Document.Blocks.Add(new BlockUIContainer(image));

            // Создать список продуктов для рецепта "Галушки"
            List<string> ingredients = new List<string> { "Картофель", "Мука", "Яйца", "Соль", "Масло" };
            foreach (string ingredient in ingredients)
            {
                flowDocumentReader.Document.Blocks.Add(new Paragraph(new Run(ingredient)));
            }

            // Добавить описание кулинарного рецепта для блюда "Галушки"
            string description = "Галушки - это традиционное украинское блюдо, приготовленное из картофельного теста, " +
                "которое потом варится и подается с соусом или сметаной." +
                "Простое и очень сытное блюдо, особенно вкусное в горячем виде. Подавать можно со сметаной или без.";
            flowDocumentReader.Document.Blocks.Add(new Paragraph(new Run(description)));
        }


        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            // Clear the previous content of FlowDocumentReader
            flowDocumentReader.Document = new FlowDocument();

            // Set the document title
            flowDocumentReader.Document.Blocks.Add(new Paragraph(new Run("Драники")));

            // Add the image of the finished dish "Драники"
            Image image = new Image();
            image.Source = new BitmapImage(new Uri(@"C:\\Users\\Teslyar\\source\\repos\\Cookbook _Recipes\\Cookbook _Recipes\\Images\\draniki.jpg"));
            flowDocumentReader.Document.Blocks.Add(new BlockUIContainer(image));

            // Create a list of ingredients for the "Драники" recipe
            List<string> ingredients = new List<string> { "Картофель", "Лук", "Мука", "Яйца", "Соль", "Перец", "Масло" };
            foreach (string ingredient in ingredients)
            {
                flowDocumentReader.Document.Blocks.Add(new Paragraph(new Run(ingredient)));
            }

            // Add the description of the culinary recipe for the dish "Драники"
            string description = "Драники - это белорусское национальное блюдо, представляющее собой картофельные оладьи, " +
                "которые обжариваются на сковороде до золотистой корочки." +
                "Под румяной и хрустящей картофельной корочкой — сочная и ароматная птица. Что может быть лучше?";
            flowDocumentReader.Document.Blocks.Add(new Paragraph(new Run(description)));
        }


        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            // Clear the previous content of FlowDocumentReader
            flowDocumentReader.Document = new FlowDocument();

            // Set the document title
            flowDocumentReader.Document.Blocks.Add(new Paragraph(new Run("Котлети по-Київськи")));

            // Add the image of the finished dish "Котлети по-Київськи"
            Image image = new Image();
            image.Source = new BitmapImage(new Uri(@"C:\\Users\\Teslyar\\source\\repos\\Cookbook _Recipes\\Cookbook _Recipes\\Images\\kotleti.jpg"));
            flowDocumentReader.Document.Blocks.Add(new BlockUIContainer(image));

            // Create a list of ingredients for the "Котлети по-Київськи" recipe
            List<string> ingredients = new List<string> { "Фарш", "Яйца", "Хлеб", "Молоко", "Соль", "Перец", "Масло" };
            foreach (string ingredient in ingredients)
            {
                flowDocumentReader.Document.Blocks.Add(new Paragraph(new Run(ingredient)));
            }

            // Add the description of the culinary recipe for the dish "Котлети по-Київськи"
            string description = "Котлети по-Київськи - это классическое украинское блюдо, состоящее из котлет из фарша, " +
                "начиненных сливочным маслом и зеленью." +
                "Сочное, нежное куриное филе с ароматной сливочной начинкой и хрустящей корочкой. " +
                "Чтобы приготовить эти котлеты, придётся немного потрудиться, но результат стоит того.";
            flowDocumentReader.Document.Blocks.Add(new Paragraph(new Run(description)));
        }


        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            // Clear the previous content of FlowDocumentReader
            flowDocumentReader.Document = new FlowDocument();

            // Set the document title
            flowDocumentReader.Document.Blocks.Add(new Paragraph(new Run("Фаршмак")));

            // Add the image of the finished dish "Фаршмак"
            Image image = new Image();
            image.Source = new BitmapImage(new Uri(@"C:\\Users\\Teslyar\\source\\repos\\Cookbook _Recipes\\Cookbook _Recipes\\Images\\farshmak.jpg"));
            flowDocumentReader.Document.Blocks.Add(new BlockUIContainer(image));

            // Create a list of ingredients for the "Фаршмак" recipe
            List<string> ingredients = new List<string> { "Рыба", "Картофель", "Лук", "Майонез", "Соль", "Перец", "Зелень" };
            foreach (string ingredient in ingredients)
            {
                flowDocumentReader.Document.Blocks.Add(new Paragraph(new Run(ingredient)));
            }

            // Add the description of the culinary recipe for the dish "Фаршмак"
            string description = "Фаршмак - Дословный перевод слова \"форшмак\" – предвкушение, то есть подается это" +
                " блюдо из сельди как закуска, перед основным блюдом. Данный вариант форшмака с луком и яблоком максимально" +
                " приближен к классическому рецепту.";
            flowDocumentReader.Document.Blocks.Add(new Paragraph(new Run(description)));
        }




    }
}
