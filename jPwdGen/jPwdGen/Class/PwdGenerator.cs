using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jPwdGen.EntityF;
using System.Windows.Forms;

namespace jPwdGen
{
    public partial class PwdGenerator
    {
        public string pwd;
        private char[] tmp;
        public PwdGenerator(PwdParamsView param, int idUser)
        {
            tmp = new char[param.pwdLenght];
            create_pwd(param, idUser);
        }

        private void create_pwd(PwdParamsView param, int idUser)
        {
            DicoGen dico = new DicoGen();
            Random rand = new Random();
            int typec = 0; // choose char type (nb -> 0, Maj -> 1, min -> 2, spec -> 3)
            int i = -1;
            pwd = "";

            while (i++ != param.pwdLenght - 1)
            {
                typec = rand.Next(0, 4); //!\\ valeur min inclusive, valeur maxi exclusive
                if (!param.nb && typec == 0 || !param.Maj && typec == 1 || !param.min && typec == 2)
                    typec++;
                if (!param.spec && typec == 3)
                    typec = 0;

                switch (typec)
                {
                    case 0:
                        tmp[i] = dico.nb[rand.Next(0, dico.nb.Length)];
                        break;
                    case 1:
                        tmp[i] = dico.Maj[rand.Next(0, dico.Maj.Length)];
                        break;
                    case 2:
                        tmp[i] = dico.min[rand.Next(0, dico.min.Length)];
                        break;
                    case 3:
                        tmp[i] = dico.spec[rand.Next(0, dico.spec.Length)];
                        break;
                }

                /* if (typec == 0)
                    tmp[i] = dico.nb[rand.Next(0, dico.nb.Length)];
                   else if (typec == 1)
                    tmp[i] = dico.Maj[rand.Next(0, dico.Maj.Length)];
                   else if (typec == 2)
                    tmp[i] = dico.min[rand.Next(0, dico.min.Length)];
                   else if (typec == 0)
                    tmp[i] = dico.spec[rand.Next(0, dico.spec.Length)];
                */
                pwd += tmp[i];
            }
            save_datas(param, idUser);
        }

        private void save_datas(PwdParamsView param, int idUser)
        {
            using (jPwdGenEntities pwdDb = new jPwdGenEntities())
            {
                PwdUser pwdU = new PwdUser()
                {
                    ID_USER = idUser,
                    LB_PWD = pwd,
                    LB_SOFT = param.softName
                };
                pwdDb.PwdUser.Add(pwdU);
                pwdDb.SaveChanges();
            }
        }
    }

    public class DicoGen
    {
        public string Maj = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string min = "abcdefghijklmnopqrstuvwxyz";
        public string nb = "0123456789";
        public string spec = "-.!()?[]_'~";
    }
}
