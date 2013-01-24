using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfPwc
{
    public class EvaluationComparer : IEqualityComparer<Evaluation>
    {
        public bool Equals(Evaluation x, Evaluation y)
        {
            if (Object.Equals(x, y))
                return true;
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            return x.phaseNum == y.phaseNum || x.fK_activityId == y.fK_activityId || x.fK_branchId == y.fK_branchId;
        }

        public int GetHashCode(Evaluation item)
        {
            if (Object.ReferenceEquals(item, null)) return 0;
            int hastPhase = item.phaseNum.GetHashCode();
            int hashActivity = item.fK_activityId.GetHashCode();
            int hashBranch =  item.fK_branchId.GetHashCode();

            return hashBranch ^ hastPhase ^ hashActivity;
        }

    }
}