using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XpoDecorator.Module.BusinessObjects
{
    [DefaultClassOptions]

    public class MedicalProduct : BaseObject, IProduct
    {
        public MedicalProduct(Session session) : base(session)
        { }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string AdditionalInfo

        {
            get => additionalInfo;
            set => SetPropertyValue(nameof(AdditionalInfo), ref additionalInfo, value);
        }

        Product prod;
        string additionalInfo;

        

        public Product Prod
        {
            get => prod;
            set => SetPropertyValue(nameof(Prod), ref prod, value);
        }
    }
}
