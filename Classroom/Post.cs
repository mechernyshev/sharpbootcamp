using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class Post
    {
        private string _title;
        private string _description;
        private DateTime _createdOn;
        private int _votesNumber;


        public Post()
        {
            _votesNumber = 0;
        }

        public Post(string title, string description)
            : this()
        {
            
            _title = title;
            _description = description;
        }


        public void UpVote ()
        {
            _votesNumber++;
        }

        public void DownVote()
        {
            if (_votesNumber == 0)
            {

            }
            else
            {
                _votesNumber--;
            }

        }

        public int GetVoteNumber()
        {
            return _votesNumber;
        }


        public void ViewPost()
        {
            Console.WriteLine("Title: {0}", _title );
            Console.WriteLine("Body: {0}", _description);
        }

    }
}
