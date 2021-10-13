using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XpoDecorator.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Attribute : XPObject
    {
        public Attribute(Session session) : base(session)
        { }


        string attributeName;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string AttributeName
        {
            get => attributeName;
            set => SetPropertyValue(nameof(AttributeName), ref attributeName, value);
        }


        [Association("Attribute-AttributeValues"),Aggregated]
        public XPCollection<AttributeValue> PossibleAttributeValues
        {
            get
            {
                return GetCollection<AttributeValue>(nameof(PossibleAttributeValues));
            }
        }
    }
}
