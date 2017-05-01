using Bruteforce_engine.CheckerCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruteforce_engine.ResponseManager
{
    class RsManager
    {
        public RsManager(){}

        public void Pick(string content,string login,string pass) 
        {
            try
            {
                if (content.Contains("Проверочный код") || content.Contains("blocked"))
                {
                    Globals.captchaCount++;
                    throw new Exception();
                }
                else
                {
                    if (content.Contains("Такого пользователя не существует") || content.Contains("Неверный пароль") || content == "")
                    {
                        Globals.badAccounts++;
                    }
                    else
                    {
                        Globals.goodAccounts++;
                        Globals.arrGood.Add(login + ";" + pass);
                    }
                }
            }
            catch
            {
                Globals.indexSrc--;
                Globals.errors++;
            }
        } 
    }
}
