using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UFPCore.Models.Predictions
{
    public class Table
    {
        [Key]
        public int Id { get; set; }
        public string User { get; set; }
        [Required, Range(1,20), Display(Name = "First Place")]
        public TeamsEnum Place1 { get; set; }
        [Required, Range(1, 20), Display(Name = "Second Place")]
        public TeamsEnum Place2 { get; set; }
        [Required, Range(1, 20), Display(Name = "Third Place")]
        public TeamsEnum Place3 { get; set; }
        [Required, Range(1, 20), Display(Name = "Fourth Place")]
        public TeamsEnum Place4 { get; set; }
        [Required, Range(1, 20), Display(Name = "Fifth Place")]
        public TeamsEnum Place5 { get; set; }
        [Required, Range(1, 20), Display(Name = "Sixth Place")]
        public TeamsEnum Place6 { get; set; }
        [Required, Range(1, 20), Display(Name = "Seventh Place")]
        public TeamsEnum Place7 { get; set; }
        [Required, Range(1, 20), Display(Name = "Eighth Place")]
        public TeamsEnum Place8 { get; set; }
        [Required, Range(1, 20), Display(Name = "Ninth Place")]
        public TeamsEnum Place9 { get; set; }
        [Required, Range(1, 20), Display(Name = "Tenth Place")]
        public TeamsEnum Place10 { get; set; }
        [Required, Range(1, 20), Display(Name = "Eleventh Place")]
        public TeamsEnum Place11 { get; set; }
        [Required, Range(1, 20), Display(Name = "Twelfth Place")]
        public TeamsEnum Place12 { get; set; }
        [Required, Range(1, 20), Display(Name = "Thirteenth Place")]
        public TeamsEnum Place13 { get; set; }
        [Required, Range(1, 20), Display(Name = "Fourteenth Place")]
        public TeamsEnum Place14 { get; set; }
        [Required, Range(1, 20), Display(Name = "Fifteenth Place")]
        public TeamsEnum Place15 { get; set; }
        [Required, Range(1, 20), Display(Name = "Sixteenth Place")]
        public TeamsEnum Place16 { get; set; }
        [Required, Range(1, 20), Display(Name = "Seventeenth Place")]
        public TeamsEnum Place17 { get; set; }
        [Required, Range(1, 20), Display(Name = "Eighteenth Place")]
        public TeamsEnum Place18 { get; set; }
        [Required, Range(1, 20), Display(Name = "Nineteenth Place")]
        public TeamsEnum Place19 { get; set; }
        [Required, Range(1, 20), Display(Name = "Twentieth Place")]
        public TeamsEnum Place20 { get; set; }
    }
}