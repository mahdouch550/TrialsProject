using System;
using System.Collections.Generic;

namespace TrialsProject.SageRecruitment
{
    public class SageRecruitmentDataCloneSqlJobs
    {
        private String SourceConnectionString;
        private String DestinationConnextionString;

        #region Queries

        #endregion

        public SageRecruitmentDataCloneSqlJobs(String SourceConnectionString, String DestinationConnextionString)
        {
            this.DestinationConnextionString = DestinationConnextionString;
            this.SourceConnectionString = SourceConnectionString;
        }
        
    }
}