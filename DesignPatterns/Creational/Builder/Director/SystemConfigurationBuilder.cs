


namespace DesignPatterns.Creational.Builder.Director
{
    using IBuilder;
    using System.Collections.Specialized;

    public class SystemConfigurationBuilder
    {
        public void BuildSystem(ISystemBuilder systemBuilder, NameValueCollection collection)
        {
            systemBuilder.AddHDD(collection["HDD"]);
            systemBuilder.AddRAM(collection["RAM"]);
            systemBuilder.AddMouse(collection["Mouse"]);
            systemBuilder.AddKeyboard(collection["Keyboard"]);
            systemBuilder.AddTouchScreen(collection["TouchScreen"]);
        }
    }
}
