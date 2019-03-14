using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class Toplanti
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Lütfen Toplantı Konusunu Belirtiniz")]
        [Display(Name = "Toplantı Konusu")]
        public string Konu { get; set; }


        [Required(ErrorMessage = "Toplantı Tarihini Belirtiniz")]
        [Display(Name = "Toplantı Tarihi")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime T_Tarih { get; set; }

        [Display(Name = "Başlangıç Saati")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        [Required(ErrorMessage = "Toplantının Başlangıç Saatini Belirtiniz")]
        public DateTime BaslangicSaat { get; set; }
        [Required(ErrorMessage = "Toplantının Bitiş Saatini Belirtiniz")]
        [Display(Name = "Bitiş Saati")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime BitisSaat { get; set; }

        [Required(ErrorMessage = "Lütfen Katılan Şirket Çalışanını Belirtiniz")]
        [Display(Name = "Katılan Çalışan")]
        public string Calisan { get; set; }


        [Required(ErrorMessage = "Lütfen Katılan Kişileri Belirtiniz")]
        [Display(Name = "Katılan Kişiler")]
        public string T_Katilimci { get; set; }


        public class EmpDBContext : DbContext
        {
            public DbSet<Toplanti> Toplantilar { get; set; }
        }
    }
}