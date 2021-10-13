using DevExpress.ExpressApp.DC;
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

    public class Product : BaseObject, IProduct
    {
        public Product(Session session) : base(session)
        { }



    
        string notes;
        string gTIN;
        string name;
        string symbol;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Symbol
        {
            get => symbol;
            set => SetPropertyValue(nameof(Symbol), ref symbol, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string ProductName
        {
            get => name;
            set => SetPropertyValue(nameof(ProductName), ref name, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string GTIN
        {
            get => gTIN;
            set => SetPropertyValue(nameof(GTIN), ref gTIN, value);
        }


        [Size(SizeAttribute.Unlimited)]
        public string Notes
        {
            get => notes;
            set => SetPropertyValue(nameof(Notes), ref notes, value);
        }


        [Association("Product-ProductAttributes"), DevExpress.Xpo.Aggregated]
        public XPCollection<ProductAttribute> ProductAttributes
        {
            get
            {
                return GetCollection<ProductAttribute>(nameof(ProductAttributes));
            }
        }


        Product prod;
        public Product Prod
        {
            get {

                if (prod == null)
                { prod = this;
                
                }
                return prod;
            }
            set {
                prod = value;
            }
        }

    }
}
