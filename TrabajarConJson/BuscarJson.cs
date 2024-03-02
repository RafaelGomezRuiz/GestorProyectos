public class BuscarJson
{
    public static Usuario? BuscarUsuario (string email)
    {
        Usuario? usuario=GuardarJson.usuariosActuales.FirstOrDefault(a=>a.Email==email);
        return usuario;
    }
    public static Proyecto? BuscarProyecto (int id)
    {
        Proyecto? Proyecto=GuardarJson.proyectosActuales.FirstOrDefault(a=>a.Id==id);
        return Proyecto;
    }

        public static int UltimoNum(string tipo)
        {
            if (tipo=="Tarea")
            {
            int MaxNum = GuardarJson.proyectosActuales.Max(c => c.Id);
            return MaxNum+1;
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