using System.Reflection.PortableExecutable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTrackR.API.Entities;

public class package
{
    public package(int title, decimal weight)
    {
        
        Title = title;
        Weight = weight;
    }

    public int Id { get; private set; }
   public String Code { get; private set; } 
   public int  Title { get; private set; }
   public decimal Weight  { get; private set; }
   public bool Delivered  { get; private set; }
   public DateTime PostedAt { get; private set; }
   public int MyProperty { get; private set; }

   public List<PackageUpdate> Updates { get; private set; }

}