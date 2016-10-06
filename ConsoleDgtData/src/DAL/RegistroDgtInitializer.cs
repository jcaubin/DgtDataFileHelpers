using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDgtData.DAL
{
    public class RegistroDgtInitializer : DropCreateDatabaseAlways<RegistroDgtContext>
    {
        protected override void Seed(RegistroDgtContext context)
        {
            //base.Seed(context);

            var clasesMatricula = new List<ClaseMat>
            {
                new ClaseMat{Id="0",Descripcion="Ordinaria"},
                new ClaseMat{Id="1",Descripcion="Turística"},
                new ClaseMat{Id="2",Descripcion="Remolque"},
                new ClaseMat{Id="3",Descripcion="Diplomática"},
                new ClaseMat{Id="4",Descripcion="Reservada"},
                new ClaseMat{Id="5",Descripcion="Vehículo especial"},
                new ClaseMat{Id="6",Descripcion="Ciclomotor"},
                new ClaseMat{Id="7",Descripcion="Transporte Temporal"},
                new ClaseMat{Id="8",Descripcion="Histórica"}
            };
            clasesMatricula.ForEach(s => context.ClaseMatriculas.Add(s));
            context.SaveChanges();

            var procedenciaList = new List<ProcedenciaItv>
            {
                new ProcedenciaItv{Id="0",Descripcion="Fabricación Nacional"},
                new ProcedenciaItv{Id="1",Descripcion="Importación no comunitaria"},
                new ProcedenciaItv{Id="2",Descripcion="Subasta"},
                new ProcedenciaItv{Id="3",Descripcion="Importación UE"}
            };
            context.Procedencias.AddRange(procedenciaList);
            context.SaveChanges();
        }
    }
}
