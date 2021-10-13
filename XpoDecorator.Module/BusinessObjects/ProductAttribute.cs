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
    public class ProductAttribute : BaseObject
    {
        public ProductAttribute(Session session) : base(session)
        { }

        
        [Association("Product-ProductAttributes")]
        public Product Product
        {

            get => product;
            set => SetPropertyValue(nameof(Product), ref product, value);
        }

        Attribute attribute;
        AttributeValue _value;
        Product product;


        
        public Attribute Attribute
        {
            get => attribute;
            set => SetPropertyValue(nameof(Attribute), ref attribute, value);
        }
        [DataSourceProperty("Attribute.PossibleAttributeValues")]
        public AttributeValue Value

        {
            get => _value;
            set => SetPropertyValue(nameof(Value), ref _value, value);
        }
    }
}
