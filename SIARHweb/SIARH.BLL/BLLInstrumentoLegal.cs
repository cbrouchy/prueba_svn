using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIARH.DAL; 

namespace SIARH.BLL
{
    public class BLLInstrumentoLegal
    {
        #region ATRIBUTOS
        private RRHH_V2Entities db;  
        private RRHH_V2SP msp;
        #endregion

        #region PROPIEDADES
        public string error { set; get; }
        
        #endregion

        #region CONSTRUCTORES
        public BLLInstrumentoLegal()
        {
            this.db = new RRHH_V2Entities();
            this.msp =  new RRHH_V2SP();
        }

        #endregion
           
        public object Search(string pName, bool? pActivo)
        {
            return db.InstrumentoLegal.Where(x => (x.instrumentoLegal1.Contains(pName.Trim()) || string.IsNullOrEmpty(pName)) && (x.estaActivo == pActivo || pActivo == null)).ToList();
        }

        public InstrumentoLegal SearchbyIdInstrumentoLegal(int pId)
        {
            return db.InstrumentoLegal.FirstOrDefault(x=>x.idInstrumentoLegal==pId);         
        }
      
        public bool InsertOrUpdate(InstrumentoLegal pOInstrumentoLegal)
        {           
            try
            {
                error = (pOInstrumentoLegal.idInstrumentoLegal == 0) ? msp.spInstrumentoLegalINS_(pOInstrumentoLegal.instrumentoLegal1, pOInstrumentoLegal.idTipoInstrumentoLegal, pOInstrumentoLegal.descripcion).First().ERROR : msp.spInstrumentoLegalUPD_(pOInstrumentoLegal.idInstrumentoLegal, pOInstrumentoLegal.instrumentoLegal1, pOInstrumentoLegal.idTipoInstrumentoLegal, pOInstrumentoLegal.descripcion,pOInstrumentoLegal.estaActivo,pOInstrumentoLegal.fechaCaducidad).First().ERROR;
                return (error != "") ? false : true;
            }
            catch (Exception ex)
            {
                error = "Error al Registrar! " + ex.Message;
                return false;
            }           
        }

        // Elimina un registro logicamente de la BD 
        public bool DeletedLogical(int pId)
        {          
            var item = db.InstrumentoLegal.Find(pId);
            item.estaActivo = false;
            item.fechaCaducidad = DateTime.Now;
            try
            {
                if (InsertOrUpdate(item))
                    return true;
                else
                {
                    this.error = "No es posible Eliminar el registro";
                    return false;
                }
            }
            catch (Exception ex)
            {
                this.error = this.error + ex.Message;
                return false;
            }          
        }

        /* Verifica la integridad referencial del proceso para poder eliminarlo o no */
        public bool IntegrityCheck(InstrumentoLegal pObject)
        {
            var item = db.Organizacion.Count(x => x.idInstrumentoLegalCreacion == pObject.idInstrumentoLegal || x.idInstrumentoLegalBaja == pObject.idInstrumentoLegal && x.estaActivo == true);            
            if (item == 0)
            {
                item = db.PlanEstudio.Count(x => x.idInstrumentoLegal == pObject.idInstrumentoLegal && x.estaActivo == true);                
                //No tiene más relaciones en este modulo
            }
            return (item == 0) ? true : false;
        }

        public bool RepeatedObjectCheck(InstrumentoLegal pObject)
        {           
            var item = 0;
            if (pObject.idInstrumentoLegal == 0)
                item = db.InstrumentoLegal.Count(t => t.instrumentoLegal1 == pObject.instrumentoLegal1 && t.estaActivo == true);
            else
                item = db.InstrumentoLegal.Count(t => t.instrumentoLegal1 == pObject.instrumentoLegal1 && t.idInstrumentoLegal != pObject.idInstrumentoLegal && t.estaActivo == true);
            return (item == 0) ? true : false;           
        }

    }
}
