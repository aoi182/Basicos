using System;

namespace WebApplication.Model
{
    [Serializable]
    public class DataInfo
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string Image { get; set; }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return GetHashCode() == ((DataInfo) obj).GetHashCode();
        }
        
        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }
    }
}