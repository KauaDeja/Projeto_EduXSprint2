﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_EduXSprint2.Domains
{
    public partial class Instituicao
    {
<<<<<<< HEAD
<<<<<<< HEAD
        public Instituicao()
        {
            Curso = new HashSet<Curso>();
            IdInstituicao = Guid.NewGuid();
=======
      
        public Instituicao()
        {
            Curso = new HashSet<Curso>();
>>>>>>> 1f24855ef81e8cd8ec819060a8c0c4ed5f7c139d
=======

        public Instituicao()
        {
            Curso = new HashSet<Curso>();
>>>>>>> 13736be80c8b2c4180a7339713c8164335ef1281
        }

        public Guid IdInstituicao { get; set; }
        public string Nome { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }

        public virtual ICollection<Curso> Curso { get; set; }
    }
}
