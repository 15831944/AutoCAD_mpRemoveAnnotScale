using mpPInterface;

namespace mpRemoveAnnotScale
{
    public class Interface : IPluginInterface
    {
        public string Name => "mpRemoveAnnotScale";
        public string AvailCad => "2013";
        public string LName => "Очистить масштабы";
        public string Description => "Очищает список аннотативных масштабов в выбранных аннотативных объектах, оставляя текущий масштаб";
        public string Author => "Пекшев Александр aka Modis";
        public string Price => "0";
    }
    public class VersionData
    {
        public const string FuncVersion = "2013";
    }
}
