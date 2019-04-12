﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJ20_G20_DOTNET.Models.Domain {
    public class Aanwezigheid {


        #region Properties
        public Lid Lid { get; set; }
        public int LidId { get; set; }

        public Activiteit Activiteit { get; set; }
        public int ActiviteitId { get; set; }

        public int Id { get; set; }
        public int PuntenAantal { get; set; }
        #endregion

        #region Constructors
        public Aanwezigheid(Lid lid, Activiteit activiteit) {
            PuntenAantal = 0;
            // In afwachting van PuntenAantal = BerekenPuntenAantal();
            Lid = lid;
            Activiteit = activiteit;
        }

        protected Aanwezigheid() {

        }
        #endregion

        #region Methods
        private int BerekenPuntenAantal() {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
