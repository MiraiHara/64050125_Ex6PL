using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RegularCustomer : Customer
{
    public override string CreateMail()
    {
        return "Regular Customer";
    }
}
