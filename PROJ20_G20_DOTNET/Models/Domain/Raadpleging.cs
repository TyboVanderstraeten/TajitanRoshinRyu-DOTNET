﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROJ2_G20_.NET.Models.Domain {
    public class Raadpleging {

        #region Properties
        public int Id { get; set; }
        public int AantalRaadplegingen { get; set; }
        public Lid Lid { get; set; }
        [Column("LID_ID")]
        public int LidId { get; set; }

        public Oefening Oefening { get; set; }
        [Column("OEFENING_ID")]
        public int OefeningId { get; set; }
        //public IList<DateTime> Tijdstippen { get; set; }
        #endregion

        #region Constructors
        protected Raadpleging() {
          //  Tijdstippen = new List<DateTime>();
        }

        public Raadpleging(Lid lid, Oefening oefening) : this(){
            Lid = lid;
            LidId = lid.Id;
            Oefening = oefening;
            OefeningId = oefening.Id;
            AantalRaadplegingen = 0;
        } 
        #endregion

    }
}
