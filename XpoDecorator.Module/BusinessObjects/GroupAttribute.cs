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
    public class GroupAttribute : BaseObject
    {
        public GroupAttribute(Session session) : base(session)
        { }


        string notes;
        Attribute attribute;
        Group group;

        [Association("Group-GroupAttributes")]
        public Group Group
        {
            get => group;
            set => SetPropertyValue(nameof(Group), ref group, value);
        }


        public Attribute Attribute
        {
            get => attribute;
            set => SetPropertyValue(nameof(Attribute), ref attribute, value);
        }

        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Notes
        {
            get => notes;
            set => SetPropertyValue(nameof(Notes), ref notes, value);
        }
    }
}
