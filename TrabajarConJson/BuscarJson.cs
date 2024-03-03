public class BuscarJson
{
    public static Usuario? BuscarUsuario (string email)
    {
        Usuario? usuario=ProductosActuales.usuariosActuales.FirstOrDefault(a=>a.Email==email);
        return usuario;
    }
    public static Proyecto? BuscarProyecto (int id)
    {
        Proyecto? Proyecto=ProductosActuales.proyectosActuales.FirstOrDefault(a=>a.Id==id);
        return Proyecto;
    }
    public static Tarea? BuscarTarea (int id)
    {
        Tarea? tarea=ProductosActuales.tareasActuales.FirstOrDefault(a=>a.Id==id);
        return tarea;
    }

    public static bool ColaboradorYaEstaAsignado(Tarea tarea, Usuario colaborador)
    {
        if (tarea.ColaboradorAsignado.Any(c=>c==colaborador))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static int UltimoNum(string tipo)
    {
        if (tipo=="Tarea")
        {
            if (ProductosActuales.tareasActuales != null)
            {
            int MaxNum = ProductosActuales.tareasActuales.Max(c => c.Id);
            return MaxNum+1;
            }
            else
            {
                return 1;
            }
        }
        else
        {
            return 1;
        }
    }
            // else if(tipo=="Proyecto")
            // {
            //     int MaxNum = GuardarJson.productosActuales.Tarjetas.Max(c => c.NumeroTarjeta);
            //     return MaxNum+1;
            // }

    


}