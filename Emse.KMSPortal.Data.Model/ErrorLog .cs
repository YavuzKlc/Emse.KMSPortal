using Emse.Framework;
using Emse.KMSPortal.Data.Model.Enums;
using System;

namespace Emse.KMSPortal.Data.Model
{
    public class ErrorLog : Entity<Guid>
    {
        public string MethodName { get; set; }

        public string ErrorMessage { get; set; }

        public string StackTrace { get; set; }

        public string Detail { get; set; }

        public string Source { get; set; }

    }
}
