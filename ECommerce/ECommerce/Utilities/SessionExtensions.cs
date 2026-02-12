//Clase Creada Para El Control De Sesiones
using System.Text.Json;

namespace ECommerce.Utilities
{
    public static class SessionExtensions
    {
        //Metodo Para Agregar Al Objeto
        public static void Set<T>(this ISession session, string key, T Value)
        {
            session.SetString(key,JsonSerializer.Serialize(Value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default : JsonSerializer.Deserialize<T>(value);
        }

    }
}
