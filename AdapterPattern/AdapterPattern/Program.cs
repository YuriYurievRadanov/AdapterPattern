using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeb web = null;
            WebAdapter webAdapter = new WebAdapter(web);
            webAdapter.Send();
        }

        interface IEmail
        {
            void Send();
        }

        class Email : IEmail
        {
            public void Send()
            {
                Console.WriteLine("Sending email.");
            }
        }

        public interface IWeb
        {
            void Push();
        }

        public class WebAdapter : IEmail
        {
            private IWeb web;

            public WebAdapter(IWeb web)
            {
                this.web = web;
            }

            public void Send()
            {
                web.Push();
            }
        }
    }
}
