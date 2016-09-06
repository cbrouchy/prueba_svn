using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIARH.DAL;

namespace SIARH.BLL
{
    public class BLLRefTipoInstrumetnoLegal
    {
        #region ATRIBUTOS
        private RRHH_V2Entities db;

        #endregion

        #region CONSTRUCTORES
        public BLLRefTipoInstrumetnoLegal()
        {
            this.db = new RRHH_V2Entities();
        }

        #endregion
        public object ListTipoInstrumento()
        {         
             return db.RefTipoInstrumentoLegal.ToList().Where(x => x.estaActivo);           
        }
    }
}
