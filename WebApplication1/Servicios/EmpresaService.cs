using WebApplication1.DataDb; 
using WebApplication1.Servicios.Interfaces;

namespace WebApplication1.Servicios
{
    public class EmpresaService : IEmpresaService
    {
        private readonly WebeOContext _db;
        public EmpresaService(WebeOContext db)
        {
            this._db = db;
        }
       
        public void addEmpresa(Empresa empresa)
        {
            _db.Empresas.Add(empresa);
            _db.SaveChanges();
        }

        public void EditarEmpresa(int? IdEmpresa, Empresa Emprs)
        {
            var temp = _db.Empresas.Where(c => c.EmpresaId == IdEmpresa).FirstOrDefault();
            temp.NombreComercial = Emprs.NombreComercial;
            temp.Email= Emprs.Email;    
            temp.Ruc= Emprs.Ruc;
            temp.Contraseña = Emprs.Contraseña;
            temp.Direccion= Emprs.Direccion;
            temp.Telefono= Emprs.Telefono;
            temp.ImagenEmpresaIurl = Emprs.ImagenEmpresaIurl;
            _db.SaveChanges();


        }

        public Empresa GetEmpresaByEmailAndPassword(string correo, string clave)
        {
            Empresa userEmpr = _db.Empresas.Where(u => u.Email == correo).FirstOrDefault();
            if (userEmpr == null) { return null; }
            if (userEmpr.Email == correo && userEmpr.Contraseña == clave)
            {
                return userEmpr;
            }else return null;
        }

        public Empresa GetEmpresaByID(int? IdEmpresa)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Empresa> GetEmpresas()
        {
            return _db.Empresas.ToList();
        }
    }
}
