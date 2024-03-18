using ANK16ProductApplication.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK16ProductApplication.DAL.Repository.Abstract
{

    //hepsinin temelini oluşturacak olan varlığın arabirimi
    public interface IEntity
    {
        int Id { get; set; }
        
        DateTime CreatedDate { get; set; }

        DateTime? UpdatedDate { get; set; }

        DateTime? DeletedDate { get; set; }

        Status Status { get; set; }




    }
}
