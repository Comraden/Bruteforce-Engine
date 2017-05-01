using Bruteforce_engine.CheckerCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruteforce_engine.AccManager
{
    public class AMCore
    {
        public AMCore(string sourceFile,string proxyFile) 
        {
            StreamReader objReader = new StreamReader(sourceFile);
            string sLine = "";

            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    Globals.arrAcc.Add(sLine);
            }
            Globals.accountsCount = Globals.arrAcc.Count;

            StreamReader proxReader = new StreamReader(proxyFile);
            string pLine = "";

            while (pLine != null)
            {
                pLine = proxReader.ReadLine();
                if (pLine != null)
                    Globals.arrProx.Add(pLine);
            }
            Globals.proxyCount = Globals.arrProx.Count;
        }
        public static string[] GetAccount()
        {
            if (Globals.indexSrc > Globals.accountsCount) { return null; }
            string line = "";
            try
            {
                line = Globals.arrAcc[Globals.indexSrc].ToString();
                Globals.indexSrc++;
                string[] lp = line.Split(new Char[] { ';' });
                return lp;
            }
            catch { Globals.indexSrc--; return null; }
        }
        public static string GetProxy()
        {
            Random Rnd = new Random();
            return Convert.ToString(Globals.arrProx[Rnd.Next(0, Globals.arrProx.Count)]);
        }
    }
}
