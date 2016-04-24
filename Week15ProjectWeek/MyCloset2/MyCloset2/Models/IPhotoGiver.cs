using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCloset2.Models
{
    public interface IPhotoGiver
    {
        string PhotoURL { get; set; }
        string Season { get; set; }
    }
}

//http://stackoverflow.com/questions/23536299/mvc-5-multiple-models-in-a-single-view