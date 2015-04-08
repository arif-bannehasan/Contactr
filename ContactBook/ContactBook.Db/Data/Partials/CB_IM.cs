﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Db.Data
{
    public partial class CB_IM : IEquatable<CB_IM>, INewEntity<CB_IM>, IEntityCloneable<CB_IM>
    {
        static Lazy<IEqualityComparer<CB_IM>> comparer = new Lazy<IEqualityComparer<CB_IM>>(true);

        public static IEqualityComparer<CB_IM> Comparer
        {
            get
            {
                return comparer.Value;
            }
        }

        public class CBIMComparer : IEqualityComparer<CB_IM>
        {
            public bool Equals(CB_IM x, CB_IM y)
            {
                if (x.IMId.Equals(y.IMId))
                {
                    return true;
                }
                return false;
            }

            public int GetHashCode(CB_IM obj)
            {
                return obj.IMId.GetHashCode();
            }
        }

        public bool Equals(int id)
        {
            if (this.IMId.Equals(id))
            {
                return true;
            }
            return false;
        }

        public bool Equals(CB_IM other)
        {
            if (other.IMId.Equals(this.IMId) 
                && other.IMTypeId.Equals(this.IMTypeId) 
                && other.Username.Equals(this.Username)
                && other.ContactId.Equals(this.ContactId))
            {
                return true;
            }
            return false;
        }

        public CB_IM Clone(object obj)
        {
            if (obj == null)
            {
                return default(CB_IM);
            }
            
            CB_IM actObj = obj as CB_IM;

            return new CB_IM() { 
            ContactId = actObj.ContactId,
            IMId = actObj.IMId,
            IMTypeId = actObj.IMTypeId,
            Username = actObj.Username
            };
        }
    }
}
