using System.Linq;

namespace AngryMonkey
{
    public class AccessTest
    {
        public enum AccessRight { Read, Create, Update, Delete, Full }

        public bool HasAccess(AccessRight[] userAccessRights, AccessRight requiredAccessRight)
        {
            foreach (var right in userAccessRights)
            {
                if (right == requiredAccessRight)
                   return true;
            }
            return false;
        }
    }
}
