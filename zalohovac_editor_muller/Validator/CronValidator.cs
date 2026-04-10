using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using zalohovac_editor_muller.Entities;

namespace zalohovac_editor_muller.Validator
{
    public class CronValidator
    {
        public void Validate(BackupJob entity)
        {
            if (!ValidationCron(entity.Timing))
                throw new Exception("Timing (Cron string) is not valid");
        }

        public bool ValidationCron(string? cron)
        {
            Regex regex = new Regex(@"^(\*|[0-5]?\d)\s+(\*|[01]?\d|2[0-3])\s+(\*|[012]?\d|3[01])\s+(\*|[01]?\d)\s+(\*|[0-6])$");

            return cron == null
                || (regex.IsMatch(cron));
        }

        

    }


}
