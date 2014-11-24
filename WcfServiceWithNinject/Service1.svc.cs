using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceWithNinject
{
public class Service1 : IService1
{
    private IRepository _repo;
    public Service1(IRepository repo)
    {
        _repo = repo;
    }
    public string TellMeHowManyWidgets()
    {
        return string.Format(
            "We have {0} widgets.", _repo.GetWidgets().Count());
    }
    public string GetData(int value)
    {
        return string.Format("You entered: {0}", value);
    }

    public CompositeType GetDataUsingDataContract(CompositeType composite)
    {
        if (composite == null)
        {
            throw new ArgumentNullException("composite");
        }
        if (composite.BoolValue)
        {
            composite.StringValue += "Suffix";
        }
        return composite;
    }
}
}
