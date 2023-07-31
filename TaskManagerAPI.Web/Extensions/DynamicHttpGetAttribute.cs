namespace TaskManagerAPI.Web.Extensions
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class DynamicHttpGetAttribute : Attribute
    {
        public string RouteTypeName { get; }

        public DynamicHttpGetAttribute(Type type)
        {
            RouteTypeName = type.Name;
        }
    }
}
