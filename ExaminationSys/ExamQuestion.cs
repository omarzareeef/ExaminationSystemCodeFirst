using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSys
{
    internal class ExamQuestion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int QstDegree { get; set; }
        [MaxLength(3), Required]
        public string QstType { get; set; }
        [Required, ForeignKey("Exam")]
        public int ExamId { get; set; }
        [ForeignKey("MCQuestion")]
        public int? MCQId { get; set; }
        [ForeignKey("TFQuestion")]
        public int? TFXQId { get; set; }
        [ForeignKey("TxtQuestion")]
        public int? TXQId { get; set; }
        [Required, ForeignKey("Course")]
        public int CrsId { get; set; }

        public virtual Exam Exam { get; set; }
        public virtual Course Course { get; set; }
        public virtual MCQuestion MCQuestion { get; set; }
        public virtual TFQuestion TFQuestion { get; set; }
        public virtual TxtQuestion TxtQuestion { get; set; }
    }
}
