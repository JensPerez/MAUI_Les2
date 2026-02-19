using System;
using System.Collections.Generic;
using System.Text;
using Les2.Models;

namespace Les2.Data
{
    public interface IWerknemerRepo
    {
        List<Werknemer> GetWerknemers();

    }
}
