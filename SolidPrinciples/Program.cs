using Unity;

namespace SolidPrinciples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<IMessageReader, MessageReader>();
            container.RegisterType<IMessageWriter, SocialMediaMessageWriter>();

            var app = container.Resolve<Application>();
            app.Run();
        }
    }
}