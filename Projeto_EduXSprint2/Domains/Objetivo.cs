﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_EduXSprint2.Domains
{
    public partial class Objetivo
    {
<<<<<<< HEAD
       
        public Objetivo()
        {
            ObjetivoAluno = new HashSet<ObjetivoAluno>();
            IdObjetivo = Guid.NewGuid();
=======

        public Objetivo()
        {
            ObjetivoAluno = new HashSet<ObjetivoAluno>();

>>>>>>> 13736be80c8b2c4180a7339713c8164335ef1281
        }

        public Guid IdObjetivo { get; set; }
        public string Descricao { get; set; }
        public Guid IdCategoria { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual ICollection<ObjetivoAluno> ObjetivoAluno { get; set; }
    }
}
