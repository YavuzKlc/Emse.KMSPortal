using Emse.Framework;

namespace Emse.KMSPortal.Data.Model
{
    public class GlobalSettings : Entity<int>
    {
        public string ErrorLogFileDirectory { get; set; }

        public string TestURL { get; set; }

        public string ProductionURL { get; set; }

        public string SMTPServerIP { get; set; }

        public string SMTPServerPort { get; set; }

        public string SMTPServerMailAddress { get; set; }

        public string SMTPServerMailPassword { get; set; }

        public string SMTPServerSecure { get; set; }

        public string MailReceiverForException { get; set; }

        public string SMTPUsername { get; set; }
    }
}
