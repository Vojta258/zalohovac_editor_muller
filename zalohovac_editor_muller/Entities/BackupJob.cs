namespace zalohovac_editor_muller.Entities
{
    public class BackupJob
    {
        public List <string> Sources { get; set; }
        public List <string> Targets { get; set; }
        public string Timing { get; set; }
        public BackupMethod Method { get; set; }
        public BackupRetention Retention { get; set; }


    }
}
