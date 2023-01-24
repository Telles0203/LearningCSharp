﻿using System.Text;

namespace ExerciseStringbuilding.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() 
        { 
        
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }


        //Adotar como padrão adicionar.
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }
        public override string ToString()
        {
            //Aqui que é utilizado o string builder para ser mais eficiente.
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append($"{Likes} Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Comment comment in Comments)
            {
                sb.AppendLine(comment.Text);
            }
            return sb.ToString();
        }
    }
}
