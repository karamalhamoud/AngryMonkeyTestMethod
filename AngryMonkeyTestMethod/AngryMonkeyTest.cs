using System.Linq;

namespace AngryMonkey
{
    public class AccessTest
    {
        public enum AccessRight
        { Read, Create, Update, Delete, Full }
        public static bool HasAccess(AccessRight[] userAccessRights, AccessRight requiredAccessRight)
        {
            bool result = false;
            if (requiredAccessRight == AccessRight.Full)
                if (userAccessRights.Contains(AccessRight.Full)) result = true;
            if (requiredAccessRight == AccessRight.Read)
                if (userAccessRights.Contains(AccessRight.Full) || userAccessRights.Contains(AccessRight.Read)) result = true;
            if (requiredAccessRight == AccessRight.Create)
                if (userAccessRights.Contains(AccessRight.Full) || userAccessRights.Contains(AccessRight.Create)) result = true;
            if (requiredAccessRight == AccessRight.Update)
                if (userAccessRights.Contains(AccessRight.Full) || userAccessRights.Contains(AccessRight.Update)) result = true;
            if (requiredAccessRight == AccessRight.Delete)
                if (userAccessRights.Contains(AccessRight.Full) || userAccessRights.Contains(AccessRight.Delete)) result = true;
            return result;
        }
    }
}