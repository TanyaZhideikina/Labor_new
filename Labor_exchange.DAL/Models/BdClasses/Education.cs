﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor_exchange.DAL.Models
{   
    //TG эту таблицу будем реформировать
    public class Education
    {
        //TG поле индификатор кандидата, первичный ключ этой таблицы, я думаю intовский номер будет норм
        [Key]
        public int IdEducation { get; set; }

    }
}
