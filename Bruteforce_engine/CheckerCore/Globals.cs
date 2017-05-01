using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruteforce_engine.CheckerCore
{
    public class Globals
    {
        static public int threadsCount = 0;
        public static int indexSrc = 0;
        static public Object Sync = new Object();
        static public int accountsCount = 0;
        static public int badAccounts = 0;
        static public int goodAccounts = 0;
        static public int proxyCount = 0;
        static public int errors = 0;
        static public int captchaCount = 0;
        static public ArrayList arrAcc = new ArrayList();
        static public ArrayList arrGood = new ArrayList();
        static public ArrayList arrProx = new ArrayList();
        static public int index = 0;
    }
}
