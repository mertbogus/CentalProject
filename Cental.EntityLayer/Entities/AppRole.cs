using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.EntityLayer.Entities
{
    //appuser ile bağlantısı olduğu için buradaki id değerini int yapıyoruz.
    public class AppRole : IdentityRole<int>
    {
    }
}
