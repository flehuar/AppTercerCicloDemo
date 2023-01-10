using WebApplication1.BDCRUD;
using WebApplication1.Model;

namespace WebApplication1._03_Repositorio
{
    public class FrutaRepositorio
    {
        _DbContextCrud db = new _DbContextCrud();

        #region crud methods
        public List<Fruta> getAll()
        {
            //select * from Fruta
            return db.Frutas.ToList();
        }


        //select * from Fruta wherd id = id
        public Fruta getById(int id)
        {
            //select * from Fruta
            return db.Frutas.Find(id);
        }


        //insert into Fruta
        //select * from Fruta wherd id = id
        public Fruta create(Fruta request)
        {
            //request.id = 0 // 4
            db.Frutas.Add(request);
            db.SaveChanges();
            return request;
        }

        //update into Fruta
        //select * from Fruta wherd id = id
        public Fruta update(Fruta request)
        {
            //request.id = 0 // 4
            db.Frutas.Update(request);
            db.SaveChanges();
            return request;
        }


        public int delete(int id)
        {

            //select * from Fruta wherd id = id
            Fruta Fruta = db.Frutas.Find(id);
            //request.id = 0 // 4
            db.Frutas.Remove(Fruta);
            return db.SaveChanges();
        }
        #endregion crud methods



        public List<Fruta> getByFilter(int? id_categoria, string? nombre)
        {


            //List<Fruta> list = 
            //        //C# ==> key sencitivy ==>  Hola != hola
            //        db.Frutas
            //        .Where(x => 
            //            x.IdFrutaCategoria == id_categoria
            //        ).ToList();
            //List<Fruta> list2 =
            //        //C# ==> key sencitivy ==>  Hola != hola
            //        db.Frutas
            //        .Where(x =>
            //            x.Nombre.ToLower().Contains(nombre.ToLower())
            //        ).ToList();

            //List<Fruta> list3 =
            //        //C# ==> key sencitivy ==>  Hola != hola
            //        db.Frutas
            //        .Where(x =>
            //            x.IdFrutaCategoria == id_categoria
            //            && x.Nombre.ToLower().Contains(nombre.ToLower())
            //        ).ToList();

            var query = db.Frutas.Where(x => x.Id == x.Id);

            List<Fruta> list2 = new List<Fruta>();

            if (id_categoria != null)
            {
                query = query.Where(x => x.IdFrutaCategoria == id_categoria);
            }

            if (nombre != null)
            {
                query = query.Where(x => x.Nombre.ToLower().Contains(nombre.ToLower()));
            }

            list2 = query.ToList();

            return list2;
        }


        public GenericFilterResponse<Fruta> getByFilterGeneric(GenericFilterRequest filters)
        {
            GenericFilterResponse<Fruta> res = new GenericFilterResponse<Fruta>();

            //vue react angular php ==> null ==> "null"
            var query = db.Frutas.Where(x => x.Id == x.Id);
            filters.filters.ForEach(item => { 
                if(!string.IsNullOrEmpty(item.value) && item.value != "null")
                {
                    switch(item.name)
                    {
                        case "id":
                            query = query.Where(x => x.Id == int.Parse(item.value));
                            break;
                        case "id_categoria":
                            query = query.Where(x => x.IdFrutaCategoria == int.Parse(item.value));
                            break;
                        case "nombre":
                            query = query.Where(x => x.Nombre.ToLower().Contains(item.value.ToLower()));
                            break;
                    }
                }

            });

            //el total de los items encontradas
            res.totalRecord = query.Count();
            List<Fruta> lst = query
                .Skip((filters.page - 1) * filters.quantity).Take(filters.quantity)
                .ToList();
            res.list = lst;

            return res;
        }


    }
}
