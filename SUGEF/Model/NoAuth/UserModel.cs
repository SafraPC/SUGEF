using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUGEF.Controller.Student
{
    public class UserController
    {

        private string userName, userTipo, userLogin, userSenha, userNascimento, userCpf, userFoto;
        private int userId;

        public string UserName { get => userName; set => userName = value; }
        public string UserTipo { get => userTipo; set => userTipo = value; }
        public string UserLogin { get => userLogin; set => userLogin = value; }
        public string UserSenha { get => userSenha; set => userSenha = value; }
        public string UserNascimento { get => userNascimento; set => userNascimento = value; }
        public string UserCpf { get => userCpf; set => userCpf = value; }
        public string UserFoto { get => userFoto; set => userFoto = value; }
        public int UserId { get => userId; set => userId = value; }

    }
}
