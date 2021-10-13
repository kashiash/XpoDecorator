using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XpoDecorator.Module.BusinessObjects
{
    public class AttributeValue : BaseObject
    {
        public AttributeValue(Session session) : base(session)
        { }


        
        [Association("Attribute-AttributeValues")]
        public Attribute Attribute
        {
            get => attribute;
            set => SetPropertyValue(nameof(Attribute), ref attribute, value);
        }

        Attribute attribute;
        string _value;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Value
        {
            get => _value;
            set => SetPropertyValue(nameof(Value), ref _value, value);
        }
    }
}
